using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using BookHaven.Business.services;
using BookHaven.Common;
using BookHaven.Data;
using BookHaven.Data.entity;
using BookHaven.Data.repository;
using Microsoft.VisualBasic.Devices;
using RepoDb.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookHaven.Forms
{
    public partial class CustomerPos : Form
    {
        private readonly BookService _bookService;
        private readonly OrderService _orderService;
        private readonly CustomerService _customerService;
        public decimal _totalPrice;
        public int _orderId;
        public String[] stockOrderUid;

        public CustomerPos(BookService bookService, CustomerService customerService)
        {
            _orderId = 0;
            _bookService = bookService;
            _orderService = new OrderService(new OrderRepository(new AppDbContext()),
                new OrderDetailRepository(new AppDbContext()));
            InitializeComponent();
            stockOrderUid = new String[1];
            _customerService = customerService;
            LoadStatus();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = search.Text;
            var customers = _customerService.SearchCustomers(keyword);
            cusGridView.DataSource = customers.Select(cus => new
            {
                cus.FirstName,
                cus.LastName,
                cus.Contact,
                cus.Email,
                cus.Address,
                cus.PostalCode,
                cus.CustomerId
            }).ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addCusBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();

            var customerManagement = new CustomerManagement(
                new CustomerService(
                    new CustomerRepository(
                        new AppDbContext())));

            customerManagement.Show();
        }

        private void addViewBtn_Click(object sender, EventArgs e)
        {

            if (cusId.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please select a customer befor place orde.");
                return;
            }

            if (_orderId == 0)
            {

                string uniqueId = Guid.NewGuid().ToString();
                var order = new Order();
                stockOrderUid[0] = uniqueId;
                order.UniqueId = uniqueId;
                order.Status = statusBox.Text;
                order.UserId = SessionManager.CurrentUserId;
                order.CustomerId = Convert.ToInt32(cusId.Text);
                order = _orderService.PlaceOrder(order);
                _orderId = order.Id;

            }

            loadStockOrderItemForm(_orderId);
        }

        void loadStockOrderItemForm(int orderId)
        {
            var placeStockOrderForm = new PlaceStockOrder(
                new StockOrderService(new StockOrderRepository(new AppDbContext())),
                new BookService(new BookRepository(new AppDbContext())),
                new OrderService(new OrderRepository(new AppDbContext()), new OrderDetailRepository(new AppDbContext())),
                orderId,
                this,
                true  // This is a customer order
            );

            placeStockOrderForm.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (total.Text == null || total.Text.Equals(""))
            {
                MessageBox.Show("Please create an order!");
                return;
            }

            var order = _orderService.GetById(Convert.ToInt32(orderId.Text));
            if (order != null)
            {

                var ordDetail = _orderService.GetOrderDetailByOrderId(Convert.ToInt32(orderId.Text));
                ReceiptGenerator.GenerateReceipt(order, ordDetail);
            }

            clearFields();

        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = cusGridView.Rows[e.RowIndex];

                // Load data from the selected row into the respective fields
                cusId.Text = row.Cells["CustomerId"].Value.ToString();
                cusName.Text = row.Cells["FirstName"].Value.ToString() + " " + row.Cells["LastName"].Value.ToString();
                contact.Text = row.Cells["Contact"].Value.ToString();
                email.Text = row.Cells["Email"].Value.ToString();
            }
        }

        public void LoadOrders(int ordId)
        {
            if (ordId != null && !ordId.Equals(""))
            {
                var orderDetailList = _orderService.GetOrderDetailByOrderId(ordId);

                if (orderDetailList != null && orderDetailList.Count > 0)
                {

                    decimal totalOrderAmount = orderDetailList.Sum(od => od.TotalPrice);
                    total.Text = totalOrderAmount.ToString();
                    orderId.Text = orderDetailList[0].OrderId.ToString();

                }
            }
            else
            {
                MessageBox.Show("Order processing failed. Try again!");
            }


        }

        private void loadCustomer(int customerId)
        {
            var customer = _customerService.GetCustomerById(customerId);
            if (customer != null)
            {
                cusGridView.DataSource = new[]
                {
                    new{
                        customer.FirstName,
                        customer.LastName,
                        customer.Contact,
                        customer.Email,
                        customer.Address,
                        customer.PostalCode,
                        customer.CustomerId
                    }
                };

                cusId.Text = customer.CustomerId.ToString();
                cusName.Text = customer.FirstName + " " + customer.LastName;
                contact.Text = customer.Contact;
                email.Text = customer.Email;

            }
            else
            {

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            var dashboard = new AdminDashboard();

            Common.Common.goBack(this, dashboard);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stockOrderUid[0] == null || stockOrderUid[0].Equals(""))
            {
                MessageBox.Show("Order processing failed. Try again!");
                return;
            }

            var order = _orderService.GetByUid(stockOrderUid[0]);

            if (order == null)
            {
                MessageBox.Show("Order processing failed. Try again!");
                return;
            }

            if (statusBox.Text == null || statusBox.Text.Equals(""))
            {
                order.Status = "InStoreCompleted";
            }
            else
            {
                order.Status = statusBox.Text;
            }

            order.CreatedDate = DateTime.Now;
            order.ModifiedDate = DateTime.Now;
            order.CustomerId = int.Parse(cusId.Text);
            order.UniqueId = stockOrderUid[0];
            decimal.TryParse(total.Text, out decimal tot);
            order.TotalAmount = tot;


            if (discount.Text != null && !discount.Text.Trim().Equals(""))
            {
                if (decimal.TryParse(discount.Text, out decimal disc))
                {
                    order.Discount = disc;
                    order.NetAmount = tot - disc;
                }
                else
                {
                    MessageBox.Show("Invalid discount!");
                };
            }
            else
            {
                order.NetAmount = tot;
            }

            var ordDetail = _orderService.GetOrderDetailByOrderId(order.Id);
            order.OrderDetails = ordDetail;
            gross.Text = order.NetAmount.ToString();
            _orderService.updateOrder(order);
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadStatus()
        {

            // Populate the status combo box
            statusBox.Items.Add("InStoreCompleted");
            statusBox.Items.Add("ToDeliver");
            statusBox.Items.Add("Canceled");
            statusBox.Items.Add("DeliverCompleted");
            statusBox.SelectedIndex = 0;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        void clearFields()
        {

            statusBox.SelectedIndex = 0;
            cusId.Clear();
            cusName.Clear();
            email.Clear();
            contact.Clear();
            orderId.Clear();
            total.Clear();
            discount.Clear();
            gross.Clear();

            _orderId = 0;
            stockOrderUid[0] = null;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
