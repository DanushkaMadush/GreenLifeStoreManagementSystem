using GreenLifeStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GreenLifeStoreManagementSystem.Forms
{
    public partial class ManageCustomers : Form
    {
        private List<Customer> allCustomers;
        private Customer selectedCustomer;

        public ManageCustomers()
        {
            InitializeComponent();
            LoadAllCustomers();
            SetupEventHandlers();
            SetupSearchPlaceholder();
        }

        private void SetupEventHandlers()
        {
            dataGridViewCustomers.SelectionChanged += DataGridViewCustomers_SelectionChanged;
            buttonSearch.Click += ButtonSearch_Click;
            textBoxSearch.KeyDown += TextBoxSearch_KeyDown;
            textBoxSearch.Enter += TextBoxSearch_Enter;
            textBoxSearch.Leave += TextBoxSearch_Leave;
        }

        private void SetupSearchPlaceholder()
        {
            textBoxSearch.ForeColor = Color.Gray;
        }

        private void LoadAllCustomers()
        {
            try
            {
                allCustomers = Customer.GetAllCustomers();
                LoadCustomersToGrid(allCustomers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomersToGrid(List<Customer> customers)
        {
            dataGridViewCustomers.DataSource = null;

            if (customers != null && customers.Count > 0)
            {
                var customerData = customers.Select(c => new
                {
                    ID = c.UserId,
                    FullName = c.FullName,
                    Username = c.Username,
                    Email = c.Email,
                    Phone = c.Phone,
                    Address = c.Address
                }).ToList();

                dataGridViewCustomers.DataSource = customerData;

                if (dataGridViewCustomers.Columns.Count > 0)
                {
                    dataGridViewCustomers.Columns["ID"].Width = 50;
                    dataGridViewCustomers.Columns["FullName"].Width = 120;
                    dataGridViewCustomers.Columns["Username"].Width = 100;
                    dataGridViewCustomers.Columns["Email"].Width = 150;
                    dataGridViewCustomers.Columns["Phone"].Width = 100;
                    dataGridViewCustomers.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                dataGridViewCustomers.DataSource = new List<object>();
            }
        }

        private void DataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCustomers.SelectedRows[0];
                var customerId = (int)selectedRow.Cells["ID"].Value;

                selectedCustomer = allCustomers.FirstOrDefault(c => c.UserId == customerId);

                if (selectedCustomer != null)
                {
                    LoadCustomerDetails();
                }
            }
        }

        private void LoadCustomerDetails()
        {
            if (selectedCustomer != null)
            {
                textBoxFullName.Text = selectedCustomer.FullName ?? string.Empty;
                textBoxEmail.Text = selectedCustomer.Email ?? string.Empty;
                textBoxPhone.Text = selectedCustomer.Phone ?? string.Empty;
                textBoxAddress.Text = selectedCustomer.Address ?? string.Empty;

                buttonUpdate.Enabled = true;
            }
            else
            {
                ClearCustomerDetails();
                buttonUpdate.Enabled = false;
            }
        }

        private void ClearCustomerDetails()
        {
            textBoxFullName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            textBoxAddress.Clear();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
                e.Handled = true;
            }
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search by name or username" && textBoxSearch.ForeColor == Color.Gray)
            {
                textBoxSearch.Text = string.Empty;
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Search by name or username";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void PerformSearch()
        {
            if (allCustomers == null || allCustomers.Count == 0)
            {
                return;
            }

            string searchTerm = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm) ||
                searchTerm == "Search by name or username")
            {
                LoadCustomersToGrid(allCustomers);
                return;
            }

            var filteredCustomers = allCustomers.Where(c =>
                (!string.IsNullOrEmpty(c.FullName) && c.FullName.ToLower().Contains(searchTerm.ToLower())) ||
                (!string.IsNullOrEmpty(c.Username) && c.Username.ToLower().Contains(searchTerm.ToLower()))
            ).ToList();

            LoadCustomersToGrid(filteredCustomers);

            if (filteredCustomers.Count == 0)
            {
                MessageBox.Show("No customers found matching the search criteria.", "Search Results",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer to update.", "No Selection",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return;
            }

            try
            {
                selectedCustomer.FullName = textBoxFullName.Text.Trim();
                selectedCustomer.Email = textBoxEmail.Text.Trim();
                selectedCustomer.Phone = textBoxPhone.Text.Trim();
                selectedCustomer.Address = textBoxAddress.Text.Trim();

                bool updateSuccess = selectedCustomer.UpdateProfile();

                if (updateSuccess)
                {
                    MessageBox.Show("Customer profile updated successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAllCustomers();
                }
                else
                {
                    MessageBox.Show("Failed to update customer profile. Please try again.", "Update Failed",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public void RefreshCustomers()
        {
            LoadAllCustomers();
        }
    }
}
