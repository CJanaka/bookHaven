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
using BookHaven.Common;
using BookHaven.Data;
using BookHaven.Data.entity;
using BookHaven.Data.repository;

namespace BookHaven.Forms
{
    public partial class BookManagement : Form
    {
        private readonly BookService _bookService;

        public BookManagement(BookService bookService)
        {
            _bookService = bookService;
            InitializeComponent();
            LoadBooks();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = title.Text,
                Author = author.Text,
                Genre = genre.Text,
                Isbn = isbn.Text,
                Price = decimal.Parse(price.Text),
                StockQuantity = int.Parse(quantity.Text)
            };

            _bookService.AddBook(book);
            ClearFields();
            LoadBooks();
            MessageBox.Show("Book added successfully.");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (id.Text != null)
            {
                int bookId = int.Parse(id.Text);
                var book = _bookService.GetBookById(bookId);

                book.Title = title.Text;
                book.Author = author.Text;
                book.Genre = genre.Text;
                book.Isbn = isbn.Text;
                book.Price = decimal.Parse(price.Text);
                book.StockQuantity = int.Parse(quantity.Text);

                _bookService.UpdateBook(book);
                ClearFields();
                LoadBooks();
                MessageBox.Show("Book updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a record.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (id.Text != null)
            {
                int bookId = int.Parse(id.Text);
                _bookService.DeleteBook(bookId);
                LoadBooks();
                ClearFields();
                MessageBox.Show("Book deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a record.");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = search.Text;
            var books = _bookService.SearchBooks(keyword);
            booksGridView.DataSource = books.Select(b => new
            {
                b.Id,
                b.Title,
                b.Author,
                b.Genre,
                b.Isbn,
                b.Price,
                b.StockQuantity
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back button click

            var dashboard = new AdminDashboard();

            Common.Common.goBack(this, dashboard);
        }

        private void LoadBooks()
        {
            var books = _bookService.GetAllBooks();
            booksGridView.DataSource = books.Select(b => new
            {
                b.Id,
                b.Title,
                b.Author,
                b.Genre,
                b.Isbn,
                b.Price,
                b.StockQuantity
            }).ToList();
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = booksGridView.Rows[e.RowIndex];

                // Load data from the selected row into the respective fields
                id.Text = row.Cells["Id"].Value.ToString();
                title.Text = row.Cells["Title"].Value.ToString();
                author.Text = row.Cells["Author"].Value.ToString();
                isbn.Text = row.Cells["Isbn"].Value.ToString();
                quantity.Text = row.Cells["StockQuantity"].Value.ToString();
                price.Text = row.Cells["Price"].Value.ToString();
                genre.Text = row.Cells["Genre"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            id.Clear();
            title.Clear();
            author.Clear();
            isbn.Clear();
            quantity.Clear();
            price.Clear();
            genre.Clear();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
