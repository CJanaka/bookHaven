namespace BookHaven.Forms
{
    partial class UserManagement
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
            label8 = new Label();
            clrBtn = new Button();
            search = new TextBox();
            searchBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            userGridView = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            statusComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)userGridView).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(373, 9);
            label8.Name = "label8";
            label8.Size = new Size(199, 32);
            label8.TabIndex = 23;
            label8.Text = "User Mnagement";
            label8.Click += label8_Click;
            // 
            // clrBtn
            // 
            clrBtn.Location = new Point(391, 240);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(83, 34);
            clrBtn.TabIndex = 49;
            clrBtn.Text = "Clear";
            clrBtn.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            search.Location = new Point(546, 247);
            search.Name = "search";
            search.Size = new Size(246, 27);
            search.TabIndex = 48;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(820, 243);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(83, 34);
            searchBtn.TabIndex = 47;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(272, 240);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(83, 34);
            deleteBtn.TabIndex = 46;
            deleteBtn.Text = "Remove";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(147, 240);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(83, 34);
            updateBtn.TabIndex = 45;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(22, 240);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(83, 34);
            addBtn.TabIndex = 44;
            addBtn.Text = "+ Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // userGridView
            // 
            userGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGridView.Location = new Point(22, 300);
            userGridView.Name = "userGridView";
            userGridView.RowHeadersWidth = 51;
            userGridView.Size = new Size(881, 193);
            userGridView.TabIndex = 43;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 97);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 51;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 149);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 53;
            label1.Text = "User Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 97);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 55;
            label3.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(488, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 27);
            textBox3.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 149);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 57;
            label4.Text = "User Roles";
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "InStoreCompleted", "ToDeliver", "Canceled", "DeliverCompleted" });
            statusComboBox.Location = new Point(488, 146);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(187, 28);
            statusComboBox.TabIndex = 56;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 516);
            Controls.Add(label4);
            Controls.Add(statusComboBox);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(clrBtn);
            Controls.Add(search);
            Controls.Add(searchBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(userGridView);
            Controls.Add(label8);
            Name = "UserManagement";
            Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)userGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button clrBtn;
        private TextBox search;
        private Button searchBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private DataGridView userGridView;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private ComboBox statusComboBox;
    }
}