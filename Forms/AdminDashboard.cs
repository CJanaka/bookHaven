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
using BookHaven.Data;
using BookHaven.Data.repository;

namespace BookHaven.Forms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void bookMngBtn_Click(object sender, EventArgs e)
        {

            this.Hide();

            var bookInventoryForm = new BookManagement(
                new BookService(
                    new BookRepository(
                        new AppDbContext())));

            bookInventoryForm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var customerManagement = new CustomerManagement(
                new CustomerService(
                    new CustomerRepository(
                        new AppDbContext())));

            customerManagement.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            var orderManagement = new OrderManagement(
                new OrderService(new OrderRepository(new AppDbContext()), new OrderDetailRepository(new AppDbContext())));

            orderManagement.Show();
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var supplierManagement = new SupplierManagement(
                new SupplierService(
                    new SupplierRepository(
                        new AppDbContext())));

            supplierManagement.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            var stockManagement = new StockOrderManagement(
                new StockOrderService(
                    new StockOrderRepository(
                        new AppDbContext())));

            stockManagement.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        //customer pos
        {
            this.Hide();

            var customerPos = new CustomerPos(
                new BookService(
                    new BookRepository(
                        new AppDbContext())),
                new CustomerService(new CustomerRepository(new AppDbContext())));

            customerPos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
