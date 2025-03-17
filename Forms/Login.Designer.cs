namespace BookHaven.Forms
{
    partial class Login
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
            userName = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cancelBtn = new Button();
            loginBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // userName
            // 
            userName.Font = new Font("Segoe UI", 11F);
            userName.Location = new Point(332, 124);
            userName.Name = "userName";
            userName.Size = new Size(243, 32);
            userName.TabIndex = 0;
            userName.TextChanged += userName_TextChanged;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 11F);
            password.Location = new Point(330, 225);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(243, 32);
            password.TabIndex = 1;
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(216, 124);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(216, 225);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 11F);
            cancelBtn.Location = new Point(348, 330);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(100, 38);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 11F);
            loginBtn.Location = new Point(473, 330);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(100, 38);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(271, 33);
            label3.Name = "label3";
            label3.Size = new Size(251, 37);
            label3.TabIndex = 6;
            label3.Text = "Book Haven - Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(loginBtn);
            Controls.Add(cancelBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(userName);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userName;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Button cancelBtn;
        private Button loginBtn;
        private Label label3;
    }
}