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
using BookHaven.Data.entity;

namespace BookHaven.Forms
{
    public partial class SupplierManagement : Form
    {
        private readonly SupplierService _supplierService;

        public SupplierManagement(SupplierService supplierService)
        {
            _supplierService = supplierService;
            InitializeComponent();
            LoadSuppliers();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            var dashboard = new AdminDashboard();

            Common.Common.goBack(this, dashboard);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id.Text))
            {
                int supplierId = int.Parse(id.Text);
                var supplier = _supplierService.GetSupplierById(supplierId);

                supplier.Name = name.Text;
                supplier.Contact = contact.Text;
                supplier.Email = email.Text;

                _supplierService.UpdateSupplier(supplier);
                ClearFields();
                LoadSuppliers();
                MessageBox.Show("Supplier updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a record.");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier
            {
                Name = name.Text,
                Contact = contact.Text,
                Email = email.Text
            };

            _supplierService.AddSupplier(supplier);
            ClearFields();
            LoadSuppliers();
            MessageBox.Show("Supplier added successfully.");
        }

        private void LoadSuppliers()
        {
            var suppliers = _supplierService.GetAllSuppliers();
            suppliersGridView.DataSource = suppliers.Select(s => new
            {
                s.Id,
                s.Name,
                s.Contact,
                s.Email
            }).ToList();
        }

        private void ClearFields()
        {
            id.Clear();
            name.Clear();
            contact.Clear();
            email.Clear();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = suppliersGridView.Rows[e.RowIndex];

                id.Text = row.Cells["Id"].Value.ToString();
                name.Text = row.Cells["Name"].Value.ToString();
                contact.Text = row.Cells["Contact"].Value.ToString();
                email.Text = row.Cells["Email"].Value.ToString();
            }
        }
    }
}
