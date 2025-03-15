using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookHaven.Business.services;
using BookHaven.Data.entity;
using BookHaven.Data.repository;
using BookHaven.Data;
using System.Diagnostics;

namespace BookHaven.Forms
{
    public partial class PlaceStockOrder : Form
    {
        private readonly StockOrderService _stockOrderService;
        private readonly OrderService _orderService;
        private readonly BookService _bookService;
        private readonly SupplierService _supplierService;
        private readonly OrderDetailRepository _orderDetailRepository;
        private readonly string _uniqueId;
        private Form _parentForm;
        private int _orderId;
        private bool _isCustomerOrder;

        public PlaceStockOrder(StockOrderService stockOrderService, BookService bookService, OrderService orderService,
                               string uniqueId, Form parentForm, bool isCustomerOrder)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            _stockOrderService = stockOrderService;
            _bookService = bookService;
            _orderService = orderService;
            _supplierService = new SupplierService(new SupplierRepository(new AppDbContext()));
            _orderDetailRepository = new OrderDetailRepository(new AppDbContext());

            _uniqueId = uniqueId;
            _parentForm = parentForm;
            _isCustomerOrder = isCustomerOrder;

            _orderId = GetOrderRecord();
            LoadBooks();
            LoadOrderItems();
        }

        private int GetOrderRecord()
        {
            if (_isCustomerOrder)
            {
                var order = _orderService.GetByUid(_uniqueId);
                Debug.WriteLine("_isCustomerOrder " + _uniqueId);
                return order?.Id ?? 0;
            }
            else
            {
                var order = _stockOrderService.GetByUid(_uniqueId);
                Debug.WriteLine("!_isCustomerOrder " + _uniqueId);
                return order?.Id ?? 0;
            }
        }

        private void LoadOrderItems()
        {
            List<OrderDetail> orderDetails = _isCustomerOrder
                ? _orderService.GetOrderDetailByOrderId(_orderId)
                : _orderService.GetOrderDetailByStockOrderId(_orderId);
            Debug.WriteLine("_orderId " + _orderId);

            stockOrdersGridView.DataSource = orderDetails.Select(o => new
            {
                o.Id,
                o.StockOrderId,
                o.OrderId,
                o.TotalPrice,
                o.Quantity,
                o.BookId,
                o.Book.Title,
                o.Book.Genre,
                o.Book.Price,
                o.Book.Isbn
            }).ToList();
        }

        private void LoadBooks()
        {
            var books = _bookService.GetAllBooks();
            booksView.DataSource = books.Select(b => new
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            int bokId = Convert.ToInt32(bookId.Text);
            var book = _bookService.GetBookById(bokId);

            int selectedQts = Convert.ToInt32(quantity.Text);
            int avilableQtz = book.StockQuantity;

            if (avilableQtz < selectedQts)
            {
                MessageBox.Show("Stock not enough!");
                return;
            }

            var orderItem = new OrderDetail

            {
                BookId = Convert.ToInt32(bookId.Text),
                Quantity = Convert.ToInt32(quantity.Text)
            };

            if (_isCustomerOrder)
            {
                orderItem.OrderId = _orderId;
                orderItem.TotalPrice = Convert.ToDecimal(price.Text) * orderItem.Quantity;
            }
            else
            {
                orderItem.StockOrderId = _orderId;
            }

            //check inventory an update
            checkAndModifyInventory(selectedQts, avilableQtz, book, true);

            _orderService.addOrderDetail(orderItem);
            MessageBox.Show("Order item added successfully!");

            LoadOrderItems();
            RefreshParentForm();
            clearFields();
        }

        void checkAndModifyInventory(int selectedQtz, int savilableQtz, Book book, bool isAdd) {

            int restStck = savilableQtz - selectedQtz;
            book.StockQuantity = restStck;
            _bookService.AddBook(book);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(bookId.Text))
            { 
                MessageBox.Show("please select arecord to update!");
                return;
            }

            int bokId = Convert.ToInt32(bookId.Text);
            var book = _bookService.GetBookById(bokId);

            int selectedQts = Convert.ToInt32(quantity.Text);
            int avilableQtz = book.StockQuantity;

            if (avilableQtz < selectedQts)
            {
                MessageBox.Show("Stock not enough!");
                return;
            }

            if (!string.IsNullOrWhiteSpace(orderDetailId.Text))
            {
                int ordDetailId = int.Parse(orderDetailId.Text);
                var orderDetail = _orderService.GetOrderDetailByOrderDetailId(ordDetailId);

                int currentQtzOfOrder = orderDetail.Quantity;
                int selectedQtz = Convert.ToInt32(quantity.Text);
                orderDetail.BookId = Convert.ToInt32(bookId.Text);

                if (selectedQtz > currentQtzOfOrder) {
                    currentQtzOfOrder -= selectedQtz;
                    checkAndModifyInventory(currentQtzOfOrder, avilableQtz, book, true);
                }

                orderDetail.Quantity = currentQtzOfOrder;
                _orderDetailRepository.Update(orderDetail);
                MessageBox.Show("Order updated successfully.");

                //RefreshParentForm();
                LoadOrderItems();
                clearFields();
            }
            else
            {
                MessageBox.Show("Please select a record.");
            }
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = stockOrdersGridView.Rows[e.RowIndex];

                if (_isCustomerOrder)
                {
                    stockOrderId.Text = row.Cells["OrderId"].Value.ToString();

                }
                else { 
                    stockOrderId.Text = row.Cells["StockOrderId"].Value.ToString();
                }

                bookId.Text = row.Cells["BookId"].Value.ToString();
                total.Text = row.Cells["TotalPrice"].Value.ToString();
                orderDetailId.Text = row.Cells["Id"].Value.ToString();
                quantity.Text = row.Cells["Quantity"].Value.ToString();
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RefreshParentForm()
        {
            if (_parentForm is StockOrderManagement stockOrderManagement)
            {
                stockOrderManagement.LoadStockOrders();
            }
            else if (_parentForm is CustomerPos customerPos)
            {
                customerPos.LoadStockOrders(_uniqueId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string keyword = search.Text;
            var books = _bookService.SearchBooks(keyword);
            booksView.DataSource = books.Select(b => new
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

        private void bookCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clearFields();
                DataGridViewRow row = booksView.Rows[e.RowIndex];

                // Load data from the selected row into the respective fields
                bookId.Text = row.Cells["Id"].Value.ToString();
                //quantity.Text = row.Cells["StockQuantity"].Value.ToString();
                price.Text = row.Cells["Price"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close button
            RefreshParentForm();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        void clearFields() {
            stockOrderId.Clear();
            orderDetailId.Clear();
            total.Clear();
            price.Clear();
            bookId.Clear();
            quantity.Clear();
        }
    }
}
