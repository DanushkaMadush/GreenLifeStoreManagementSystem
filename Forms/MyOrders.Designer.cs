namespace GreenLifeStoreManagementSystem.Forms
{
    partial class MyOrders
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonRefresh;

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label labelDetailsTitle;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();

            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.labelDetailsTitle = new System.Windows.Forms.Label();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.panelMainContainer.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Controls.Add(this.panelTop);
            this.panelMainContainer.Controls.Add(this.dataGridViewOrders);
            this.panelMainContainer.Controls.Add(this.panelDetails);
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(800, 450);
            this.panelMainContainer.TabIndex = 0;

            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(245, 250, 245);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;
            this.panelTop.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.comboBoxStatus);
            this.panelTop.Controls.Add(this.buttonRefresh);

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(140, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "My Orders";

            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Items.AddRange(new object[] { "All", "Pending", "Shipped", "Delivered" });
            this.comboBoxStatus.Location = new System.Drawing.Point(200, 20);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(140, 25);
            this.comboBoxStatus.TabIndex = 1;

            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(360, 18);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(90, 28);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;

            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(20, 80);
            this.dataGridViewOrders.MultiSelect = false;
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(480, 340);
            this.dataGridViewOrders.TabIndex = 1;
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)));
            // Columns (add in code-behind for clarity)
            // OrderID, OrderDate, TotalAmount, Status

            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.panelDetails.Location = new System.Drawing.Point(520, 80);
            this.panelDetails.Size = new System.Drawing.Size(260, 340);
            this.panelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelDetails.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panelDetails.Controls.Add(this.labelDetailsTitle);
            this.panelDetails.Controls.Add(this.dataGridViewOrderDetails);

            // 
            // labelDetailsTitle
            // 
            this.labelDetailsTitle.AutoSize = true;
            this.labelDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.labelDetailsTitle.Location = new System.Drawing.Point(15, 10);
            this.labelDetailsTitle.Name = "labelDetailsTitle";
            this.labelDetailsTitle.Size = new System.Drawing.Size(110, 21);
            this.labelDetailsTitle.TabIndex = 0;
            this.labelDetailsTitle.Text = "Order Details";

            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.AllowUserToAddRows = false;
            this.dataGridViewOrderDetails.AllowUserToDeleteRows = false;
            this.dataGridViewOrderDetails.AllowUserToResizeRows = false;
            this.dataGridViewOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(15, 40);
            this.dataGridViewOrderDetails.MultiSelect = false;
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.ReadOnly = true;
            this.dataGridViewOrderDetails.RowHeadersVisible = false;
            this.dataGridViewOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(230, 280);
            this.dataGridViewOrderDetails.TabIndex = 1;
            // Columns (add in code-behind for clarity)
            // ProductName, Quantity, Price, Subtotal

            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyOrders";
            this.Text = "MyOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.panelMainContainer.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Public methods for MainForm or controller
        public void LoadOrders()
        {
            // To be implemented in code-behind
        }

        public void LoadOrderDetails(int orderId)
        {
            // To be implemented in code-behind
        }
    }
}