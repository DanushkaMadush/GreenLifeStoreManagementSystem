using GreenLifeStoreManagementSystem.Repositories;
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
    public partial class Dashboard : Form
    {
        private DashboardRepository dashboardRepository;

        public Dashboard()
        {
            InitializeComponent();
            dashboardRepository = new DashboardRepository();
            SetupCategoriesGrid();
            WireEvents();
            LoadDashboardData();
        }

        private void SetupCategoriesGrid()
        {
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.Columns.Clear();

            dataGridViewCategories.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Category",
                HeaderText = "Category",
                DataPropertyName = "Key",
                Width = 200,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridViewCategories.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductCount",
                HeaderText = "Product Count",
                DataPropertyName = "Value",
                Width = 120
            });
        }

        private void WireEvents()
        {
            buttonRefresh.Click += ButtonRefresh_Click;
            this.Load += Dashboard_Load;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                LoadBasicStats();
                LoadOrderStatusDetails();
                LoadCategoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBasicStats()
        {
            try
            {
                labelTotalProducts.Text = dashboardRepository.GetTotalProducts().ToString();
                labelTotalOrders.Text = dashboardRepository.GetTotalOrders().ToString();
                labelTotalCustomers.Text = dashboardRepository.GetTotalCustomers().ToString();
                labelTotalReviews.Text = dashboardRepository.GetTotalProductReviews().ToString();

                int lowStockCount = dashboardRepository.GetLowStockCount();
                labelLowStockCount.Text = lowStockCount.ToString();

                if (lowStockCount > 0)
                {
                    panelLowStock.BackColor = Color.FromArgb(231, 76, 60);
                }
                else
                {
                    panelLowStock.BackColor = Color.FromArgb(46, 204, 113);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading basic statistics: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadOrderStatusDetails()
        {
            try
            {
                labelPendingCount.Text = dashboardRepository.GetTotalPendingOrders().ToString();
                labelShippedCount.Text = dashboardRepository.GetTotalShippedOrders().ToString();
                labelDeliveredCount.Text = dashboardRepository.GetTotalDeliveredOrders().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order status details: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadCategoryData()
        {
            try
            {
                Dictionary<string, int> categoryData = dashboardRepository.GetCategoryWiseProducts();
                var categoryList = categoryData.Select(kvp => new
                {
                    Key = kvp.Key,
                    Value = kvp.Value
                }).ToList();

                dataGridViewCategories.DataSource = categoryList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading category data: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridViewCategories.DataSource = null;
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            MessageBox.Show("Dashboard data refreshed successfully!", "Refresh Complete",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
