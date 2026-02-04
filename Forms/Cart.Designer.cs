namespace GreenLifeStoreManagementSystem.Forms
{
    partial class Cart
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Label labelSelectedItem;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonUpdateQuantity;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label labelTotalText;
        public System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Button buttonContinueShopping;

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
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.panelAction = new System.Windows.Forms.Panel();
            this.labelSelectedItem = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonUpdateQuantity = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.buttonContinueShopping = new System.Windows.Forms.Button();
            this.panelMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.panelAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Controls.Add(this.labelTitle);
            this.panelMainContainer.Controls.Add(this.dataGridViewCart);
            this.panelMainContainer.Controls.Add(this.panelAction);
            this.panelMainContainer.Controls.Add(this.panelSummary);
            this.panelMainContainer.Controls.Add(this.buttonPlaceOrder);
            this.panelMainContainer.Controls.Add(this.buttonContinueShopping);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1002, 597);
            this.panelMainContainer.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(202, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Shopping Cart";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToDeleteRows = false;
            this.dataGridViewCart.AllowUserToResizeRows = false;
            this.dataGridViewCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(37, 60);
            this.dataGridViewCart.MultiSelect = false;
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.RowHeadersVisible = false;
            this.dataGridViewCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCart.Size = new System.Drawing.Size(600, 350);
            this.dataGridViewCart.TabIndex = 1;
            // 
            // panelAction
            // 
            this.panelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.panelAction.Controls.Add(this.labelSelectedItem);
            this.panelAction.Controls.Add(this.numericUpDownQuantity);
            this.panelAction.Controls.Add(this.buttonUpdateQuantity);
            this.panelAction.Controls.Add(this.buttonRemoveItem);
            this.panelAction.Location = new System.Drawing.Point(650, 70);
            this.panelAction.Name = "panelAction";
            this.panelAction.Padding = new System.Windows.Forms.Padding(20);
            this.panelAction.Size = new System.Drawing.Size(320, 200);
            this.panelAction.TabIndex = 2;
            // 
            // labelSelectedItem
            // 
            this.labelSelectedItem.AutoSize = true;
            this.labelSelectedItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelSelectedItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelSelectedItem.Location = new System.Drawing.Point(20, 20);
            this.labelSelectedItem.Name = "labelSelectedItem";
            this.labelSelectedItem.Size = new System.Drawing.Size(114, 21);
            this.labelSelectedItem.TabIndex = 0;
            this.labelSelectedItem.Text = "Selected Item";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDownQuantity.Location = new System.Drawing.Point(24, 60);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(80, 25);
            this.numericUpDownQuantity.TabIndex = 1;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonUpdateQuantity
            // 
            this.buttonUpdateQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.buttonUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateQuantity.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateQuantity.Location = new System.Drawing.Point(120, 58);
            this.buttonUpdateQuantity.Name = "buttonUpdateQuantity";
            this.buttonUpdateQuantity.Size = new System.Drawing.Size(160, 28);
            this.buttonUpdateQuantity.TabIndex = 2;
            this.buttonUpdateQuantity.Text = "Update Quantity";
            this.buttonUpdateQuantity.UseVisualStyleBackColor = false;
            this.buttonUpdateQuantity.Click += new System.EventHandler(this.buttonUpdateQuantity_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.BackColor = System.Drawing.Color.LightGray;
            this.buttonRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveItem.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveItem.Location = new System.Drawing.Point(24, 110);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(256, 28);
            this.buttonRemoveItem.TabIndex = 3;
            this.buttonRemoveItem.Text = "Remove Item";
            this.buttonRemoveItem.UseVisualStyleBackColor = false;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // panelSummary
            // 
            this.panelSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelSummary.Controls.Add(this.labelTotalText);
            this.panelSummary.Controls.Add(this.labelTotalAmount);
            this.panelSummary.Location = new System.Drawing.Point(650, 290);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Padding = new System.Windows.Forms.Padding(20);
            this.panelSummary.Size = new System.Drawing.Size(320, 80);
            this.panelSummary.TabIndex = 3;
            // 
            // labelTotalText
            // 
            this.labelTotalText.AutoSize = true;
            this.labelTotalText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelTotalText.Location = new System.Drawing.Point(20, 20);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(118, 21);
            this.labelTotalText.TabIndex = 0;
            this.labelTotalText.Text = "Total Amount:";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelTotalAmount.Location = new System.Drawing.Point(160, 12);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(49, 37);
            this.labelTotalAmount.TabIndex = 1;
            this.labelTotalAmount.Text = "$0";
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.buttonPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.buttonPlaceOrder.Location = new System.Drawing.Point(650, 400);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(320, 40);
            this.buttonPlaceOrder.TabIndex = 4;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = false;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // buttonContinueShopping
            // 
            this.buttonContinueShopping.BackColor = System.Drawing.Color.LightGray;
            this.buttonContinueShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinueShopping.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonContinueShopping.ForeColor = System.Drawing.Color.Black;
            this.buttonContinueShopping.Location = new System.Drawing.Point(650, 460);
            this.buttonContinueShopping.Name = "buttonContinueShopping";
            this.buttonContinueShopping.Size = new System.Drawing.Size(320, 40);
            this.buttonContinueShopping.TabIndex = 5;
            this.buttonContinueShopping.Text = "Continue Shopping";
            this.buttonContinueShopping.UseVisualStyleBackColor = false;
            this.buttonContinueShopping.Click += new System.EventHandler(this.buttonContinueShopping_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 597);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.Text = "Cart";
            this.panelMainContainer.ResumeLayout(false);
            this.panelMainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.panelSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}