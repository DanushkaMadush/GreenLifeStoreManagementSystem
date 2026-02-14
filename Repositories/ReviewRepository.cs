using GreenLifeStoreManagementSystem.Data;
using GreenLifeStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeStoreManagementSystem.Repositories
{
    public class ReviewRepository
    {
        public bool AddReview(Review review)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"INSERT INTO Reviews
                                (ProductId, CustomerId, Rating, Comment, ReviewDate)
                                VALUES
                                (@ProductId, @CustomerId, @Rating, @Comment, @ReviewDate)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProductId", review.ProductId);
                cmd.Parameters.AddWithValue("@CustomerId", review.CustomerId);
                cmd.Parameters.AddWithValue("@Rating", review.Rating);
                cmd.Parameters.AddWithValue("@Comment", review.Comment);
                cmd.Parameters.AddWithValue("@ReviewDate", review.ReviewDate);

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                return rows > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public List<Review> GetReviewsByProduct(int productId)
        {
            SqlConnection con = null;
            List<Review> reviews = new List<Review>();

            try
            {
                con = DbConnection.GetConnection();

                string query = "SELECT * FROM Reviews WHERE ProductId=@ProductId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProductId", productId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Review r = new Review();
                    r.ReviewId = Convert.ToInt32(reader["ReviewId"]);
                    r.ProductId = productId;
                    r.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    r.Rating = Convert.ToInt32(reader["Rating"]);
                    r.Comment = reader["Comment"].ToString();
                    r.ReviewDate = Convert.ToDateTime(reader["ReviewDate"]);

                    reviews.Add(r);
                }
            }
            catch (Exception)
            {
                return reviews;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return reviews;
        }

        public bool HasCustomerReviewed(int productId, int customerId)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"SELECT COUNT(*) FROM Reviews
                                 WHERE ProductId=@ProductId AND CustomerId=@CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProductId", productId);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}
