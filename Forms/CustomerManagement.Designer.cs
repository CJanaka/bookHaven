namespace BookHaven.Forms
{
    partial class CustomerManagement
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
            backBtn = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            fName = new TextBox();
            lName = new TextBox();
            contact = new TextBox();
            address = new TextBox();
            pCode = new TextBox();
            email = new TextBox();
            id = new TextBox();
            clrBtn = new Button();
            search = new TextBox();
            searchBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            customersGridView = new DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)customersGridView).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Location = new Point(34, 21);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 35;
            backBtn.Text = "< Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 122);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 34;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 180);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 33;
            label6.Text = "Postal Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 230);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 32;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 125);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 31;
            label4.Text = "First Name";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 180);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 30;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 74);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 29;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 74);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 28;
            label1.Text = "Contact";
            // 
            // fName
            // 
            fName.Location = new Point(128, 125);
            fName.Name = "fName";
            fName.Size = new Size(246, 27);
            fName.TabIndex = 27;
            // 
            // lName
            // 
            lName.Location = new Point(128, 177);
            lName.Name = "lName";
            lName.Size = new Size(246, 27);
            lName.TabIndex = 26;
            // 
            // contact
            // 
            contact.Location = new Point(522, 71);
            contact.Name = "contact";
            contact.Size = new Size(246, 27);
            contact.TabIndex = 25;
            // 
            // address
            // 
            address.Location = new Point(522, 122);
            address.Name = "address";
            address.Size = new Size(246, 27);
            address.TabIndex = 24;
            // 
            // pCode
            // 
            pCode.Location = new Point(522, 180);
            pCode.Name = "pCode";
            pCode.Size = new Size(246, 27);
            pCode.TabIndex = 23;
            // 
            // email
            // 
            email.Location = new Point(128, 227);
            email.Name = "email";
            email.Size = new Size(246, 27);
            email.TabIndex = 22;
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(128, 71);
            id.Name = "id";
            id.Size = new Size(246, 27);
            id.TabIndex = 21;
            // 
            // clrBtn
            // 
            clrBtn.Location = new Point(403, 296);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(83, 34);
            clrBtn.TabIndex = 42;
            clrBtn.Text = "Clear";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // search
            // 
            search.Location = new Point(558, 303);
            search.Name = "search";
            search.Size = new Size(246, 27);
            search.TabIndex = 41;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(832, 299);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(83, 34);
            searchBtn.TabIndex = 40;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(284, 296);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(83, 34);
            deleteBtn.TabIndex = 39;
            deleteBtn.Text = "Remove";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(159, 296);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(83, 34);
            updateBtn.TabIndex = 38;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(34, 296);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(83, 34);
            addBtn.TabIndex = 37;
            addBtn.Text = "+ Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // customersGridView
            // 
            customersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersGridView.Location = new Point(34, 356);
            customersGridView.Name = "customersGridView";
            customersGridView.RowHeadersWidth = 51;
            customersGridView.Size = new Size(881, 193);
            customersGridView.TabIndex = 36;
            customersGridView.CellClick += cellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(365, 9);
            label8.Name = "label8";
            label8.Size = new Size(255, 32);
            label8.TabIndex = 43;
            label8.Text = "Customer Mnagement";
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 561);
            Controls.Add(label8);
            Controls.Add(clrBtn);
            Controls.Add(search);
            Controls.Add(searchBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(customersGridView);
            Controls.Add(backBtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fName);
            Controls.Add(lName);
            Controls.Add(contact);
            Controls.Add(address);
            Controls.Add(pCode);
            Controls.Add(email);
            Controls.Add(id);
            Name = "CustomerManagement";
            Text = "CustomerManagement";
            ((System.ComponentModel.ISupportInitialize)customersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox fName;
        private TextBox lName;
        private TextBox contact;
        private TextBox address;
        private TextBox pCode;
        private TextBox email;
        private TextBox id;
        private Button clrBtn;
        private TextBox search;
        private Button searchBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private DataGridView customersGridView;
        private Label label8;
    }
}