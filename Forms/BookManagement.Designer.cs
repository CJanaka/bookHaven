namespace BookHaven.Forms
{
    partial class BookManagement
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
            booksGridView = new DataGridView();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            searchBtn = new Button();
            id = new TextBox();
            genre = new TextBox();
            quantity = new TextBox();
            price = new TextBox();
            isbn = new TextBox();
            author = new TextBox();
            title = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            search = new TextBox();
            backBtn = new Button();
            clrBtn = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)booksGridView).BeginInit();
            SuspendLayout();
            // 
            // booksGridView
            // 
            booksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksGridView.Location = new Point(28, 345);
            booksGridView.Name = "booksGridView";
            booksGridView.RowHeadersWidth = 51;
            booksGridView.Size = new Size(881, 213);
            booksGridView.TabIndex = 0;
            booksGridView.CellClick += cellClick;
            booksGridView.CellContentClick += booksGridView_CellContentClick;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(28, 285);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(83, 34);
            addBtn.TabIndex = 1;
            addBtn.Text = "+ Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(153, 285);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(83, 34);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(278, 285);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(83, 34);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Remove";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(826, 288);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(83, 34);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(85, 81);
            id.Name = "id";
            id.Size = new Size(246, 27);
            id.TabIndex = 5;
            // 
            // genre
            // 
            genre.Location = new Point(85, 237);
            genre.Name = "genre";
            genre.Size = new Size(246, 27);
            genre.TabIndex = 6;
            // 
            // quantity
            // 
            quantity.Location = new Point(416, 190);
            quantity.Name = "quantity";
            quantity.Size = new Size(246, 27);
            quantity.TabIndex = 7;
            // 
            // price
            // 
            price.Location = new Point(416, 132);
            price.Name = "price";
            price.Size = new Size(246, 27);
            price.TabIndex = 8;
            // 
            // isbn
            // 
            isbn.Location = new Point(416, 81);
            isbn.Name = "isbn";
            isbn.Size = new Size(246, 27);
            isbn.TabIndex = 9;
            // 
            // author
            // 
            author.Location = new Point(85, 187);
            author.Name = "author";
            author.Size = new Size(246, 27);
            author.TabIndex = 10;
            // 
            // title
            // 
            title.Location = new Point(85, 132);
            title.Name = "title";
            title.Size = new Size(246, 27);
            title.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 84);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 12;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 84);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 13;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 190);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 14;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 135);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 15;
            label4.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 240);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 16;
            label5.Text = "Genre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 190);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 17;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 132);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 18;
            label7.Text = "Price";
            // 
            // search
            // 
            search.Location = new Point(552, 292);
            search.Name = "search";
            search.Size = new Size(246, 27);
            search.TabIndex = 19;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(29, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 20;
            backBtn.Text = "< Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += button1_Click;
            // 
            // clrBtn
            // 
            clrBtn.Location = new Point(397, 285);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(83, 34);
            clrBtn.TabIndex = 21;
            clrBtn.Text = "Clear";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(345, 12);
            label8.Name = "label8";
            label8.Size = new Size(206, 32);
            label8.TabIndex = 22;
            label8.Text = "Book Mnagement";
            // 
            // BookManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 570);
            Controls.Add(label8);
            Controls.Add(clrBtn);
            Controls.Add(backBtn);
            Controls.Add(search);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(title);
            Controls.Add(author);
            Controls.Add(isbn);
            Controls.Add(price);
            Controls.Add(quantity);
            Controls.Add(genre);
            Controls.Add(id);
            Controls.Add(searchBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(booksGridView);
            Name = "BookManagement";
            Text = "BookManagement";
            ((System.ComponentModel.ISupportInitialize)booksGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView booksGridView;
        private Button addBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button searchBtn;
        private TextBox id;
        private TextBox genre;
        private TextBox quantity;
        private TextBox price;
        private TextBox isbn;
        private TextBox author;
        private TextBox title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox search;
        private Button backBtn;
        private Button clrBtn;
        private Label label8;
    }
}