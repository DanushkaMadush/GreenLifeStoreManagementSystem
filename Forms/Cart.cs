using GreenLifeStoreManagementSystem.Models;
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
    public partial class Cart : Form
    {
        private CartModel cart;

        public Cart()
        {
            InitializeComponent();
            cart = CartManager.GetCart();
            SetupGrid();
            LoadCart();
            WireEvents();
        }

        private void SetupGrid()
        {
            dataGridViewCart.AutoGenerateColumns = false;
            dataGridViewCart.Columns.Clear();

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductId",
                HeaderText = "ProductId",
                DataPropertyName = "ProductId",
                Visible = false
            });

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductName",
                HeaderText = "Product",
                DataPropertyName = "ProductName",
                Width = 200
            });

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                Width = 80
            });

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity",
                Width = 80
            });

            dataGridViewCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "SubTotal",
                HeaderText = "Subtotal",
                DataPropertyName = "SubTotal",
                Width = 100
            });
        }

        private void LoadCart()
        {
            var displayList = cart.Items.Select(i => new
            {
                ProductId = i.Product.ProductId,
                ProductName = i.Product.ProductName,
                Price = i.Product.Price,
                Quantity = i.Quantity,
                SubTotal = i.SubTotal
            }).ToList();

            dataGridViewCart.DataSource = displayList;
            labelTotalAmount.Text = $"${cart.GetTotal():F2}";
        }

        private void WireEvents()
        {
            dataGridViewCart.SelectionChanged += DataGridViewCart_SelectionChanged;
            buttonUpdateQuantity.Click += buttonUpdateQuantity_Click;
            buttonRemoveItem.Click += buttonRemoveItem_Click;
            buttonContinueShopping.Click += buttonContinueShopping_Click;
        }

        private void DataGridViewCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count == 0)
                return;

            int productId =
                Convert.ToInt32(dataGridViewCart.SelectedRows[0].Cells["ProductId"].Value);

            CartItem item =
                cart.Items.FirstOrDefault(i => i.Product.ProductId == productId);

            if (item != null)
            {
                labelSelectedItem.Text = item.Product.ProductName;
                numericUpDownQuantity.Value = item.Quantity;
            }
        }

        private void buttonUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count == 0)
                return;

            int productId =
                Convert.ToInt32(dataGridViewCart.SelectedRows[0].Cells["ProductId"].Value);

            int newQty = (int)numericUpDownQuantity.Value;

            cart.UpdateQuantity(productId, newQty);
            LoadCart();
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count == 0)
                return;

            int productId =
                Convert.ToInt32(dataGridViewCart.SelectedRows[0].Cells["ProductId"].Value);

            cart.RemoveItem(productId);
            LoadCart();
        }

        private void buttonContinueShopping_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
