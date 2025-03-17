namespace BookHaven.Forms
{
    partial class CustomerPos
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
            cusGridView = new DataGridView();
            search = new TextBox();
            label1 = new Label();
            searchBtn = new Button();
            addCusBtn = new Button();
            total = new TextBox();
            label3 = new Label();
            cusName = new TextBox();
            contact = new TextBox();
            cusId = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            email = new TextBox();
            label7 = new Label();
            gross = new TextBox();
            label8 = new Label();
            discount = new TextBox();
            label9 = new Label();
            addViewBtn = new Button();
            button2 = new Button();
            label2 = new Label();
            backBtn = new Button();
            button1 = new Button();
            label10 = new Label();
            statusBox = new ComboBox();
            label11 = new Label();
            orderId = new TextBox();
            label12 = new Label();
            clearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)cusGridView).BeginInit();
            SuspendLayout();
            // 
            // cusGridView
            // 
            cusGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cusGridView.Location = new Point(382, 175);
            cusGridView.Name = "cusGridView";
            cusGridView.RowHeadersWidth = 51;
            cusGridView.Size = new Size(405, 108);
            cusGridView.TabIndex = 0;
            cusGridView.CellClick += cellClick;
            // 
            // search
            // 
            search.Location = new Point(517, 89);
            search.Name = "search";
            search.Size = new Size(165, 27);
            search.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 89);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Find Customer";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(705, 89);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(82, 27);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // addCusBtn
            // 
            addCusBtn.Location = new Point(650, 131);
            addCusBtn.Name = "addCusBtn";
            addCusBtn.Size = new Size(137, 27);
            addCusBtn.TabIndex = 6;
            addCusBtn.Text = "Add Customer >";
            addCusBtn.UseVisualStyleBackColor = true;
            addCusBtn.Click += addCusBtn_Click;
            // 
            // total
            // 
            total.Location = new Point(579, 496);
            total.Name = "total";
            total.Size = new Size(208, 27);
            total.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 496);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 8;
            label3.Text = "Total";
            label3.Click += label3_Click;
            // 
            // cusName
            // 
            cusName.Enabled = false;
            cusName.Location = new Point(133, 317);
            cusName.Name = "cusName";
            cusName.Size = new Size(194, 27);
            cusName.TabIndex = 9;
            // 
            // contact
            // 
            contact.Enabled = false;
            contact.Location = new Point(564, 363);
            contact.Name = "contact";
            contact.Size = new Size(223, 27);
            contact.TabIndex = 10;
            // 
            // cusId
            // 
            cusId.Enabled = false;
            cusId.Location = new Point(133, 363);
            cusId.Name = "cusId";
            cusId.Size = new Size(194, 27);
            cusId.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 363);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 12;
            label4.Text = "Customer ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 316);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 13;
            label5.Text = "Customer Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 367);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 14;
            label6.Text = "Contact";
            // 
            // email
            // 
            email.Enabled = false;
            email.Location = new Point(564, 313);
            email.Name = "email";
            email.Size = new Size(223, 27);
            email.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 313);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 16;
            label7.Text = "Email";
            // 
            // gross
            // 
            gross.Location = new Point(579, 655);
            gross.Name = "gross";
            gross.Size = new Size(208, 27);
            gross.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(471, 655);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 18;
            label8.Text = "Gross Amount";
            // 
            // discount
            // 
            discount.Location = new Point(579, 538);
            discount.Name = "discount";
            discount.Size = new Size(208, 27);
            discount.TabIndex = 19;
            discount.TextChanged += discount_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(471, 538);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 20;
            label9.Text = "Discount %";
            // 
            // addViewBtn
            // 
            addViewBtn.Location = new Point(86, 506);
            addViewBtn.Name = "addViewBtn";
            addViewBtn.Size = new Size(241, 71);
            addViewBtn.TabIndex = 21;
            addViewBtn.Text = "Add / View Order Items";
            addViewBtn.UseVisualStyleBackColor = true;
            addViewBtn.Click += addViewBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(700, 688);
            button2.Name = "button2";
            button2.Size = new Size(87, 34);
            button2.TabIndex = 22;
            button2.Text = "Print Bill";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(23, 19);
            label2.Name = "label2";
            label2.Size = new Size(321, 32);
            label2.TabIndex = 23;
            label2.Text = "Customer POS - Book Haven";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(23, 80);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 54;
            backBtn.Text = "< Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(700, 599);
            button1.Name = "button1";
            button1.Size = new Size(87, 34);
            button1.TabIndex = 55;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 412);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 57;
            label10.Text = "Order Status";
            // 
            // statusBox
            // 
            statusBox.FormattingEnabled = true;
            statusBox.Items.AddRange(new object[] { "InStoreCompleted", "ToDeliver", "Canceled", "DeliverCompleted" });
            statusBox.Location = new Point(133, 409);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(194, 28);
            statusBox.TabIndex = 56;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7F);
            label11.ForeColor = Color.Firebrick;
            label11.Location = new Point(575, 571);
            label11.Name = "label11";
            label11.Size = new Size(216, 15);
            label11.TabIndex = 58;
            label11.Text = "*flat discount values are only applicable";
            label11.Click += label11_Click;
            // 
            // orderId
            // 
            orderId.Enabled = false;
            orderId.Location = new Point(579, 450);
            orderId.Name = "orderId";
            orderId.Size = new Size(208, 27);
            orderId.TabIndex = 59;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(471, 453);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 60;
            label12.Text = "Order ID";
            label12.Click += label12_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(579, 599);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(87, 34);
            clearBtn.TabIndex = 61;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // CustomerPos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 750);
            Controls.Add(clearBtn);
            Controls.Add(label12);
            Controls.Add(orderId);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(statusBox);
            Controls.Add(button1);
            Controls.Add(backBtn);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(addViewBtn);
            Controls.Add(label9);
            Controls.Add(discount);
            Controls.Add(label8);
            Controls.Add(gross);
            Controls.Add(label7);
            Controls.Add(email);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cusId);
            Controls.Add(contact);
            Controls.Add(cusName);
            Controls.Add(label3);
            Controls.Add(total);
            Controls.Add(addCusBtn);
            Controls.Add(searchBtn);
            Controls.Add(label1);
            Controls.Add(search);
            Controls.Add(cusGridView);
            Name = "CustomerPos";
            Text = "CustomerPos";
            ((System.ComponentModel.ISupportInitialize)cusGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cusGridView;
        private TextBox search;
        private Label label1;
        private Button searchBtn;
        private Button addCusBtn;
        private TextBox total;
        private Label label3;
        private TextBox cusName;
        private TextBox contact;
        private TextBox cusId;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox email;
        private Label label7;
        private TextBox gross;
        private Label label8;
        private TextBox discount;
        private Label label9;
        private Button addViewBtn;
        private Button button2;
        private Label label2;
        private Button backBtn;
        private Button button1;
        private Label label10;
        private ComboBox statusBox;
        private Label label11;
        private TextBox orderId;
        private Label label12;
        private Button clearBtn;
    }
}