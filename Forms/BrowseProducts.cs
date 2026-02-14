using GreenLifeStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GreenLifeStoreManagementSystem.Forms
{
    public partial class BrowseProducts : Form
    {
        private List<Product> currentProducts;
        private Product selectedProduct;

        public BrowseProducts()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            SetupDataGridView();
            SetupCategoryComboBox();
            WireUpEventHandlers();
            LoadProducts();
        }

        private void SetupDataGridView()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.Columns.Clear();

            // ProductId column (hidden)
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ProductId";
            idColumn.DataPropertyName = "ProductId";
            idColumn.Visible = false;
            dataGridViewProducts.Columns.Add(idColumn);

            // Product Name column
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "ProductName";
            nameColumn.HeaderText = "Product Name";
            nameColumn.DataPropertyName = "ProductName";
            nameColumn.Width = 150;
            dataGridViewProducts.Columns.Add(nameColumn);

            // Category column
            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn();
            categoryColumn.Name = "Category";
            categoryColumn.HeaderText = "Category";
            categoryColumn.DataPropertyName = "Category";
            categoryColumn.Width = 100;
            dataGridViewProducts.Columns.Add(categoryColumn);

            // Price column
            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.Name = "Price";
            priceColumn.HeaderText = "Price ($)";
            priceColumn.DataPropertyName = "Price";
            priceColumn.Width = 80;
            priceColumn.DefaultCellStyle.Format = "F2";
            dataGridViewProducts.Columns.Add(priceColumn);

            // Discount column
            DataGridViewTextBoxColumn discountColumn = new DataGridViewTextBoxColumn();
            discountColumn.Name = "Discount";
            discountColumn.HeaderText = "Discount (%)";
            discountColumn.DataPropertyName = "Discount";
            discountColumn.Width = 90;
            discountColumn.DefaultCellStyle.Format = "F1";
            dataGridViewProducts.Columns.Add(discountColumn);

            // Stock column
            DataGridViewTextBoxColumn stockColumn = new DataGridViewTextBoxColumn();
            stockColumn.Name = "Stock";
            stockColumn.HeaderText = "Stock";
            stockColumn.DataPropertyName = "Stock";
            stockColumn.Width = 70;
            dataGridViewProducts.Columns.Add(stockColumn);

            // Supplier column
            DataGridViewTextBoxColumn supplierColumn = new DataGridViewTextBoxColumn();
            supplierColumn.Name = "Supplier";
            supplierColumn.HeaderText = "Supplier";
            supplierColumn.DataPropertyName = "Supplier";
            supplierColumn.Width = 120;
            dataGridViewProducts.Columns.Add(supplierColumn);
        }

        private void SetupCategoryComboBox()
        {
            try
            {
                comboBoxCategory.Items.Clear();
                comboBoxCategory.Items.Add("All Categories");

                List<Product> allProducts = Product.GetAllProducts();
                HashSet<string> categories = new HashSet<string>();

                foreach (Product product in allProducts)
                {
                    if (!string.IsNullOrEmpty(product.Category))
                    {
                        categories.Add(product.Category);
                    }
                }

                foreach (string category in categories)
                {
                    comboBoxCategory.Items.Add(category);
                }

                comboBoxCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                comboBoxCategory.Items.Clear();
                comboBoxCategory.Items.Add("All Categories");
                comboBoxCategory.SelectedIndex = 0;
            }
        }

        private void WireUpEventHandlers()
        {
            buttonSearch.Click += ButtonSearch_Click;
            buttonClear.Click += ButtonClear_Click;
            buttonAddToCart.Click += ButtonAddToCart_Click;
            dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
            textBoxProductName.KeyPress += TextBoxProductName_KeyPress;
        }

        public void LoadProducts()
        {
            try
            {
                currentProducts = Product.GetAllProducts();
                dataGridViewProducts.DataSource = currentProducts;

                if (currentProducts.Count == 0)
                {
                    MessageBox.Show("No products found in the database.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Text = $"Browse Products - {currentProducts.Count} products loaded";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentProducts = new List<Product>();
            }
        }

        private void SearchAndFilterProducts()
        {
            try
            {
                List<Product> filteredProducts = new List<Product>();

                bool hasProductNameFilter = !string.IsNullOrWhiteSpace(textBoxProductName.Text);
                bool hasCategoryFilter = comboBoxCategory.SelectedIndex > 0;
                bool hasPriceFilter = !string.IsNullOrWhiteSpace(textBoxMinPrice.Text) ||
                                    !string.IsNullOrWhiteSpace(textBoxMaxPrice.Text);

                if (hasProductNameFilter)
                {
                    filteredProducts = Product.SearchProducts(textBoxProductName.Text.Trim());
                }
                else if (hasCategoryFilter && !hasPriceFilter)
                {
                    string selectedCategory = comboBoxCategory.SelectedItem.ToString();
                    filteredProducts = Product.GetProductsByCategory(selectedCategory);
                }
                else if (hasPriceFilter && !hasCategoryFilter && !hasProductNameFilter)
                {
                    decimal minPrice = 0;
                    decimal maxPrice = decimal.MaxValue;

                    if (!string.IsNullOrWhiteSpace(textBoxMinPrice.Text))
                    {
                        decimal.TryParse(textBoxMinPrice.Text, out minPrice);
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxMaxPrice.Text))
                    {
                        decimal.TryParse(textBoxMaxPrice.Text, out maxPrice);
                    }

                    filteredProducts = Product.GetProductsByPriceRange(minPrice, maxPrice);
                }
                else
                {
                    filteredProducts = Product.GetAllProducts();
                }

                if (hasProductNameFilter && (hasCategoryFilter || hasPriceFilter))
                {
                    if (!filteredProducts.Any() ||
                        (hasCategoryFilter || hasPriceFilter))
                    {
                        string searchTerm = textBoxProductName.Text.Trim().ToLower();
                        filteredProducts = filteredProducts.Where(p =>
                            p.ProductName.ToLower().Contains(searchTerm)).ToList();
                    }
                }

                if (hasCategoryFilter && hasProductNameFilter)
                {
                    string selectedCategory = comboBoxCategory.SelectedItem.ToString();
                    filteredProducts = filteredProducts.Where(p =>
                        p.Category.Equals(selectedCategory, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                if (hasPriceFilter && (hasProductNameFilter || hasCategoryFilter))
                {
                    decimal minPrice = 0;
                    decimal maxPrice = decimal.MaxValue;

                    if (!string.IsNullOrWhiteSpace(textBoxMinPrice.Text))
                    {
                        if (!decimal.TryParse(textBoxMinPrice.Text, out minPrice))
                        {
                            MessageBox.Show("Invalid minimum price format.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxMaxPrice.Text))
                    {
                        if (!decimal.TryParse(textBoxMaxPrice.Text, out maxPrice))
                        {
                            MessageBox.Show("Invalid maximum price format.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    if (minPrice > maxPrice)
                    {
                        MessageBox.Show("Minimum price cannot be greater than maximum price.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    filteredProducts = filteredProducts.Where(p =>
                        p.Price >= minPrice && p.Price <= maxPrice).ToList();
                }

                currentProducts = filteredProducts;
                dataGridViewProducts.DataSource = currentProducts;

                if (filteredProducts.Count == 0)
                {
                    MessageBox.Show("No products match your search criteria.", "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Text = $"Browse Products - {filteredProducts.Count} products found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FilterProducts()
        {
            SearchAndFilterProducts();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchAndFilterProducts();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxProductName.Clear();
            comboBoxCategory.SelectedIndex = 0;
            textBoxMinPrice.Clear();
            textBoxMaxPrice.Clear();
            LoadProducts();
            this.Text = "Browse Products";
        }

        private void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product to add to cart.", "No Product Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedProduct.Stock <= 0)
            {
                MessageBox.Show("This product is out of stock.", "Out of Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity = (int)numericUpDownQuantity.Value;

            if (quantity > selectedProduct.Stock)
            {
                MessageBox.Show($"Only {selectedProduct.Stock} items are available in stock.", "Insufficient Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Updating the usage of CartManager to reference the newly added static class
            CartModel cart = CartManager.GetCart();
            cart.AddItem(selectedProduct, quantity);

            decimal unitPrice = selectedProduct.Price;
            decimal totalPrice = unitPrice * quantity;
            decimal discountAmount = (selectedProduct.Discount / 100) * totalPrice;
            decimal finalPrice = totalPrice - discountAmount;

            string message = $"Product: {selectedProduct.ProductName}\n" +
                           $"Quantity: {quantity}\n" +
                           $"Unit Price: ${unitPrice:F2}\n" +
                           $"Total: ${totalPrice:F2}\n" +
                           $"Discount ({selectedProduct.Discount}%): -${discountAmount:F2}\n" +
                           $"Final Price: ${finalPrice:F2}\n\n" +
                           $"Added to cart successfully!\n" +
                           $"Cart Total: ${cart.GetTotal():F2}";

            MessageBox.Show(message, "Added to Cart",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            numericUpDownQuantity.Value = 1;
        }

        private void DataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];
                selectedProduct = selectedRow.DataBoundItem as Product;

                if (selectedProduct != null)
                {
                    numericUpDownQuantity.Maximum = Math.Max(1, selectedProduct.Stock);
                    numericUpDownQuantity.Value = 1;

                    decimal discountedPrice = selectedProduct.Price;
                    if (selectedProduct.Discount > 0)
                    {
                        discountedPrice = selectedProduct.Price - ((selectedProduct.Discount / 100) * selectedProduct.Price);
                    }

                    textBoxReviews.Text = $"Product Details:\n" +
                                        $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                                        $"Name: {selectedProduct.ProductName}\n" +
                                        $"Category: {selectedProduct.Category}\n" +
                                        $"Supplier: {selectedProduct.Supplier}\n" +
                                        $"Price: ${selectedProduct.Price:F2}\n" +
                                        $"Discount: {selectedProduct.Discount}%\n" +
                                        $"Final Price: ${discountedPrice:F2}\n" +
                                        $"Stock: {selectedProduct.Stock} units\n" +
                                        $"Status: {(selectedProduct.Stock > 0 ? "In Stock" : "Out of Stock")}\n\n" +
                                        $"Customer Reviews:\n" +
                                        $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n" +
                                        $"★★★★★ \"Excellent product quality!\"\n" +
                                        $"★★★★☆ \"Great value for money.\"\n" +
                                        $"★★★★★ \"Highly recommended!\"\n" +
                                        $"★★★☆☆ \"Good product, fast delivery.\"\n" +
                                        $"★★★★☆ \"Satisfied with purchase.\"";
                }
            }
            else
            {
                selectedProduct = null;
                textBoxReviews.Clear();
            }
        }

        private void TextBoxProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SearchAndFilterProducts();
            }
        }

        public void RefreshProducts()
        {
            LoadProducts();
        }

        public Product GetSelectedProduct()
        {
            return selectedProduct;
        }
    }
}
