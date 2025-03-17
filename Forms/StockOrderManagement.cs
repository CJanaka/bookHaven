using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Business.services;
using BookHaven.Data.repository;
using BookHaven.Data;
using BookHaven.Data.entity;
using System.Xml;
using System.Diagnostics;

namespace BookHaven.Forms
{
    public partial class StockOrderManagement : Form
    {
        private readonly StockOrderService _stockOrderService;
        private readonly SupplierService _supplierService;
        public String[] stockOrderUid;

        public StockOrderManagement(StockOrderService stockOrderService)
        {
            _stockOrderService = stockOrderService;
            _supplierService = new SupplierService(new SupplierRepository(new AppDbContext()));
            InitializeComponent();
            LoadSuppliers();
            LoadStockOrders();
            stockOrderUid = new String[1];
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = stockOrdersGridView.Rows[e.RowIndex];

                // Load data from the selected row into the respective fields
                stockOrderId.Text = row.Cells["Id"].Value.ToString();
                supplierComboBox.SelectedValue = Convert.ToInt32(row.Cells["SupplierId"].Value);
                statusDropdown.Text = row.Cells["Status"].Value.ToString();

            }
        }

        private void LoadSuppliers()
        {
            var suppliers = _supplierService.GetAllSuppliers();
            supplierComboBox.DataSource = suppliers;
            supplierComboBox.DisplayMember = "Name";
            supplierComboBox.ValueMember = "Id";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            if (stockOrderUid.Length > 0)
            {

                if (statusDropdown.SelectedItem == null || statusDropdown.SelectedItem.Equals(""))
                {

                    MessageBox.Show("Please select the status.");
                    return;
                }

                string uniqueId = Guid.NewGuid().ToString();
                var stockOrder = new StockOrder
                {
                    //int selectedBookId = Convert.ToInt32(bookComboBox.SelectedValue);
                    SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue),
                    CreatedDateTime = DateTime.Now,
                    ModifiedDateTime = DateTime.Now,
                    Status = statusDropdown.SelectedItem.ToString(),
                    UniqueId = uniqueId
                };
                stockOrderUid[0] = uniqueId;
                _stockOrderService.AddStockOrder(stockOrder);
                //MessageBox.Show("Add book");
            }

            //loadStockOrderItemForm(stockOrderUid[0]);
            ClearFields();
            LoadStockOrders();
        }

        void loadStockOrderItemForm(int orderId)
        {
            var placeStockOrderForm = new PlaceStockOrder(
                new StockOrderService(new StockOrderRepository(new AppDbContext())),
                new BookService(new BookRepository(new AppDbContext())),
                new OrderService(new OrderRepository(new AppDbContext()), new OrderDetailRepository(new AppDbContext())),
                orderId,
                this,
                false  // Not a customer order
            );

            placeStockOrderForm.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (stockOrderId.Text != null)
            {
                int stockOrdId = int.Parse(stockOrderId.Text);
                var stockOrder = _stockOrderService.GetStockOrderById(stockOrdId);

                stockOrder.Status = statusDropdown.SelectedText;
                stockOrder.SupplierId = Convert.ToInt32(supplierComboBox.SelectedValue);


                _stockOrderService.UpdateStockOrder(stockOrder);
                ClearFields();
                LoadStockOrders();
                MessageBox.Show("Stock order updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a record.");
            }
        }

        private void ClearFields()
        {
            statusDropdown.SelectedValue = 0;
            supplierComboBox.SelectedValue = 0;
            stockOrderId.Clear();

        }

        public void LoadStockOrders()
        {
            var stockOrders = _stockOrderService.GetAllStockOrders();
            stockOrdersGridView.DataSource = stockOrders.Select(o => new
            {
                o.Id,
                o.SupplierId,
                o.CreatedDateTime,
                o.ModifiedDateTime,
                o.Status,
                o.UniqueId
            }).ToList();
        }

        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0) return;

            DataGridViewRow row = stockOrdersGridView.Rows[e.RowIndex];

            String uid = row.Cells["UniqueId"].Value.ToString();
            //get order from uid and pass orderId bellow
            //loadStockOrderItemForm(uid);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            var dashboard = new AdminDashboard();

            Common.Common.goBack(this, dashboard);
        }
    }
}
