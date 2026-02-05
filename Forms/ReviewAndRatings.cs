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
    public partial class ReviewAndRatings : Form
    {
        public ReviewAndRatings()
        {
            InitializeComponent();
            LoadProducts();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dataGridViewReviews.AutoGenerateColumns = false;
            dataGridViewReviews.Columns.Clear();

            dataGridViewReviews.Columns.Add("Rating", "Rating");
            dataGridViewReviews.Columns.Add("Comment", "Comment");
            dataGridViewReviews.Columns.Add("ReviewDate", "Date");
        }

        private void LoadProducts()
        {
            List<Product> products = Product.GetAllProducts();

            comboBoxProduct.DataSource = products;
            comboBoxProduct.DisplayMember = "ProductName";
            comboBoxProduct.ValueMember = "ProductId";

            comboBoxProduct.SelectedIndexChanged += ComboBoxProduct_SelectedIndexChanged;
        }

        private void ComboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedValue != null)
            {
                int productId = Convert.ToInt32(comboBoxProduct.SelectedValue);
                LoadReviews(productId);
            }
        }

        private void LoadReviews(int productId)
        {
            List<Review> reviews = Review.GetReviewsByProduct(productId);

            dataGridViewReviews.Rows.Clear();

            foreach (Review r in reviews)
            {
                dataGridViewReviews.Rows.Add(
                    r.Rating,
                    r.Comment,
                    r.ReviewDate.ToShortDateString()
                );
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedValue == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxComment.Text))
            {
                MessageBox.Show("Please enter a comment.");
                return;
            }

            int productId = Convert.ToInt32(comboBoxProduct.SelectedValue);

            // TEMP: hardcoded customer (replace later with logged user)
            int customerId = 1;

            if (Review.HasCustomerReviewed(productId, customerId))
            {
                MessageBox.Show("You have already reviewed this product.");
                return;
            }

            Review review = new Review()
            {
                ProductId = productId,
                CustomerId = customerId,
                Rating = (int)numericUpDownRating.Value,
                Comment = textBoxComment.Text
            };

            bool success = review.AddReview();

            if (success)
            {
                MessageBox.Show("Review submitted!");
                ClearForm();
                LoadReviews(productId);
            }
            else
            {
                MessageBox.Show("Failed to submit review.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            numericUpDownRating.Value = 5;
            textBoxComment.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedValue != null)
            {
                int productId = Convert.ToInt32(comboBoxProduct.SelectedValue);
                LoadReviews(productId);
            }
        }
    }
}
