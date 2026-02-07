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
    public partial class ManageOrders : Form
    {
        private List<Order> allOrders;

        public ManageOrders()
        {
            InitializeComponent();
            SetupGrids();
            WireEvents();
            LoadAllOrders();
        }

        private void SetupGrids()
        {
            dataGridViewOrders.AutoGenerateColumns = false;
            dataGridViewOrders.Columns.Clear();

            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "OrderId",
                HeaderText = "Order ID",
                DataPropertyName = "OrderId",
                Width = 80
            });

            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CustomerId",
                HeaderText = "Customer ID",
                DataPropertyName = "CustomerId",
                Width = 100
            });

            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "OrderDate",
                HeaderText = "Order Date",
                DataPropertyName = "OrderDate",
                Width = 120,
                DefaultCellStyle = { Format = "dd/MM/yyyy HH:mm" }
            });

            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                Width = 100
            });

            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "TotalAmount",
                HeaderText = "Total Amount",
                DataPropertyName = "TotalAmount",
                Width = 120,
                DefaultCellStyle = { Format = "C2" }
            });

            dataGridViewOrderItems.AutoGenerateColumns = false;
            dataGridViewOrderItems.Columns.Clear();

            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductName",
                HeaderText = "Product",
                DataPropertyName = "ProductName",
                Width = 150
            });

            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity",
                Width = 80
            });

            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                Width = 100,
                DefaultCellStyle = { Format = "C2" }
            });

            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "SubTotal",
                HeaderText = "Subtotal",
                DataPropertyName = "SubTotal",
                Width = 100,
                DefaultCellStyle = { Format = "C2" }
            });

            comboBoxFilterStatus.SelectedIndex = 0;
            comboBoxUpdateStatus.SelectedIndex = 0;
        }

        private void WireEvents()
        {
            dataGridViewOrders.SelectionChanged += DataGridViewOrders_SelectionChanged;
            buttonUpdateStatus.Click += ButtonUpdateStatus_Click;
            buttonRefresh.Click += ButtonRefresh_Click;
            comboBoxFilterStatus.SelectedIndexChanged += ComboBoxFilterStatus_SelectedIndexChanged;
        }

        private void LoadAllOrders()
        {
            try
            {
                allOrders = Order.GetAllOrders();
                ApplyStatusFilter();
                dataGridViewOrderItems.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyStatusFilter()
        {
            try
            {
                List<Order> filteredOrders;

                if (comboBoxFilterStatus.SelectedItem?.ToString() == "All" || comboBoxFilterStatus.SelectedIndex == 0)
                {
                    filteredOrders = allOrders;
                }
                else
                {
                    string selectedStatus = comboBoxFilterStatus.SelectedItem.ToString();
                    filteredOrders = allOrders.Where(o => o.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                dataGridViewOrders.DataSource = filteredOrders;
                dataGridViewOrderItems.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering orders: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrderItems(int orderId)
        {
            try
            {
                List<OrderItem> orderItems = Order.GetOrderItems(orderId);
                dataGridViewOrderItems.DataSource = orderItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order items: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewOrders.SelectedRows[0];
                if (selectedRow.DataBoundItem is Order selectedOrder)
                {
                    LoadOrderItems(selectedOrder.OrderId);
                    comboBoxUpdateStatus.SelectedItem = selectedOrder.Status;
                }
            }
            else
            {
                dataGridViewOrderItems.DataSource = null;
            }
        }

        private void ComboBoxFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyStatusFilter();
        }

        private void ButtonUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to update.", "No Order Selected",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxUpdateStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "No Status Selected",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedRow = dataGridViewOrders.SelectedRows[0];
                if (selectedRow.DataBoundItem is Order selectedOrder)
                {
                    string newStatus = comboBoxUpdateStatus.SelectedItem.ToString();

                    if (selectedOrder.Status == newStatus)
                    {
                        MessageBox.Show("The order already has this status.", "Same Status",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    bool success = selectedOrder.UpdateStatus(newStatus);

                    if (success)
                    {
                        MessageBox.Show("Order status updated successfully!", "Success",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllOrders();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update order status. Please try again.", "Error",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating order status: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
        }
    }
}
