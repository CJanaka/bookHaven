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
using BookHaven.Data.dto;
using BookHaven.Data.entity;

namespace BookHaven.Forms
{
    public partial class SalesReport : Form
    {
        private readonly OrderService _orderService;
        public SalesReport(OrderService orderService)
        {
            _orderService = orderService;
            InitializeComponent();
            SetupControls();
        }

        private void SetupControls()
        {
            // Setup the filter combobox
            filterBox.Items.Add("Daily");
            filterBox.Items.Add("Weekly");
            filterBox.Items.Add("Monthly");
            filterBox.SelectedIndex = 2; // Default to Monthly

            // Initialize the grid view
            SetupDataGridView();

            // Load data based on default filter (Monthly)
            LoadSalesData();
        }

        private void SetupDataGridView()
        {
            // Set up columns for the sales grid view
            salesGridView.AutoGenerateColumns = false;
            salesGridView.Columns.Clear();

            // Add columns based on monthly view (default)
            salesGridView.Columns.Add("Period", "Period");
            salesGridView.Columns.Add("TotalOrders", "Total Orders");
            salesGridView.Columns.Add("GrossAmount", "Gross Amount ($)");
            salesGridView.Columns.Add("Discounts", "Discounts ($)");
            salesGridView.Columns.Add("NetAmount", "Net Amount ($)");
            salesGridView.Columns.Add("TopSellingItem", "Top Selling Item");

            // Format numeric columns
            salesGridView.Columns["GrossAmount"].DefaultCellStyle.Format = "N2";
            salesGridView.Columns["Discounts"].DefaultCellStyle.Format = "N2";
            salesGridView.Columns["NetAmount"].DefaultCellStyle.Format = "N2";

            // Setup row formatting
            salesGridView.CellFormatting += SalesGridView_CellFormatting;

            // Other grid settings
            salesGridView.AllowUserToAddRows = false;
            salesGridView.AllowUserToDeleteRows = false;
            salesGridView.ReadOnly = true;
            salesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadSalesData()
        {
            // Clear existing data
            salesGridView.Rows.Clear();

            // Get selected filter type
            string filterType = filterBox.SelectedItem.ToString();

            // Set appropriate date range based on the selected filter
            DateTime startDate, endDate;

            switch (filterType)
            {
                case "Daily":
                    // Show sales for today
                    startDate = DateTime.Today;
                    endDate = DateTime.Today.AddDays(1).AddSeconds(-1);
                    break;

                case "Weekly":
                    // Show sales for this week (Sunday to Saturday)
                    int daysToSubtract = (int)DateTime.Today.DayOfWeek;
                    startDate = DateTime.Today.AddDays(-daysToSubtract); // Sunday
                    endDate = startDate.AddDays(7).AddSeconds(-1); // Saturday
                    break;

                case "Monthly":
                default:
                    // Show sales for this month
                    startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    endDate = startDate.AddMonths(1).AddSeconds(-1);
                    break;
            }

            // Get orders from service
            List<Order> orders = _orderService.GetOrdersByDateRange(startDate, endDate);

            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("No sales data found for the selected period.", "No Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //salesGridView.DataSource = orders.Select(o => new
            //{
            //    o.Id,
            //    o.CustomerId,
            //    o.CreatedDate,
            //    o.ModifiedDate,
            //    o.Status,
            //    o.UserId,
            //    o.Discount,
            //    o.TotalAmount,
            //    o.NetAmount
            //}).ToList();

            //// Process data based on filter type
            var salesSummary = new List<SalesSummaryItem>();

            switch (filterType)
            {
                case "Daily":
                    salesSummary = GetDailySalesSummary(orders);
                    break;

                case "Weekly":
                    salesSummary = GetWeeklySalesSummary(orders);
                    break;

                case "Monthly":
                default:
                    salesSummary = GetMonthlySalesSummary(orders);
                    break;
            }

            // Find the item with the highest net amount to highlight
            decimal maxNetAmount = salesSummary.Count > 0 ? salesSummary.Max(s => s.NetAmount) : 0;

            // Add rows to grid
            foreach (var item in salesSummary)
            {
                int rowIndex = salesGridView.Rows.Add(
                    item.Period,
                    item.TotalOrders,
                    item.GrossAmount,
                    item.Discounts,
                    item.NetAmount,
                    item.TopSellingItem
                );

                // Tag the row with the summary item for highlighting
                salesGridView.Rows[rowIndex].Tag = item.NetAmount == maxNetAmount;
            }
        }

        private List<SalesSummaryItem> GetDailySalesSummary(List<Order> orders)
        {
            return orders
                .GroupBy(o => o.CreatedDate.Date)
                .Select(g => new SalesSummaryItem
                {
                    Period = g.Key.ToString("MM/dd/yyyy"),
                    TotalOrders = g.Count(),
                    GrossAmount = g.Sum(o => o.TotalAmount),
                    Discounts = g.Sum(o => o.Discount),
                    NetAmount = g.Sum(o => o.NetAmount),
                    TopSellingItem = GetTopSellingItem(g.SelectMany(o => o.OrderDetails).ToList())
                })
                .OrderBy(s => DateTime.Parse(s.Period))
                .ToList();
        }

        private List<SalesSummaryItem> GetWeeklySalesSummary(List<Order> orders)
        {
            return orders
                .GroupBy(o =>
                {
                    // Get week number and year
                    var cal = System.Globalization.CultureInfo.CurrentCulture.Calendar;
                    var weekNum = cal.GetWeekOfYear(o.CreatedDate,
                        System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                    return new { Year = o.CreatedDate.Year, Week = weekNum };
                })
                .Select(g =>
                {
                    // Get first day of this week for display
                    var firstOrder = g.OrderBy(o => o.CreatedDate).First();
                    var dayOfWeek = (int)firstOrder.CreatedDate.DayOfWeek;
                    var startOfWeek = firstOrder.CreatedDate.AddDays(-dayOfWeek);
                    var endOfWeek = startOfWeek.AddDays(6);

                    return new SalesSummaryItem
                    {
                        Period = $"{startOfWeek:MM/dd/yyyy} - {endOfWeek:MM/dd/yyyy}",
                        TotalOrders = g.Count(),
                        GrossAmount = g.Sum(o => o.TotalAmount),
                        Discounts = g.Sum(o => o.Discount),
                        NetAmount = g.Sum(o => o.NetAmount),
                        TopSellingItem = GetTopSellingItem(g.SelectMany(o => o.OrderDetails).ToList())
                    };
                })
                .OrderBy(s => s.Period)
                .ToList();
        }

        private List<SalesSummaryItem> GetMonthlySalesSummary(List<Order> orders)
        {
            return orders
                .GroupBy(o => new { o.CreatedDate.Year, o.CreatedDate.Month })
                .Select(g => new SalesSummaryItem
                {
                    Period = new DateTime(g.Key.Year, g.Key.Month, 1).ToString("MMMM yyyy"),
                    TotalOrders = g.Count(),
                    GrossAmount = g.Sum(o => o.TotalAmount),
                    Discounts = g.Sum(o => o.Discount),
                    NetAmount = g.Sum(o => o.NetAmount),
                    TopSellingItem = GetTopSellingItem(g.SelectMany(o => o.OrderDetails).ToList())
                })
                .OrderBy(s => DateTime.ParseExact(s.Period, "MMMM yyyy", null))
                .ToList();
        }

        private string GetTopSellingItem(List<OrderDetail> orderDetails)
        {
            if (orderDetails == null || orderDetails.Count == 0)
                return "N/A";

            return orderDetails
                .GroupBy(od => od.Book.Title)
                .OrderByDescending(g => g.Sum(od => od.Quantity))
                .First()
                .Key;
        }

        private void SalesGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if this row is tagged for highlighting (top selling)
            if (salesGridView.Rows[e.RowIndex].Tag != null && (bool)salesGridView.Rows[e.RowIndex].Tag)
            {
                // Highlight the row with a light green background
                e.CellStyle.BackColor = Color.FromArgb(200, 255, 200);
                e.CellStyle.Font = new Font(salesGridView.Font, FontStyle.Bold);
            }
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadSalesData();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var dashboard = new AdminDashboard();
            Common.Common.goBack(this, dashboard);
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            //back button click

            var dashboard = new AdminDashboard();
            Common.Common.goBack(this, dashboard);
        }
    }
}
