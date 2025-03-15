using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Data;
using BookHaven.Data.repository;

namespace BookHaven.Forms
{
    public partial class OrderDetailView : Form
    {

        private readonly int _orderId;
        //private readonly OrderRepository _orderDetailRepo;
        private readonly OrderDetailRepository _orderDetailRepo;

        public OrderDetailView(int orderId)
        {
            _orderId = orderId;
            _orderDetailRepo = new OrderDetailRepository(new AppDbContext());
            InitializeComponent();
            LoadOrderDetails();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            orderIdLabel.Text = "Order Id : " + Convert.ToString(orderId);
        }

        private void LoadOrderDetails()
        {
            var orderDetails = _orderDetailRepo.GetOrderDetailByOrderId(_orderId);

            if (orderDetails != null)
            {
                orderDetailsGridView.DataSource = orderDetails.Select(od => new
                {
                    od.Id,
                    od.BookId,
                    od.Book.Title,
                    od.Quantity,
                    od.UnitPrice,
                    od.TotalPrice
                }).ToList();
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 0x1;
            const int HTCAPTION = 0x2;

            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
            {
                m.Result = (IntPtr)HTCAPTION; // Allow dragging
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
