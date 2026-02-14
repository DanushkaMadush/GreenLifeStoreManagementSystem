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
using System.Windows.Forms.DataVisualization.Charting;

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
                LoadCategoryData();
                LoadOrderStatusChart();
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

        private void LoadOrderStatusChart()
        {
            try
            {
                int pendingCount = dashboardRepository.GetTotalPendingOrders();
                int shippedCount = dashboardRepository.GetTotalShippedOrders();
                int deliveredCount = dashboardRepository.GetTotalDeliveredOrders();
                chartOrderStatus.Series["OrderStatus"].Points.Clear();

                if (pendingCount > 0 || shippedCount > 0 || deliveredCount > 0)
                {
                    if (pendingCount > 0)
                    {
                        var pendingPoint = chartOrderStatus.Series["OrderStatus"].Points.AddXY("Pending", pendingCount);
                        chartOrderStatus.Series["OrderStatus"].Points[pendingPoint].Color = Color.FromArgb(255, 193, 7);
                    }

                    if (shippedCount > 0)
                    {
                        var shippedPoint = chartOrderStatus.Series["OrderStatus"].Points.AddXY("Shipped", shippedCount);
                        chartOrderStatus.Series["OrderStatus"].Points[shippedPoint].Color = Color.FromArgb(0, 123, 255);
                    }

                    if (deliveredCount > 0)
                    {
                        var deliveredPoint = chartOrderStatus.Series["OrderStatus"].Points.AddXY("Delivered", deliveredCount);
                        chartOrderStatus.Series["OrderStatus"].Points[deliveredPoint].Color = Color.FromArgb(40, 167, 69);
                    }

                    chartOrderStatus.ChartAreas[0].Area3DStyle.Enable3D = true;
                    chartOrderStatus.ChartAreas[0].Area3DStyle.Inclination = 20;
                }
                else
                {
                    chartOrderStatus.Series["OrderStatus"].Points.AddXY("No Orders", 1);
                    chartOrderStatus.Series["OrderStatus"].Points[0].Color = Color.LightGray;
                }

                chartOrderStatus.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order status chart: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
