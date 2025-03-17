namespace BookHaven.Forms
{
    partial class AdminDashboard
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
            bookMngBtn = new Button();
            cusManageBtn = new Button();
            orderManageBtn = new Button();
            supplierBtn = new Button();
            stockOrderBtn = new Button();
            posBtn = new Button();
            reportBtn = new Button();
            userManageBtn = new Button();
            logOutBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bookMngBtn
            // 
            bookMngBtn.Location = new Point(152, 117);
            bookMngBtn.Name = "bookMngBtn";
            bookMngBtn.Size = new Size(126, 65);
            bookMngBtn.TabIndex = 0;
            bookMngBtn.Text = "Book Management";
            bookMngBtn.UseVisualStyleBackColor = true;
            bookMngBtn.Click += bookMngBtn_Click;
            // 
            // cusManageBtn
            // 
            cusManageBtn.Location = new Point(345, 117);
            cusManageBtn.Name = "cusManageBtn";
            cusManageBtn.Size = new Size(126, 65);
            cusManageBtn.TabIndex = 1;
            cusManageBtn.Text = "Customer Management";
            cusManageBtn.UseVisualStyleBackColor = true;
            cusManageBtn.Click += button1_Click;
            // 
            // orderManageBtn
            // 
            orderManageBtn.Location = new Point(532, 117);
            orderManageBtn.Name = "orderManageBtn";
            orderManageBtn.Size = new Size(126, 65);
            orderManageBtn.TabIndex = 2;
            orderManageBtn.Text = "Order Management";
            orderManageBtn.UseVisualStyleBackColor = true;
            orderManageBtn.Click += button2_Click;
            // 
            // supplierBtn
            // 
            supplierBtn.Location = new Point(152, 239);
            supplierBtn.Name = "supplierBtn";
            supplierBtn.Size = new Size(126, 65);
            supplierBtn.TabIndex = 3;
            supplierBtn.Text = "Supplier Management";
            supplierBtn.UseVisualStyleBackColor = true;
            supplierBtn.Click += supplierBtn_Click;
            // 
            // stockOrderBtn
            // 
            stockOrderBtn.Location = new Point(345, 239);
            stockOrderBtn.Name = "stockOrderBtn";
            stockOrderBtn.Size = new Size(126, 65);
            stockOrderBtn.TabIndex = 4;
            stockOrderBtn.Text = "Stock Order Management";
            stockOrderBtn.UseVisualStyleBackColor = true;
            stockOrderBtn.Click += button3_Click;
            // 
            // posBtn
            // 
            posBtn.Location = new Point(532, 239);
            posBtn.Name = "posBtn";
            posBtn.Size = new Size(126, 65);
            posBtn.TabIndex = 5;
            posBtn.Text = "Customer POS";
            posBtn.UseVisualStyleBackColor = true;
            posBtn.Click += button4_Click;
            // 
            // reportBtn
            // 
            reportBtn.Location = new Point(152, 353);
            reportBtn.Name = "reportBtn";
            reportBtn.Size = new Size(126, 65);
            reportBtn.TabIndex = 6;
            reportBtn.Text = "Sales Report";
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += button5_Click;
            // 
            // userManageBtn
            // 
            userManageBtn.Location = new Point(345, 353);
            userManageBtn.Name = "userManageBtn";
            userManageBtn.Size = new Size(126, 65);
            userManageBtn.TabIndex = 7;
            userManageBtn.Text = "System User Management";
            userManageBtn.UseVisualStyleBackColor = true;
            userManageBtn.Click += button6_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.Location = new Point(712, 393);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(76, 45);
            logOutBtn.TabIndex = 8;
            logOutBtn.Text = "Log Out";
            logOutBtn.UseVisualStyleBackColor = true;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(207, 26);
            label1.Name = "label1";
            label1.Size = new Size(404, 37);
            label1.TabIndex = 9;
            label1.Text = "Book Haven - System Dashboard";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(logOutBtn);
            Controls.Add(userManageBtn);
            Controls.Add(reportBtn);
            Controls.Add(posBtn);
            Controls.Add(stockOrderBtn);
            Controls.Add(supplierBtn);
            Controls.Add(orderManageBtn);
            Controls.Add(cusManageBtn);
            Controls.Add(bookMngBtn);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bookMngBtn;
        private Button cusManageBtn;
        private Button orderManageBtn;
        private Button supplierBtn;
        private Button stockOrderBtn;
        private Button posBtn;
        private Button reportBtn;
        private Button userManageBtn;
        private Button logOutBtn;
        private Label label1;
    }
}