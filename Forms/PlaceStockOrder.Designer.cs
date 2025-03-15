
namespace BookHaven.Forms
{
    partial class PlaceStockOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            updateBtn = new Button();
            addBtn = new Button();
            stockOrdersGridView = new DataGridView();
            clrBtn = new Button();
            deleteBtn = new Button();
            orderDetailId = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            stockOrderId = new TextBox();
            label4 = new Label();
            quantity = new TextBox();
            label5 = new Label();
            button1 = new Button();
            price = new TextBox();
            label6 = new Label();
            label7 = new Label();
            total = new TextBox();
            booksView = new DataGridView();
            label8 = new Label();
            search = new TextBox();
            searchBtn = new Button();
            bookId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)stockOrdersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksView).BeginInit();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(625, 504);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(78, 35);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(528, 503);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(81, 35);
            addBtn.TabIndex = 10;
            addBtn.Text = "+Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // stockOrdersGridView
            // 
            stockOrdersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockOrdersGridView.Location = new Point(28, 562);
            stockOrdersGridView.Name = "stockOrdersGridView";
            stockOrdersGridView.RowHeadersWidth = 51;
            stockOrdersGridView.Size = new Size(721, 168);
            stockOrdersGridView.TabIndex = 7;
            stockOrdersGridView.CellClick += cellClick;
            // 
            // clrBtn
            // 
            clrBtn.Location = new Point(819, 505);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(83, 34);
            clrBtn.TabIndex = 44;
            clrBtn.Text = "Clear";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(719, 504);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(83, 34);
            deleteBtn.TabIndex = 43;
            deleteBtn.Text = "Remove";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // orderDetailId
            // 
            orderDetailId.Enabled = false;
            orderDetailId.Location = new Point(403, 396);
            orderDetailId.Name = "orderDetailId";
            orderDetailId.Size = new Size(189, 27);
            orderDetailId.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 396);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 46;
            label1.Text = "Order Detail ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 351);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 48;
            label3.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 354);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 50;
            label2.Text = "Order ID";
            // 
            // stockOrderId
            // 
            stockOrderId.Enabled = false;
            stockOrderId.Location = new Point(403, 354);
            stockOrderId.Name = "stockOrderId";
            stockOrderId.Size = new Size(189, 27);
            stockOrderId.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(624, 396);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 52;
            label4.Text = "Quantity";
            // 
            // quantity
            // 
            quantity.Location = new Point(713, 396);
            quantity.Name = "quantity";
            quantity.Size = new Size(189, 27);
            quantity.TabIndex = 51;
            quantity.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(403, 12);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 53;
            label5.Text = "Order Items";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(892, 12);
            button1.Name = "button1";
            button1.Size = new Size(40, 37);
            button1.TabIndex = 54;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // price
            // 
            price.Enabled = false;
            price.Location = new Point(403, 441);
            price.Name = "price";
            price.Size = new Size(189, 27);
            price.TabIndex = 55;
            price.Text = "0.0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 441);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 56;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(624, 441);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 58;
            label7.Text = "Total Price";
            // 
            // total
            // 
            total.Enabled = false;
            total.Location = new Point(713, 441);
            total.Name = "total";
            total.Size = new Size(189, 27);
            total.TabIndex = 57;
            total.Text = "0.0";
            // 
            // booksView
            // 
            booksView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksView.Location = new Point(181, 143);
            booksView.Name = "booksView";
            booksView.RowHeadersWidth = 51;
            booksView.Size = new Size(721, 168);
            booksView.TabIndex = 59;
            booksView.CellClick += bookCellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(475, 93);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 61;
            label8.Text = "Search Book";
            // 
            // search
            // 
            search.Location = new Point(586, 93);
            search.Name = "search";
            search.Size = new Size(189, 27);
            search.TabIndex = 60;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(819, 93);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(83, 34);
            searchBtn.TabIndex = 62;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += button2_Click;
            // 
            // bookId
            // 
            bookId.Enabled = false;
            bookId.Location = new Point(713, 351);
            bookId.Name = "bookId";
            bookId.Size = new Size(189, 27);
            bookId.TabIndex = 63;
            // 
            // PlaceStockOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 742);
            Controls.Add(bookId);
            Controls.Add(searchBtn);
            Controls.Add(label8);
            Controls.Add(search);
            Controls.Add(booksView);
            Controls.Add(label7);
            Controls.Add(total);
            Controls.Add(label6);
            Controls.Add(price);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(quantity);
            Controls.Add(label2);
            Controls.Add(stockOrderId);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(orderDetailId);
            Controls.Add(clrBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(stockOrdersGridView);
            Name = "PlaceStockOrder";
            Text = "PlaceStockOrder";
            ((System.ComponentModel.ISupportInitialize)stockOrdersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateBtn;
        private Button addBtn;
        private ComboBox statusDropdown;
        private DataGridView stockOrdersGridView;
        private Button clrBtn;
        private Button deleteBtn;
        private TextBox orderDetailId;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox stockOrderId;
        private Label label4;
        private TextBox quantity;
        private Label label5;
        private Button button1;
        private TextBox price;
        private Label label6;
        private Label label7;
        private TextBox total;
        private DataGridView booksView;
        private Label label8;
        private TextBox search;
        private Button searchBtn;
        private TextBox bookId;
    }
}