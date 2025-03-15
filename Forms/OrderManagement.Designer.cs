namespace BookHaven.Forms
{
    partial class OrderManagement
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
            ordersGridView = new DataGridView();
            id = new TextBox();
            label1 = new Label();
            statusComboBox = new ComboBox();
            label2 = new Label();
            updateBtn = new Button();
            search = new TextBox();
            label3 = new Label();
            searchBtn = new Button();
            createdDatePicker = new DateTimePicker();
            label4 = new Label();
            backBtn = new Button();
            clrBtn = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            SuspendLayout();
            // 
            // ordersGridView
            // 
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.Location = new Point(19, 207);
            ordersGridView.Name = "ordersGridView";
            ordersGridView.RowHeadersWidth = 51;
            ordersGridView.Size = new Size(1106, 220);
            ordersGridView.TabIndex = 0;
            ordersGridView.CellClick += cellClick;
            ordersGridView.CellDoubleClick += cellDoubleClick;
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(137, 67);
            id.Name = "id";
            id.Size = new Size(167, 27);
            id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 67);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Order ID";
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "InStoreCompleted", "ToDeliver", "Canceled", "DeliverCompleted" });
            statusComboBox.Location = new Point(137, 110);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(167, 28);
            statusComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 113);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 4;
            label2.Text = "Order Status";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(19, 155);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(109, 37);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // search
            // 
            search.Location = new Point(819, 160);
            search.Name = "search";
            search.Size = new Size(167, 27);
            search.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(750, 160);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Search";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(1016, 155);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(109, 37);
            searchBtn.TabIndex = 8;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // createdDatePicker
            // 
            createdDatePicker.Location = new Point(419, 67);
            createdDatePicker.Name = "createdDatePicker";
            createdDatePicker.Size = new Size(167, 27);
            createdDatePicker.TabIndex = 9;
            createdDatePicker.Value = new DateTime(2025, 3, 13, 18, 7, 16, 0);
            createdDatePicker.ValueChanged += onValueChange;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 67);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 10;
            label4.Text = "Order Date";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(19, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 36;
            backBtn.Text = "< Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.Location = new Point(193, 155);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(111, 37);
            clrBtn.TabIndex = 37;
            clrBtn.Text = "Clear";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(464, 7);
            label5.Name = "label5";
            label5.Size = new Size(225, 32);
            label5.TabIndex = 38;
            label5.Text = "Order Management";
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 450);
            Controls.Add(label5);
            Controls.Add(clrBtn);
            Controls.Add(backBtn);
            Controls.Add(label4);
            Controls.Add(createdDatePicker);
            Controls.Add(searchBtn);
            Controls.Add(label3);
            Controls.Add(search);
            Controls.Add(updateBtn);
            Controls.Add(label2);
            Controls.Add(statusComboBox);
            Controls.Add(label1);
            Controls.Add(id);
            Controls.Add(ordersGridView);
            Name = "OrderManagement";
            Text = "OrderManagement";
            ((System.ComponentModel.ISupportInitialize)ordersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ordersGridView;
        private TextBox id;
        private Label label1;
        private ComboBox statusComboBox;
        private Label label2;
        private Button updateBtn;
        private TextBox search;
        private Label label3;
        private Button searchBtn;
        private DateTimePicker createdDatePicker;
        private Label label4;
        private Button backBtn;
        private Button clrBtn;
        private Label label5;
    }
}