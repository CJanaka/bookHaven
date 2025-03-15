using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using BookHaven.Business.services;
using BookHaven.Data;
using BookHaven.Data.entity;
using BookHaven.Data.repository;
using BookHaven.Migrations;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookHaven.Forms
{
    public partial class CustomerPos : Form
    {
        private readonly BookService _bookService;
        private readonly OrderService _orderService;
        private readonly CustomerService _customerService;
        public decimal _totalPrice;
        public String[] stockOrderUid;

        public CustomerPos(BookService bookService, CustomerService customerService)
        {
            _bookService = bookService;
            _orderService = new OrderService(new OrderRepository(new AppDbContext()),
                new OrderDetailRepository(new AppDbContext()));
            InitializeComponent();
            stockOrderUid = new String[1];
            _customerService = customerService;
            //bookBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //bookBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            //bookBox.DropDownStyle = ComboBoxStyle.DropDown;
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

        //private void comboBox1_TextChanged(object sender, EventArgs e)
        //{
        //    string filter = bookBox.Text.ToLower();
        //    var filteredSuppliers = _bookService.SearchBooks(filter);

        //    bookBox.DataSource = null;
        //    bookBox.DataSource = filteredSuppliers;
        //    bookBox.DisplayMember = "Title"; // Adjust according to your book entity
        //    bookBox.ValueMember = "Id";

        //    bookBox.DroppedDown = true; // Keep dropdown open while typing
        //    Cursor.Current = Cursors.Default;
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addCusBtn_Click(object sender, EventArgs e)
        {

        }

        private void addViewBtn_Click(object sender, EventArgs e)
        {
            if (stockOrderUid.Length > 0)
            {

                string uniqueId = Guid.NewGuid().ToString();
                var order = new Order();

                if (statusBox.Text == null || statusBox.Text.Equals(""))
                {
                    order.Status = "InStoreCompleted";
                }
                else { 
                    order.Status = statusBox.Text;
                }

                order.CreatedDate = DateTime.Now;
                order.ModifiedDate = DateTime.Now;
                order.CustomerId = int.Parse(cusId.Text);
                order.UniqueId = uniqueId;
                decimal.TryParse(total.Text, out decimal tot);
                order.TotalAmount = tot;


                if (discount.Text != null)
                {
                    decimal.TryParse(discount.Text, out decimal disc);
                    order.Discount = disc;
                    order.NetAmount = tot - disc;
                }
                else {
                    order.NetAmount = tot;
                }

                stockOrderUid[0] = uniqueId;
                _orderService.PlaceOrder(order);

            }

            loadStockOrderItemForm(stockOrderUid[0]);
        }

        void loadStockOrderItemForm(String uid)
        {
            var placeStockOrderForm = new PlaceStockOrder(
                new StockOrderService(new StockOrderRepository(new AppDbContext())),
                new BookService(new BookRepository(new AppDbContext())),
                new OrderService(new OrderRepository(new AppDbContext()), new OrderDetailRepository(new AppDbContext())),
                uid,
                this,
                true  // This is a customer order
            );

            placeStockOrderForm.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {

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

        public void LoadStockOrders(String uniqueId)
        {

            if (stockOrderUid.Length > 0)
            {
                var order = _orderService.GetByUid(stockOrderUid[0]);

                if (order != null)
                {
                    total.Text = order.TotalAmount.ToString();
                    int customerId = order.CustomerId;
                    loadCustomer(customerId);
                }
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
    }
}
