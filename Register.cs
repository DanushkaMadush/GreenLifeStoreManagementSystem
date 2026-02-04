using GreenLifeStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeStoreManagementSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFullName.Text = string.Empty;
            textBoxUsername.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxConfirmPassword.Text = string.Empty;
            labelValidation.Text = string.Empty;
            textBoxFullName.Focus();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string role = "Customer";

            labelValidation.Text = string.Empty;

            if (string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone))
            {
                labelValidation.Text = "Please fill in all fields.";
                return;
            }

            if (password != confirmPassword)
            {
                labelValidation.Text = "Passwords do not match.";
                textBoxPassword.Clear();
                textBoxConfirmPassword.Clear();
                textBoxPassword.Focus();
                return;
            }

            if (User.IsUsernameTaken(username))
            {
                labelValidation.Text = "Username already exists.";
                textBoxUsername.Focus();
                return;
            }

            var user = new User
            {
                FullName = fullName,
                Username = username,
                Password = password,
                Email = email,
                Phone = phone,
                Address = address,
                Role = role
            };

            bool result = user.Register();

            if (result)
            {
                MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                labelValidation.Text = "Registration Failed. Please try again.";
            }
        }
    }
}
