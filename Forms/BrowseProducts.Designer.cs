namespace GreenLifeStoreManagementSystem.Forms
{
    partial class BrowseProducts
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label labelSearchTitle;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.DataGridView dataGridViewProducts;

        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label labelReviews;
        private System.Windows.Forms.TextBox textBoxReviews;

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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.labelSearchTitle = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();

            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();

            this.panelAction = new System.Windows.Forms.Panel();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.labelReviews = new System.Windows.Forms.Label();
            this.textBoxReviews = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.panelMainContainer.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Controls.Add(this.panelSearch);
            this.panelMainContainer.Controls.Add(this.dataGridViewProducts);
            this.panelMainContainer.Controls.Add(this.panelAction);
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1002, 597);
            this.panelMainContainer.TabIndex = 0;

            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(245, 250, 245);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Height = 80;
            this.panelSearch.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panelSearch.Controls.Add(this.labelSearchTitle);
            this.panelSearch.Controls.Add(this.labelProductName);
            this.panelSearch.Controls.Add(this.textBoxProductName);
            this.panelSearch.Controls.Add(this.labelCategory);
            this.panelSearch.Controls.Add(this.comboBoxCategory);
            this.panelSearch.Controls.Add(this.labelMinPrice);
            this.panelSearch.Controls.Add(this.textBoxMinPrice);
            this.panelSearch.Controls.Add(this.labelMaxPrice);
            this.panelSearch.Controls.Add(this.textBoxMaxPrice);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.buttonClear);

            // 
            // labelSearchTitle
            // 
            this.labelSearchTitle.AutoSize = true;
            this.labelSearchTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelSearchTitle.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.labelSearchTitle.Location = new System.Drawing.Point(20, 10);
            this.labelSearchTitle.Name = "labelSearchTitle";
            this.labelSearchTitle.Size = new System.Drawing.Size(160, 25);
            this.labelSearchTitle.TabIndex = 0;
            this.labelSearchTitle.Text = "Search Products";

            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelProductName.Location = new System.Drawing.Point(20, 45);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(99, 19);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Product Name:";

            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxProductName.Location = new System.Drawing.Point(125, 42);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(140, 25);
            this.textBoxProductName.TabIndex = 2;

            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCategory.Location = new System.Drawing.Point(280, 45);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(69, 19);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category:";

            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Location = new System.Drawing.Point(355, 42);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(130, 25);
            this.comboBoxCategory.TabIndex = 4;

            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMinPrice.Location = new System.Drawing.Point(500, 45);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(70, 19);
            this.labelMinPrice.TabIndex = 5;
            this.labelMinPrice.Text = "Min Price:";

            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxMinPrice.Location = new System.Drawing.Point(575, 42);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(60, 25);
            this.textBoxMinPrice.TabIndex = 6;

            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMaxPrice.Location = new System.Drawing.Point(650, 45);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(73, 19);
            this.labelMaxPrice.TabIndex = 7;
            this.labelMaxPrice.Text = "Max Price:";

            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxMaxPrice.Location = new System.Drawing.Point(725, 42);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(60, 25);
            this.textBoxMaxPrice.TabIndex = 8;

            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(810, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 28);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;

            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(900, 40);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 28);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;

            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(20, 100);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(700, 470);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left))));
            // Columns (add in code-behind for clarity)
            // ProductID (hidden), ProductName, Category, Price, Discount, Stock, Rating

            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.panelAction.Location = new System.Drawing.Point(740, 100);
            this.panelAction.Size = new System.Drawing.Size(240, 470);
            this.panelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelAction.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.panelAction.Controls.Add(this.labelQuantity);
            this.panelAction.Controls.Add(this.numericUpDownQuantity);
            this.panelAction.Controls.Add(this.buttonAddToCart);
            this.panelAction.Controls.Add(this.labelReviews);
            this.panelAction.Controls.Add(this.textBoxReviews);

            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelQuantity.Location = new System.Drawing.Point(20, 20);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(65, 19);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "Quantity:";

            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDownQuantity.Location = new System.Drawing.Point(100, 18);
            this.numericUpDownQuantity.Minimum = 1;
            this.numericUpDownQuantity.Maximum = 1000;
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(60, 25);
            this.numericUpDownQuantity.TabIndex = 1;
            this.numericUpDownQuantity.Value = 1;

            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToCart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonAddToCart.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.buttonAddToCart.ForeColor = System.Drawing.Color.White;
            this.buttonAddToCart.Location = new System.Drawing.Point(20, 60);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(200, 36);
            this.buttonAddToCart.TabIndex = 2;
            this.buttonAddToCart.Text = "Add To Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = false;

            // 
            // labelReviews
            // 
            this.labelReviews.AutoSize = true;
            this.labelReviews.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelReviews.Location = new System.Drawing.Point(20, 120);
            this.labelReviews.Name = "labelReviews";
            this.labelReviews.Size = new System.Drawing.Size(65, 19);
            this.labelReviews.TabIndex = 3;
            this.labelReviews.Text = "Reviews:";

            // 
            // textBoxReviews
            // 
            this.textBoxReviews.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxReviews.Location = new System.Drawing.Point(20, 145);
            this.textBoxReviews.Multiline = true;
            this.textBoxReviews.ReadOnly = true;
            this.textBoxReviews.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReviews.Size = new System.Drawing.Size(200, 300);
            this.textBoxReviews.TabIndex = 4;
            this.textBoxReviews.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // BrowseProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 597);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrowseProducts";
            this.Text = "BrowseProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.panelMainContainer.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Public methods for MainForm or controller
        public void LoadProducts()
        {
            // To be implemented in code-behind
        }

        public void FilterProducts()
        {
            // To be implemented in code-behind
        }
    }
}