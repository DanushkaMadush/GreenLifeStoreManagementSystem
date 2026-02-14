using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GreenLifeStoreManagementSystem.Models;
using GreenLifeStoreManagementSystem.Data;

namespace GreenLifeStoreManagementSystem.Repositories
{
    public class ProductRepository
    {
        public bool AddProduct(Product product)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"INSERT INTO Products
                                    (ProductName, Category, Price, Stock, Supplier, Discount)
                                    VALUES
                                    (@Name, @Category, @Price, @Stock, @Supplier, @Discount)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", product.ProductName);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Supplier", product.Supplier);
                cmd.Parameters.AddWithValue("@Discount", product.Discount);

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

        public bool UpdateProduct(Product product)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"UPDATE Products
                                    SET ProductName=@Name,
                                        Category=@Category,
                                        Price=@Price,
                                        Stock=@Stock,
                                        Supplier=@Supplier,
                                        Discount=@Discount
                                    WHERE ProductId=@Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", product.ProductName);
                cmd.Parameters.AddWithValue("@Category", product.Category);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Supplier", product.Supplier);
                cmd.Parameters.AddWithValue("@Discount", product.Discount);
                cmd.Parameters.AddWithValue("@Id", product.ProductId);

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

        public bool DeleteProduct(int productId)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = "DELETE FROM Products WHERE ProductId=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", productId);

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

        public List<Product> GetAllProducts()
        {
            SqlConnection con = null;
            List<Product> products = new List<Product>();

            try
            {
                con = DbConnection.GetConnection();

                string query = "SELECT * FROM Products";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProductName = reader["ProductName"].ToString();
                    product.Category = reader["Category"].ToString();
                    product.Price = Convert.ToDecimal(reader["Price"]);
                    product.Stock = Convert.ToInt32(reader["Stock"]);
                    product.Supplier = reader["Supplier"].ToString();
                    product.Discount = Convert.ToDecimal(reader["Discount"]);

                    products.Add(product);
                }
            }
            catch (Exception)
            {
                return products;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return products;
        }

        public List<Product> SearchProducts(string keyword)
        {
            SqlConnection con = null;
            List<Product> products = new List<Product>();

            try
            {
                con = DbConnection.GetConnection();

                string query = @"SELECT * FROM Products
                                     WHERE ProductName LIKE @Keyword";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProductName = reader["ProductName"].ToString();
                    product.Category = reader["Category"].ToString();
                    product.Price = Convert.ToDecimal(reader["Price"]);
                    product.Stock = Convert.ToInt32(reader["Stock"]);
                    product.Supplier = reader["Supplier"].ToString();
                    product.Discount = Convert.ToDecimal(reader["Discount"]);

                    products.Add(product);
                }
            }
            catch (Exception)
            {
                return products;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return products;
        }

        public Product GetProductById(int productId)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = "SELECT * FROM Products WHERE ProductId = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", productId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProductName = reader["ProductName"].ToString();
                    product.Category = reader["Category"].ToString();
                    product.Price = Convert.ToDecimal(reader["Price"]);
                    product.Stock = Convert.ToInt32(reader["Stock"]);
                    product.Supplier = reader["Supplier"].ToString();
                    product.Discount = Convert.ToDecimal(reader["Discount"]);

                    return product;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public List<Product> GetProductsByCategory(string category)
        {
            SqlConnection con = null;
            List<Product> products = new List<Product>();

            try
            {
                con = DbConnection.GetConnection();

                string query = "SELECT * FROM Products WHERE Category = @Category";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Category", category);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProductName = reader["ProductName"].ToString();
                    product.Category = reader["Category"].ToString();
                    product.Price = Convert.ToDecimal(reader["Price"]);
                    product.Stock = Convert.ToInt32(reader["Stock"]);
                    product.Supplier = reader["Supplier"].ToString();
                    product.Discount = Convert.ToDecimal(reader["Discount"]);

                    products.Add(product);
                }
            }
            catch (Exception)
            {
                return products;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return products;
        }

        public List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            SqlConnection con = null;
            List<Product> products = new List<Product>();

            try
            {
                con = DbConnection.GetConnection();

                string query = "SELECT * FROM Products WHERE Price >= @MinPrice AND Price <= @MaxPrice";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MinPrice", minPrice);
                cmd.Parameters.AddWithValue("@MaxPrice", maxPrice);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProductName = reader["ProductName"].ToString();
                    product.Category = reader["Category"].ToString();
                    product.Price = Convert.ToDecimal(reader["Price"]);
                    product.Stock = Convert.ToInt32(reader["Stock"]);
                    product.Supplier = reader["Supplier"].ToString();
                    product.Discount = Convert.ToDecimal(reader["Discount"]);

                    products.Add(product);
                }
            }
            catch (Exception)
            {
                return products;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return products;
        }

        public List<Product> GetAvailableProducts()
        {
            SqlConnection con = null;
            List<Product> products = new List<Product>();

            try
            {
                con = DbConnection.GetConnection();

                string query = "SELECT * FROM Products WHERE Stock > 0";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["ProductId"]);
                    product.ProductName = reader["ProductName"].ToString();
                    product.Category = reader["Category"].ToString();
                    product.Price = Convert.ToDecimal(reader["Price"]);
                    product.Stock = Convert.ToInt32(reader["Stock"]);
                    product.Supplier = reader["Supplier"].ToString();
                    product.Discount = Convert.ToDecimal(reader["Discount"]);

                    products.Add(product);
                }
            }
            catch (Exception)
            {
                return products;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return products;
        }
    }
}
