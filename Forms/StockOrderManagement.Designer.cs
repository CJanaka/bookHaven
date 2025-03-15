namespace BookHaven.Forms
{
    partial class StockOrderManagement
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
            stockOrdersGridView = new DataGridView();
            stockOrderId = new TextBox();
            label1 = new Label();
            statusDropdown = new ComboBox();
            label2 = new Label();
            addBtn = new Button();
            updateBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            supplierComboBox = new ComboBox();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)stockOrdersGridView).BeginInit();
            SuspendLayout();
            // 
            // stockOrdersGridView
            // 
            stockOrdersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockOrdersGridView.Location = new Point(48, 244);
            stockOrdersGridView.Name = "stockOrdersGridView";
            stockOrdersGridView.RowHeadersWidth = 51;
            stockOrdersGridView.Size = new Size(721, 168);
            stockOrdersGridView.TabIndex = 0;
            stockOrdersGridView.CellClick += cellClick;
            stockOrdersGridView.CellDoubleClick += cellDoubleClick;
            // 
            // stockOrderId
            // 
            stockOrderId.Enabled = false;
            stockOrderId.Location = new Point(178, 81);
            stockOrderId.Name = "stockOrderId";
            stockOrderId.Size = new Size(189, 27);
            stockOrderId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 81);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 2;
            label1.Text = "Stock Order ID";
            // 
            // statusDropdown
            // 
            statusDropdown.FormattingEnabled = true;
            statusDropdown.Items.AddRange(new object[] { "STOCK_TO_RECEIVE", "STOCK_RECEIVED", "CANCELED" });
            statusDropdown.Location = new Point(178, 130);
            statusDropdown.Name = "statusDropdown";
            statusDropdown.Size = new Size(189, 28);
            statusDropdown.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 130);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 4;
            label2.Text = "Order Status";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(429, 177);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(146, 35);
            addBtn.TabIndex = 5;
            addBtn.Text = "Place Stock Order";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(623, 177);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(146, 35);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(328, 9);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 7;
            label3.Text = "Stock Orders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 177);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 52;
            label4.Text = "Suppliers";
            // 
            // supplierComboBox
            // 
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(178, 177);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(189, 28);
            supplierComboBox.TabIndex = 51;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(49, 14);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 53;
            backBtn.Text = "< Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // StockOrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backBtn);
            Controls.Add(label4);
            Controls.Add(supplierComboBox);
            Controls.Add(label3);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(label2);
            Controls.Add(statusDropdown);
            Controls.Add(label1);
            Controls.Add(stockOrderId);
            Controls.Add(stockOrdersGridView);
            Name = "StockOrderManagement";
            Text = "StockOrderManagement";
            ((System.ComponentModel.ISupportInitialize)stockOrdersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView stockOrdersGridView;
        private TextBox stockOrderId;
        private Label label1;
        private ComboBox statusDropdown;
        private Label label2;
        private Button addBtn;
        private Button updateBtn;
        private Label label3;
        private Label label4;
        private ComboBox supplierComboBox;
        private Button backBtn;
    }
}