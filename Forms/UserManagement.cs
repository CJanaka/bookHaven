using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Business.services;
using BookHaven.Data.entity;

namespace BookHaven.Forms
{
    public partial class UserManagement : Form
    {

        private readonly AuthService _authService;

        public UserManagement(AuthService authService)
        {
            _authService = authService;
            InitializeComponent();
            LoadUsers();
            LoadRoles();
        }

        private void LoadUsers()
        {
            var users = _authService.GetAllUsers();
            usersGridView.DataSource = users.Select(user => new
            {
                user.Id,
                user.UserName,
                user.Role
            }).ToList();
        }

        private void LoadRoles()
        {
            // Populate the roles combo box
            rolesBox.Items.Add("admin");
            rolesBox.Items.Add("cleark");
            rolesBox.SelectedIndex = 0;
        }

        private void clearFields()
        {
            id.Clear();
            userName.Clear();
            password.Clear();
            rolesBox.SelectedIndex = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userName.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Username and password are required!");
                return;
            }

            _authService.RegisterUser(userName.Text, password.Text, "clerk");
            MessageBox.Show("User added successfully!");
            clearFields();
            LoadUsers();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            int userId = int.Parse(id.Text);
            var user = _authService.GetUserById(userId);

            if (user == null)
            {
                MessageBox.Show("User not found!");
                return;
            }

            _authService.updateUser(userName.Text, password.Text, rolesBox.SelectedItem.ToString(), user);
            MessageBox.Show("User updated successfully!");
            clearFields();
            LoadUsers();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int userId = int.Parse(id.Text);

            var user = _authService.GetUserById(userId);

            if (user == null)
            {
                MessageBox.Show("User not found!");
                return;
            }

            // Confirm deletion
            var result = MessageBox.Show("Are you sure you want to delete this user?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _authService.deleteUser(user);
                MessageBox.Show("User deleted successfully!");
                clearFields();
                LoadUsers();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = search.Text;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadUsers();
                return;
            }

            var users = _authService.searchUsers(keyword);
            usersGridView.DataSource = users.Select(user => new
            {
                user.Id,
                user.UserName,
                user.Role
            }).ToList();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            clearFields();
            search.Clear();
            LoadUsers();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var dashboard = new AdminDashboard();
            Common.Common.goBack(this, dashboard);
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            var dashboard = new AdminDashboard();
            Common.Common.goBack(this, dashboard);
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = usersGridView.Rows[e.RowIndex];

                id.Text = row.Cells["Id"].Value.ToString();
                userName.Text = row.Cells["UserName"].Value.ToString();
                password.Clear(); // Don't load password for security reasons
                rolesBox.SelectedItem = row.Cells["Role"].Value.ToString();
            }
        }
    }
}
