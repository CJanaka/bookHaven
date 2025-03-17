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
using BookHaven.Business.services;
using BookHaven.Data.entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookHaven.Forms
{
    public partial class CustomerManagement : Form
    {
        private readonly CustomerService _customerService;
        public CustomerManagement(CustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
            loadCustomers();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FirstName = fName.Text,
                LastName = lName.Text,
                Contact = contact.Text,
                Email = email.Text,
                Address = address.Text,
                PostalCode = pCode.Text
            };

            _customerService.AddCustomer(customer);
            MessageBox.Show("Customer added successfully!");
            clearFields();
            loadCustomers();
        }

        private void loadCustomers()
        {
            var customers = _customerService.GetAllCustomers();
            customersGridView.DataSource = customers.Select(cus => new
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = search.Text;
            var customers = _customerService.SearchCustomers(keyword);
            customersGridView.DataSource = customers.Select(cus => new
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

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customersGridView.Rows[e.RowIndex];

                // Load data from the selected row into the respective fields
                id.Text = row.Cells["CustomerId"].Value.ToString();
                fName.Text = row.Cells["FirstName"].Value.ToString();
                lName.Text = row.Cells["LastName"].Value.ToString();
                contact.Text = row.Cells["Contact"].Value.ToString();
                email.Text = row.Cells["Email"].Value.ToString();
                address.Text = row.Cells["Address"].Value.ToString();
                pCode.Text = row.Cells["PostalCode"].Value.ToString();
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            id.Clear();
            fName.Clear();
            lName.Clear();
            contact.Clear();
            email.Clear();
            address.Clear();
            pCode.Clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (id.Text != null)
            {
                int cusId = Convert.ToInt32(id.Text);
                _customerService.DeleteCustomer(cusId);
                loadCustomers();
                clearFields();
                MessageBox.Show("Customer deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a record.");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (id.Text != null)
            {
                int cusId = int.Parse(id.Text);
                var customer = _customerService.GetCustomerById(cusId);

                customer.FirstName = fName.Text;
                customer.LastName = lName.Text;
                customer.Contact = contact.Text;
                customer.Email = email.Text;
                customer.Address = address.Text;
                customer.PostalCode = pCode.Text;

                _customerService.UpdateCustomer(customer);
                clearFields();
                loadCustomers();
                MessageBox.Show("customer updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a record.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var dashboard = new AdminDashboard();

            Common.Common.goBack(this, dashboard);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
