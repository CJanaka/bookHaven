﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Business.services;
using BookHaven.Common;

namespace BookHaven.Forms
{
    public partial class Login : Form
    {
        private readonly AuthService _authService;
        public Login(AuthService authService)
        {
            _authService = authService;
            InitializeComponent();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {


            string username = userName.Text;
            string pwd = password.Text;

            if (_authService.AuthenticateUser(username, pwd, out string role))
            {
                MessageBox.Show($"Welcome {username}! You are logged in as {role}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SessionManager.CurrentRole = role;
                this.Hide();
                Form dashboard = new AdminDashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
