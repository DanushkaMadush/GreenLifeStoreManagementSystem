namespace GreenLifeStoreManagementSystem.Forms
{
    partial class ManageProducts
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.DataGridView dataGridViewProducts;

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
            this.panelForm = new System.Windows.Forms.Panel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelList = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.textBoxProductCategory = new System.Windows.Forms.TextBox();
            this.panelMainContainer.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.Color.White;
            this.panelMainContainer.Controls.Add(this.labelTitle);
            this.panelMainContainer.Controls.Add(this.panelForm);
            this.panelMainContainer.Controls.Add(this.panelList);
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 0);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(800, 450);
            this.panelMainContainer.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(215, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Manage Products";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(245)))));
            this.panelForm.Controls.Add(this.textBoxProductCategory);
            this.panelForm.Controls.Add(this.labelProductName);
            this.panelForm.Controls.Add(this.textBoxProductName);
            this.panelForm.Controls.Add(this.labelCategory);
            this.panelForm.Controls.Add(this.labelPrice);
            this.panelForm.Controls.Add(this.textBoxPrice);
            this.panelForm.Controls.Add(this.labelStock);
            this.panelForm.Controls.Add(this.textBoxStock);
            this.panelForm.Controls.Add(this.labelSupplier);
            this.panelForm.Controls.Add(this.textBoxSupplier);
            this.panelForm.Controls.Add(this.labelDiscount);
            this.panelForm.Controls.Add(this.textBoxDiscount);
            this.panelForm.Controls.Add(this.buttonAdd);
            this.panelForm.Controls.Add(this.buttonUpdate);
            this.panelForm.Controls.Add(this.buttonDelete);
            this.panelForm.Controls.Add(this.buttonClear);
            this.panelForm.Location = new System.Drawing.Point(30, 70);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);
            this.panelForm.Size = new System.Drawing.Size(300, 350);
            this.panelForm.TabIndex = 1;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelProductName.Location = new System.Drawing.Point(20, 20);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(100, 19);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product Name:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxProductName.Location = new System.Drawing.Point(130, 17);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(140, 25);
            this.textBoxProductName.TabIndex = 1;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCategory.Location = new System.Drawing.Point(20, 55);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(68, 19);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPrice.Location = new System.Drawing.Point(20, 90);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 19);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPrice.Location = new System.Drawing.Point(130, 87);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(140, 25);
            this.textBoxPrice.TabIndex = 5;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelStock.Location = new System.Drawing.Point(20, 125);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(103, 19);
            this.labelStock.TabIndex = 6;
            this.labelStock.Text = "Stock Quantity:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxStock.Location = new System.Drawing.Point(130, 122);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(140, 25);
            this.textBoxStock.TabIndex = 7;
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSupplier.Location = new System.Drawing.Point(20, 160);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(61, 19);
            this.labelSupplier.TabIndex = 8;
            this.labelSupplier.Text = "Supplier:";
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSupplier.Location = new System.Drawing.Point(130, 157);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(140, 25);
            this.textBoxSupplier.TabIndex = 9;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDiscount.Location = new System.Drawing.Point(20, 195);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(66, 19);
            this.labelDiscount.TabIndex = 10;
            this.labelDiscount.Text = "Discount:";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxDiscount.Location = new System.Drawing.Point(130, 192);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(140, 25);
            this.textBoxDiscount.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(20, 240);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 32);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add Product";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(150, 240);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 32);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update Product";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(20, 285);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 32);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete Product";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(150, 285);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 32);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear Fields";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // panelList
            // 
            this.panelList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelList.BackColor = System.Drawing.Color.White;
            this.panelList.Controls.Add(this.dataGridViewProducts);
            this.panelList.Location = new System.Drawing.Point(328, 70);
            this.panelList.Name = "panelList";
            this.panelList.Padding = new System.Windows.Forms.Padding(10);
            this.panelList.Size = new System.Drawing.Size(469, 350);
            this.panelList.TabIndex = 2;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(459, 330);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // textBoxProductCategory
            // 
            this.textBoxProductCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxProductCategory.Location = new System.Drawing.Point(130, 56);
            this.textBoxProductCategory.Name = "textBoxProductCategory";
            this.textBoxProductCategory.Size = new System.Drawing.Size(140, 25);
            this.textBoxProductCategory.TabIndex = 16;
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.Text = "ManageProducts";
            this.panelMainContainer.ResumeLayout(false);
            this.panelMainContainer.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductCategory;
    }
}