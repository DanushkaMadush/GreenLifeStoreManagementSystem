using GreenLifeStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GreenLifeStoreManagementSystem.Forms
{
    public partial class ManageProducts : Form
    {
        private List<Product> products;
        private Product selectedProduct;

        public ManageProducts()
        {
            InitializeComponent();
            LoadProducts();
            WireUpEvents();
        }

        private void LoadProducts()
        {
            products = Product.GetAllProducts();
            dataGridViewProducts.DataSource = products;
            dataGridViewProducts.AutoGenerateColumns = true;
        }

        private void WireUpEvents()
        {
            dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
            buttonAdd.Click += ButtonAdd_Click;
            buttonUpdate.Click += ButtonUpdate_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonClear.Click += ButtonClear_Click;
        }

        private void DataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                selectedProduct = dataGridViewProducts.SelectedRows[0].DataBoundItem as Product;
                if (selectedProduct != null)
                {
                    textBoxProductName.Text = selectedProduct.ProductName;
                    textBoxProductCategory.Text = selectedProduct.Category;
                    textBoxPrice.Text = selectedProduct.Price.ToString("F2");
                    textBoxStock.Text = selectedProduct.Stock.ToString();
                    textBoxSupplier.Text = selectedProduct.Supplier;
                    textBoxDiscount.Text = selectedProduct.Discount.ToString("F2");
                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product(
                textBoxProductName.Text,
                textBoxProductCategory.Text,
                decimal.TryParse(textBoxPrice.Text, out decimal price) ? price : 0,
                int.TryParse(textBoxStock.Text, out int stock) ? stock : 0,
                textBoxSupplier.Text,
                decimal.TryParse(textBoxDiscount.Text, out decimal discount) ? discount : 0
            );

            if (newProduct.Add())
            {
                MessageBox.Show("Product added successfully.");
                LoadProducts();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add product.");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Select a product to update.");
                return;
            }

            selectedProduct.ProductName = textBoxProductName.Text;
            selectedProduct.Category = textBoxProductCategory.Text;
            selectedProduct.Price = decimal.TryParse(textBoxPrice.Text, out decimal price) ? price : 0;
            selectedProduct.Stock = int.TryParse(textBoxStock.Text, out int stock) ? stock : 0;
            selectedProduct.Supplier = textBoxSupplier.Text;
            selectedProduct.Discount = decimal.TryParse(textBoxDiscount.Text, out decimal discount) ? discount : 0;

            if (selectedProduct.Update())
            {
                MessageBox.Show("Product updated successfully.");
                LoadProducts();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to update product.");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Select a product to delete.");
                return;
            }

            if (selectedProduct.Delete())
            {
                MessageBox.Show("Product deleted successfully.");
                LoadProducts();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to delete product.");
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxProductName.Clear();
            textBoxProductCategory.Clear();
            textBoxPrice.Clear();
            textBoxStock.Clear();
            textBoxSupplier.Clear();
            textBoxDiscount.Clear();
            selectedProduct = null;
        }
    }
}
