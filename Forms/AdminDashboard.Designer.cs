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
            button1 = new Button();
            button2 = new Button();
            supplierBtn = new Button();
            button3 = new Button();
            button4 = new Button();
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
            // button1
            // 
            button1.Location = new Point(345, 117);
            button1.Name = "button1";
            button1.Size = new Size(126, 65);
            button1.TabIndex = 1;
            button1.Text = "Customer Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(532, 117);
            button2.Name = "button2";
            button2.Size = new Size(126, 65);
            button2.TabIndex = 2;
            button2.Text = "Order Management";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            // button3
            // 
            button3.Location = new Point(345, 239);
            button3.Name = "button3";
            button3.Size = new Size(126, 65);
            button3.TabIndex = 4;
            button3.Text = "Stock Order Management";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(532, 239);
            button4.Name = "button4";
            button4.Size = new Size(126, 65);
            button4.TabIndex = 5;
            button4.Text = "Customer POS";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(supplierBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bookMngBtn);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bookMngBtn;
        private Button button1;
        private Button button2;
        private Button supplierBtn;
        private Button button3;
        private Button button4;
        private Button reportBtn;
        private Button userManageBtn;
        private Button logOutBtn;
        private Label label1;
    }
}