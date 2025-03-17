using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Business.services;

namespace BookHaven.Forms
{
    public partial class OrderManagement : Form
    {
        private readonly OrderService _orderService;

        public OrderManagement(OrderService orderService)
        {
            _orderService = orderService;
            InitializeComponent();
            LoadOrders();
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ordersGridView.Rows[e.RowIndex];

                // Load data from the selected row into the respective fields
                id.Text = row.Cells["Id"].Value.ToString();
                statusComboBox.Text = row.Cells["Status"].Value.ToString();

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string key = search.Text;
            //DateTime? createdDate = createdDatePicker.Value;

            var orders = _orderService.SearchOrders(key, null);
            ordersGridView.DataSource = orders.Select(o => new
            {
                o.Id,
                o.CustomerId,
                o.CreatedDate,
                o.ModifiedDate,
                o.Status,
                o.UserId,
                o.Discount,
                o.TotalAmount,
                o.NetAmount
            }).ToList();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (id.Text != null)
            {
                int orderId = int.Parse(id.Text);
                string status = statusComboBox.SelectedItem.ToString();

                _orderService.UpdateOrderStatus(orderId, status);
                MessageBox.Show("Order status updated successfully.");
                ClearFields();
                //LoadOrders();
            }
            else
            {
                MessageBox.Show("Please select an order.");
            }
        }

        private void LoadOrders()
        {
            var orders = _orderService.GetAll();
            ordersGridView.DataSource = orders.Select(o => new
            {
                o.Id,
                o.CustomerId,
                o.CreatedDate,
                o.ModifiedDate,
                o.Status,
                o.UserId,
                o.Discount,
                o.TotalAmount,
                o.NetAmount
            }).ToList();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var dashboard = new AdminDashboard();

            Common.Common.goBack(this, dashboard);
        }

        private void onValueChange(object sender, EventArgs e)
        {
            DateTime? createdDate = createdDatePicker.Value;

            var orders = _orderService.SearchOrders(null, createdDate);
            ordersGridView.DataSource = orders.Select(o => new
            {
                o.Id,
                o.CustomerId,
                o.CreatedDate,
                o.ModifiedDate,
                o.Status,
                o.ModifiedUser,
                o.Discount,
                o.TotalAmount,
                o.NetAmount
            }).ToList();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            id.Clear();
            statusComboBox.Text = "Status";
            LoadOrders();
        }

        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ordersGridView.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(row.Cells["Id"].Value);

                // Open the Order Details form and pass the Order ID
                OrderDetailView detailsView = new OrderDetailView(orderId);
                detailsView.ShowDialog(); // Show as a modal popup
            }
        }
    }

}
