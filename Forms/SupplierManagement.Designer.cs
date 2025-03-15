namespace BookHaven.Forms
{
    partial class SupplierManagement
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
            suppliersGridView = new DataGridView();
            updateBtn = new Button();
            addBtn = new Button();
            backBtn = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            name = new TextBox();
            contact = new TextBox();
            email = new TextBox();
            id = new TextBox();
            clearBtn = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)suppliersGridView).BeginInit();
            SuspendLayout();
            // 
            // suppliersGridView
            // 
            suppliersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliersGridView.Location = new Point(61, 334);
            suppliersGridView.Name = "suppliersGridView";
            suppliersGridView.RowHeadersWidth = 51;
            suppliersGridView.Size = new Size(623, 184);
            suppliersGridView.TabIndex = 0;
            suppliersGridView.CellClick += cellClick;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(145, 242);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(83, 34);
            updateBtn.TabIndex = 49;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(20, 242);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(83, 34);
            addBtn.TabIndex = 48;
            addBtn.Text = "+ Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(18, 11);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 47;
            backBtn.Text = "< Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 183);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 46;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 132);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 45;
            label4.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 81);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 44;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 81);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 43;
            label1.Text = "Contact";
            // 
            // name
            // 
            name.Location = new Point(114, 132);
            name.Name = "name";
            name.Size = new Size(246, 27);
            name.TabIndex = 42;
            // 
            // contact
            // 
            contact.Location = new Point(483, 78);
            contact.Name = "contact";
            contact.Size = new Size(246, 27);
            contact.TabIndex = 41;
            // 
            // email
            // 
            email.Location = new Point(114, 183);
            email.Name = "email";
            email.Size = new Size(246, 27);
            email.TabIndex = 40;
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(114, 78);
            id.Name = "id";
            id.Size = new Size(246, 27);
            id.TabIndex = 39;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(277, 242);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(83, 34);
            clearBtn.TabIndex = 50;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(241, 6);
            label3.Name = "label3";
            label3.Size = new Size(252, 32);
            label3.TabIndex = 51;
            label3.Text = "Supplier Management";
            // 
            // SupplierManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 550);
            Controls.Add(label3);
            Controls.Add(clearBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(backBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name);
            Controls.Add(contact);
            Controls.Add(email);
            Controls.Add(id);
            Controls.Add(suppliersGridView);
            Name = "SupplierManagement";
            Text = "SupplierManagement";
            ((System.ComponentModel.ISupportInitialize)suppliersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView suppliersGridView;
        private Button updateBtn;
        private Button addBtn;
        private Button backBtn;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox name;
        private TextBox contact;
        private TextBox email;
        private TextBox id;
        private Button clearBtn;
        private Label label3;
    }
}