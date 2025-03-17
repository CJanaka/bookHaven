using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using BookHaven.Data.entity;
using System.Diagnostics;

namespace BookHaven.Common
{
    public static class ReceiptGenerator
    {
        public static void GenerateReceipt(Order order, List<OrderDetail> orderDetail)
        {
            try { 
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Order_{order.Id}.pdf");
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            doc.Add(new Paragraph("Book Heaven - Order Receipt"));
            doc.Add(new Paragraph($"Order ID: {order.Id}"));
            doc.Add(new Paragraph($"Date: {order.CreatedDate:MM/dd/yyyy}"));
            doc.Add(new Paragraph("--------------------------------------------------"));

            PdfPTable table = new PdfPTable(4);
            table.AddCell("Book");
            table.AddCell("Price");
            table.AddCell("Quantity");
            table.AddCell("Total");

            if (orderDetail == null || !orderDetail.Any())
            {
                doc.Add(new Paragraph("No items found in this order."));
                doc.Close();

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
                return;
            }

            foreach (var item in orderDetail)
            {
                if (item.Book != null)
                {
                    table.AddCell(item.Book.Title);
                    table.AddCell(item.Book.Price.ToString("F2"));
                    table.AddCell(item.Quantity.ToString());
                    table.AddCell((item.Book.Price * item.Quantity).ToString("F2"));
                }
            }

            doc.Add(table);
            doc.Add(new Paragraph("--------------------------------------------------"));
            doc.Add(new Paragraph($"Total: {order.TotalAmount:C2}"));
            doc.Close();

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(filePath) { UseShellExecute = true });
            MessageBox.Show("bill generated!");
            }
            catch (Exception e) {
                MessageBox.Show("Bill print failiure!: "+e.Message);
            }
        }

    }
}
