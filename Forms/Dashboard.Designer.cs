namespace GreenLifeStoreManagementSystem.Forms
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelDashboardTitle = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.tableLayoutPanelStats = new System.Windows.Forms.TableLayoutPanel();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.labelTotalProducts = new System.Windows.Forms.Label();
            this.labelProductsTitle = new System.Windows.Forms.Label();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.labelTotalOrders = new System.Windows.Forms.Label();
            this.labelOrdersTitle = new System.Windows.Forms.Label();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.labelTotalCustomers = new System.Windows.Forms.Label();
            this.labelCustomersTitle = new System.Windows.Forms.Label();
            this.panelReviews = new System.Windows.Forms.Panel();
            this.labelTotalReviews = new System.Windows.Forms.Label();
            this.labelReviewsTitle = new System.Windows.Forms.Label();
            this.panelLowStock = new System.Windows.Forms.Panel();
            this.labelLowStockCount = new System.Windows.Forms.Label();
            this.labelLowStockTitle = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDetails = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCategories = new System.Windows.Forms.GroupBox();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.chartOrderStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.tableLayoutPanelStats.SuspendLayout();
            this.panelProducts.SuspendLayout();
            this.panelOrders.SuspendLayout();
            this.panelCustomers.SuspendLayout();
            this.panelReviews.SuspendLayout();
            this.panelLowStock.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.tableLayoutPanelDetails.SuspendLayout();
            this.groupBoxCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrderStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelStats, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelDetails, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1000, 600);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.panelHeader.Controls.Add(this.buttonRefresh);
            this.panelHeader.Controls.Add(this.labelDashboardTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackColor = System.Drawing.Color.White;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRefresh.Location = new System.Drawing.Point(900, 15);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(80, 30);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // labelDashboardTitle
            // 
            this.labelDashboardTitle.AutoSize = true;
            this.labelDashboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelDashboardTitle.ForeColor = System.Drawing.Color.White;
            this.labelDashboardTitle.Location = new System.Drawing.Point(20, 15);
            this.labelDashboardTitle.Name = "labelDashboardTitle";
            this.labelDashboardTitle.Size = new System.Drawing.Size(339, 29);
            this.labelDashboardTitle.TabIndex = 0;
            this.labelDashboardTitle.Text = "Green Life Store Dashboard";
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.tableLayoutPanelStats);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStats.Location = new System.Drawing.Point(10, 70);
            this.panelStats.Margin = new System.Windows.Forms.Padding(10);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(980, 140);
            this.panelStats.TabIndex = 1;
            // 
            // tableLayoutPanelStats
            // 
            this.tableLayoutPanelStats.ColumnCount = 5;
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStats.Controls.Add(this.panelProducts, 0, 0);
            this.tableLayoutPanelStats.Controls.Add(this.panelOrders, 1, 0);
            this.tableLayoutPanelStats.Controls.Add(this.panelCustomers, 2, 0);
            this.tableLayoutPanelStats.Controls.Add(this.panelReviews, 3, 0);
            this.tableLayoutPanelStats.Controls.Add(this.panelLowStock, 4, 0);
            this.tableLayoutPanelStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStats.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelStats.Name = "tableLayoutPanelStats";
            this.tableLayoutPanelStats.RowCount = 1;
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStats.Size = new System.Drawing.Size(980, 140);
            this.tableLayoutPanelStats.TabIndex = 0;
            // 
            // panelProducts
            // 
            this.panelProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelProducts.Controls.Add(this.labelTotalProducts);
            this.panelProducts.Controls.Add(this.labelProductsTitle);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(5, 5);
            this.panelProducts.Margin = new System.Windows.Forms.Padding(5);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(186, 130);
            this.panelProducts.TabIndex = 0;
            // 
            // labelTotalProducts
            // 
            this.labelTotalProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelTotalProducts.ForeColor = System.Drawing.Color.White;
            this.labelTotalProducts.Location = new System.Drawing.Point(0, 50);
            this.labelTotalProducts.Name = "labelTotalProducts";
            this.labelTotalProducts.Size = new System.Drawing.Size(186, 40);
            this.labelTotalProducts.TabIndex = 1;
            this.labelTotalProducts.Text = "0";
            this.labelTotalProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProductsTitle
            // 
            this.labelProductsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProductsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelProductsTitle.ForeColor = System.Drawing.Color.White;
            this.labelProductsTitle.Location = new System.Drawing.Point(0, 0);
            this.labelProductsTitle.Name = "labelProductsTitle";
            this.labelProductsTitle.Size = new System.Drawing.Size(186, 40);
            this.labelProductsTitle.TabIndex = 0;
            this.labelProductsTitle.Text = "Total Products";
            this.labelProductsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOrders
            // 
            this.panelOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelOrders.Controls.Add(this.labelTotalOrders);
            this.panelOrders.Controls.Add(this.labelOrdersTitle);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(201, 5);
            this.panelOrders.Margin = new System.Windows.Forms.Padding(5);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(186, 130);
            this.panelOrders.TabIndex = 1;
            // 
            // labelTotalOrders
            // 
            this.labelTotalOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelTotalOrders.ForeColor = System.Drawing.Color.White;
            this.labelTotalOrders.Location = new System.Drawing.Point(0, 50);
            this.labelTotalOrders.Name = "labelTotalOrders";
            this.labelTotalOrders.Size = new System.Drawing.Size(186, 40);
            this.labelTotalOrders.TabIndex = 1;
            this.labelTotalOrders.Text = "0";
            this.labelTotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrdersTitle
            // 
            this.labelOrdersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOrdersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelOrdersTitle.ForeColor = System.Drawing.Color.White;
            this.labelOrdersTitle.Location = new System.Drawing.Point(0, 0);
            this.labelOrdersTitle.Name = "labelOrdersTitle";
            this.labelOrdersTitle.Size = new System.Drawing.Size(186, 40);
            this.labelOrdersTitle.TabIndex = 0;
            this.labelOrdersTitle.Text = "Total Orders";
            this.labelOrdersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCustomers
            // 
            this.panelCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panelCustomers.Controls.Add(this.labelTotalCustomers);
            this.panelCustomers.Controls.Add(this.labelCustomersTitle);
            this.panelCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomers.Location = new System.Drawing.Point(397, 5);
            this.panelCustomers.Margin = new System.Windows.Forms.Padding(5);
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Size = new System.Drawing.Size(186, 130);
            this.panelCustomers.TabIndex = 2;
            // 
            // labelTotalCustomers
            // 
            this.labelTotalCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelTotalCustomers.ForeColor = System.Drawing.Color.White;
            this.labelTotalCustomers.Location = new System.Drawing.Point(0, 50);
            this.labelTotalCustomers.Name = "labelTotalCustomers";
            this.labelTotalCustomers.Size = new System.Drawing.Size(186, 40);
            this.labelTotalCustomers.TabIndex = 1;
            this.labelTotalCustomers.Text = "0";
            this.labelTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCustomersTitle
            // 
            this.labelCustomersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCustomersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelCustomersTitle.ForeColor = System.Drawing.Color.White;
            this.labelCustomersTitle.Location = new System.Drawing.Point(0, 0);
            this.labelCustomersTitle.Name = "labelCustomersTitle";
            this.labelCustomersTitle.Size = new System.Drawing.Size(186, 40);
            this.labelCustomersTitle.TabIndex = 0;
            this.labelCustomersTitle.Text = "Total Customers";
            this.labelCustomersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelReviews
            // 
            this.panelReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panelReviews.Controls.Add(this.labelTotalReviews);
            this.panelReviews.Controls.Add(this.labelReviewsTitle);
            this.panelReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReviews.Location = new System.Drawing.Point(593, 5);
            this.panelReviews.Margin = new System.Windows.Forms.Padding(5);
            this.panelReviews.Name = "panelReviews";
            this.panelReviews.Size = new System.Drawing.Size(186, 130);
            this.panelReviews.TabIndex = 3;
            // 
            // labelTotalReviews
            // 
            this.labelTotalReviews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotalReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelTotalReviews.ForeColor = System.Drawing.Color.White;
            this.labelTotalReviews.Location = new System.Drawing.Point(0, 50);
            this.labelTotalReviews.Name = "labelTotalReviews";
            this.labelTotalReviews.Size = new System.Drawing.Size(186, 40);
            this.labelTotalReviews.TabIndex = 1;
            this.labelTotalReviews.Text = "0";
            this.labelTotalReviews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReviewsTitle
            // 
            this.labelReviewsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelReviewsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelReviewsTitle.ForeColor = System.Drawing.Color.White;
            this.labelReviewsTitle.Location = new System.Drawing.Point(0, 0);
            this.labelReviewsTitle.Name = "labelReviewsTitle";
            this.labelReviewsTitle.Size = new System.Drawing.Size(186, 40);
            this.labelReviewsTitle.TabIndex = 0;
            this.labelReviewsTitle.Text = "Total Reviews";
            this.labelReviewsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLowStock
            // 
            this.panelLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panelLowStock.Controls.Add(this.labelLowStockCount);
            this.panelLowStock.Controls.Add(this.labelLowStockTitle);
            this.panelLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLowStock.Location = new System.Drawing.Point(789, 5);
            this.panelLowStock.Margin = new System.Windows.Forms.Padding(5);
            this.panelLowStock.Name = "panelLowStock";
            this.panelLowStock.Size = new System.Drawing.Size(186, 130);
            this.panelLowStock.TabIndex = 4;
            // 
            // labelLowStockCount
            // 
            this.labelLowStockCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLowStockCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.labelLowStockCount.ForeColor = System.Drawing.Color.White;
            this.labelLowStockCount.Location = new System.Drawing.Point(0, 50);
            this.labelLowStockCount.Name = "labelLowStockCount";
            this.labelLowStockCount.Size = new System.Drawing.Size(186, 40);
            this.labelLowStockCount.TabIndex = 1;
            this.labelLowStockCount.Text = "0";
            this.labelLowStockCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLowStockTitle
            // 
            this.labelLowStockTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLowStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelLowStockTitle.ForeColor = System.Drawing.Color.White;
            this.labelLowStockTitle.Location = new System.Drawing.Point(0, 0);
            this.labelLowStockTitle.Name = "labelLowStockTitle";
            this.labelLowStockTitle.Size = new System.Drawing.Size(186, 40);
            this.labelLowStockTitle.TabIndex = 0;
            this.labelLowStockTitle.Text = "Low Stock Alert";
            this.labelLowStockTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.tableLayoutPanelDetails);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(10, 230);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(10);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(980, 360);
            this.panelDetails.TabIndex = 2;
            // 
            // tableLayoutPanelDetails
            // 
            this.tableLayoutPanelDetails.ColumnCount = 2;
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDetails.Controls.Add(this.chartOrderStatus, 0, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.groupBoxCategories, 1, 0);
            this.tableLayoutPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDetails.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDetails.Name = "tableLayoutPanelDetails";
            this.tableLayoutPanelDetails.RowCount = 1;
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDetails.Size = new System.Drawing.Size(980, 360);
            this.tableLayoutPanelDetails.TabIndex = 0;
            // 
            // groupBoxCategories
            // 
            this.groupBoxCategories.Controls.Add(this.dataGridViewCategories);
            this.groupBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxCategories.Location = new System.Drawing.Point(500, 10);
            this.groupBoxCategories.Margin = new System.Windows.Forms.Padding(10);
            this.groupBoxCategories.Name = "groupBoxCategories";
            this.groupBoxCategories.Size = new System.Drawing.Size(470, 340);
            this.groupBoxCategories.TabIndex = 1;
            this.groupBoxCategories.TabStop = false;
            this.groupBoxCategories.Text = "Products by Category";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCategories.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategories.Size = new System.Drawing.Size(464, 315);
            this.dataGridViewCategories.TabIndex = 0;
            // 
            // chartOrderStatus
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOrderStatus.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOrderStatus.Legends.Add(legend1);
            this.chartOrderStatus.Location = new System.Drawing.Point(3, 3);
            this.chartOrderStatus.Name = "chartOrderStatus";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "#PERCENT{P0}";
            series1.Legend = "Legend1";
            series1.Name = "OrderStatus";
            this.chartOrderStatus.Series.Add(series1);
            this.chartOrderStatus.Size = new System.Drawing.Size(484, 347);
            this.chartOrderStatus.TabIndex = 15;
            this.chartOrderStatus.Text = "Order Status Distribution";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Order Status Distribution";
            this.chartOrderStatus.Titles.Add(title1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green Life Store - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.tableLayoutPanelStats.ResumeLayout(false);
            this.panelProducts.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            this.panelCustomers.ResumeLayout(false);
            this.panelReviews.ResumeLayout(false);
            this.panelLowStock.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.tableLayoutPanelDetails.ResumeLayout(false);
            this.groupBoxCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrderStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelDashboardTitle;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStats;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Label labelTotalProducts;
        private System.Windows.Forms.Label labelProductsTitle;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Label labelTotalOrders;
        private System.Windows.Forms.Label labelOrdersTitle;
        private System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.Label labelTotalCustomers;
        private System.Windows.Forms.Label labelCustomersTitle;
        private System.Windows.Forms.Panel panelReviews;
        private System.Windows.Forms.Label labelTotalReviews;
        private System.Windows.Forms.Label labelReviewsTitle;
        private System.Windows.Forms.Panel panelLowStock;
        private System.Windows.Forms.Label labelLowStockCount;
        private System.Windows.Forms.Label labelLowStockTitle;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetails;
        private System.Windows.Forms.GroupBox groupBoxCategories;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrderStatus;
    }
}