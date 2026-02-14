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

namespace GreenLifeStoreManagementSystem.Forms
{
    public partial class Profile : Form
    {
        private User currentUser;

        public Profile(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadUserProfile();
        }

        public Profile()
        {
            InitializeComponent();
        }

        public void LoadUserProfile()
        {
            if (currentUser == null) return;

            try
            {
                textBoxFullName.Text = currentUser.FullName ?? string.Empty;
                textBoxUsername.Text = currentUser.Username ?? string.Empty;
                textBoxEmail.Text = currentUser.Email ?? string.Empty;
                textBoxPhone.Text = currentUser.Phone ?? string.Empty;
                textBoxAddress.Text = currentUser.Address ?? string.Empty;
                textBoxAddress.Text = currentUser.Address ?? string.Empty;
                textBoxPassword.Text = string.Empty;
                textBoxConfirmPassword.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        public void LoadUserById(int userId)
        {
            try
            {
                currentUser = User.GetUserById(userId);
                if (currentUser != null)
                {
                    LoadUserProfile();
                }
                else
                {
                    MessageBox.Show("User not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
                {
                    MessageBox.Show("Full Name is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxFullName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    MessageBox.Show("Email is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxEmail.Focus();
                    return;
                }

                if (!string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    if (textBoxPassword.Text != textBoxConfirmPassword.Text)
                    {
                        MessageBox.Show("Password and Confirm Password do not match.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxConfirmPassword.Focus();
                        return;
                    }
                }

                currentUser.FullName = textBoxFullName.Text.Trim();
                currentUser.Email = textBoxEmail.Text.Trim();
                currentUser.Phone = textBoxPhone.Text.Trim();
                currentUser.Address = textBoxAddress.Text.Trim();

                if (!string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    currentUser.Password = textBoxPassword.Text;
                }

                bool success = currentUser.UpdateProfile();

                if (success)
                {
                    MessageBox.Show("Profile updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxPassword.Text = string.Empty;
                    textBoxConfirmPassword.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Failed to update profile. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating profile: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
