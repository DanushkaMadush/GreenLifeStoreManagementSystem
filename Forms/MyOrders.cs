using GreenLifeStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GreenLifeStoreManagementSystem.Forms
{
    public partial class MyOrders : Form
    {
        private User currentUser;
        private List<Order> allOrders;

        public MyOrders(User user)
        {
            InitializeComponent();
            currentUser = user;
            SetupGrids();
            WireEvents();
            LoadOrders();
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
                Name = "OrderDate",
                HeaderText = "Order Date",
                DataPropertyName = "OrderDate",
                Width = 120,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
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

            dataGridViewOrderDetails.AutoGenerateColumns = false;
            dataGridViewOrderDetails.Columns.Clear();

            dataGridViewOrderDetails.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductName",
                HeaderText = "Product",
                DataPropertyName = "ProductName",
                Width = 120
            });

            dataGridViewOrderDetails.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantity",
                HeaderText = "Qty",
                DataPropertyName = "Quantity",
                Width = 50
            });

            dataGridViewOrderDetails.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                Width = 80,
                DefaultCellStyle = { Format = "C2" }
            });

            dataGridViewOrderDetails.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "SubTotal",
                HeaderText = "Subtotal",
                DataPropertyName = "SubTotal",
                Width = 80,
                DefaultCellStyle = { Format = "C2" }
            });

            comboBoxStatus.SelectedIndex = 0;
        }

        private void WireEvents()
        {
            dataGridViewOrders.SelectionChanged += DataGridViewOrders_SelectionChanged;
            comboBoxStatus.SelectedIndexChanged += ComboBoxStatus_SelectedIndexChanged;
            buttonRefresh.Click += ButtonRefresh_Click;
        }

        private void LoadOrders()
        {
            try
            {
                allOrders = Order.GetOrdersByCustomer(currentUser.UserId);
                ApplyStatusFilter();
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

                if (comboBoxStatus.SelectedItem?.ToString() == "All" || comboBoxStatus.SelectedIndex == 0)
                {
                    filteredOrders = allOrders;
                }
                else
                {
                    string selectedStatus = comboBoxStatus.SelectedItem.ToString();
                    filteredOrders = allOrders.Where(o => o.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                dataGridViewOrders.DataSource = filteredOrders;
                dataGridViewOrderDetails.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering orders: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrderDetails(int orderId)
        {
            try
            {
                List<OrderItem> orderItems = Order.GetOrderItems(orderId);
                dataGridViewOrderDetails.DataSource = orderItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order details: {ex.Message}", "Error",
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
                    LoadOrderDetails(selectedOrder.OrderId);
                }
            }
        }

        private void ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyStatusFilter();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
