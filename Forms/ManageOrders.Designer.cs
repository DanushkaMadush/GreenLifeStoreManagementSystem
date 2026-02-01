namespace GreenLifeStoreManagementSystem.Forms
{
    partial class ManageOrders
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxFilterStatus;
        private System.Windows.Forms.Button buttonRefresh;

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label labelOrderItems;
        private System.Windows.Forms.DataGridView dataGridViewOrderItems;

        private System.Windows.Forms.Panel panelStatusUpdate;
        private System.Windows.Forms.Label labelUpdateStatus;
        private System.Windows.Forms.ComboBox comboBoxUpdateStatus;
        private System.Windows.Forms.Button buttonUpdateStatus;

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
            this.comboBoxFilterStatus = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();

            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.labelOrderItems = new System.Windows.Forms.Label();
            this.dataGridViewOrderItems = new System.Windows.Forms.DataGridView();

            this.panelStatusUpdate = new System.Windows.Forms.Panel();
            this.labelUpdateStatus = new System.Windows.Forms.Label();
            this.comboBoxUpdateStatus = new System.Windows.Forms.ComboBox();
            this.buttonUpdateStatus = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            this.panelMainContainer.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelStatusUpdate.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Controls.Add(this.panelTop);
            this.panelMainContainer.Controls.Add(this.dataGridViewOrders);
            this.panelMainContainer.Controls.Add(this.panelDetails);
            this.panelMainContainer.Controls.Add(this.panelStatusUpdate);
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1002, 597);
            this.panelMainContainer.TabIndex = 0;

            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(245, 250, 245);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;
            this.panelTop.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.comboBoxFilterStatus);
            this.panelTop.Controls.Add(this.buttonRefresh);

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.labelTitle.Location = new System.Drawing.Point(20, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(210, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Manage Orders";

            // 
            // comboBoxFilterStatus
            // 
            this.comboBoxFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterStatus.Items.AddRange(new object[] { "All", "Pending", "Shipped", "Delivered" });
            this.comboBoxFilterStatus.Location = new System.Drawing.Point(250, 20);
            this.comboBoxFilterStatus.Name = "comboBoxFilterStatus";
            this.comboBoxFilterStatus.Size = new System.Drawing.Size(140, 25);
            this.comboBoxFilterStatus.TabIndex = 1;

            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(410, 18);
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
            this.dataGridViewOrders.Size = new System.Drawing.Size(600, 350);
            this.dataGridViewOrders.TabIndex = 1;
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Bottom)));
            // Columns (add in code-behind for clarity)
            // OrderID, CustomerName, OrderDate, TotalAmount, Status

            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.Location = new System.Drawing.Point(640, 80);
            this.panelDetails.Size = new System.Drawing.Size(340, 250);
            this.panelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelDetails.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panelDetails.Controls.Add(this.labelOrderItems);
            this.panelDetails.Controls.Add(this.dataGridViewOrderItems);

            // 
            // labelOrderItems
            // 
            this.labelOrderItems.AutoSize = true;
            this.labelOrderItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelOrderItems.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.labelOrderItems.Location = new System.Drawing.Point(15, 10);
            this.labelOrderItems.Name = "labelOrderItems";
            this.labelOrderItems.Size = new System.Drawing.Size(102, 21);
            this.labelOrderItems.TabIndex = 0;
            this.labelOrderItems.Text = "Order Items";

            // 
            // dataGridViewOrderItems
            // 
            this.dataGridViewOrderItems.AllowUserToAddRows = false;
            this.dataGridViewOrderItems.AllowUserToDeleteRows = false;
            this.dataGridViewOrderItems.AllowUserToResizeRows = false;
            this.dataGridViewOrderItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(15, 40);
            this.dataGridViewOrderItems.MultiSelect = false;
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.ReadOnly = true;
            this.dataGridViewOrderItems.RowHeadersVisible = false;
            this.dataGridViewOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(310, 190);
            this.dataGridViewOrderItems.TabIndex = 1;
            // Columns (add in code-behind for clarity)
            // ProductName, Quantity, Price, Subtotal

            // 
            // panelStatusUpdate
            // 
            this.panelStatusUpdate.BackColor = System.Drawing.Color.FromArgb(245, 250, 245);
            this.panelStatusUpdate.Location = new System.Drawing.Point(640, 350);
            this.panelStatusUpdate.Size = new System.Drawing.Size(340, 80);
            this.panelStatusUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatusUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelStatusUpdate.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panelStatusUpdate.Controls.Add(this.labelUpdateStatus);
            this.panelStatusUpdate.Controls.Add(this.comboBoxUpdateStatus);
            this.panelStatusUpdate.Controls.Add(this.buttonUpdateStatus);

            // 
            // labelUpdateStatus
            // 
            this.labelUpdateStatus.AutoSize = true;
            this.labelUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.labelUpdateStatus.Location = new System.Drawing.Point(15, 15);
            this.labelUpdateStatus.Name = "labelUpdateStatus";
            this.labelUpdateStatus.Size = new System.Drawing.Size(102, 19);
            this.labelUpdateStatus.TabIndex = 0;
            this.labelUpdateStatus.Text = "Update Status";

            // 
            // comboBoxUpdateStatus
            // 
            this.comboBoxUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxUpdateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateStatus.Items.AddRange(new object[] { "Pending", "Shipped", "Delivered" });
            this.comboBoxUpdateStatus.Location = new System.Drawing.Point(130, 12);
            this.comboBoxUpdateStatus.Name = "comboBoxUpdateStatus";
            this.comboBoxUpdateStatus.Size = new System.Drawing.Size(120, 25);
            this.comboBoxUpdateStatus.TabIndex = 1;

            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateStatus.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.buttonUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateStatus.Location = new System.Drawing.Point(260, 12);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(60, 28);
            this.buttonUpdateStatus.TabIndex = 2;
            this.buttonUpdateStatus.Text = "Update";
            this.buttonUpdateStatus.UseVisualStyleBackColor = false;

            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 597);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrders";
            this.Text = "ManageOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            this.panelMainContainer.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelStatusUpdate.ResumeLayout(false);
            this.panelStatusUpdate.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}