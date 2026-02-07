using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GreenLifeStoreManagementSystem.Data;

namespace GreenLifeStoreManagementSystem.Repositories
{
    public class DashboardRepository
    {
        public int GetTotalProducts()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Products");
        }

        public int GetTotalOrders()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Orders");
        }

        public int GetTotalCustomers()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Users WHERE Role = 'Customer'");
        }

        public int GetLowStockCount()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Products WHERE Stock < 10");
        }

        public int GetTotalPendingOrders()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Orders WHERE Status = 'Pending'");
        }

        public int GetTotalShippedOrders()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Orders WHERE Status = 'Shipped'");
        }

        public int GetTotalDeliveredOrders()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Orders WHERE Status = 'Delivered'");
        }

        public Dictionary<string, int> GetCategoryWiseProducts()
        {
            SqlConnection con = null;
            Dictionary<string, int> result = new Dictionary<string, int>();

            try
            {
                con = DbConnection.GetConnection();

                string query = @"SELECT Category, COUNT(*) AS Total
                                 FROM Products
                                 GROUP BY Category";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(
                        reader["Category"].ToString(),
                        Convert.ToInt32(reader["Total"])
                    );
                }
            }
            catch (Exception)
            {
                return result;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return result;
        }

        public int GetTotalProductReviews()
        {
            return ExecuteCountQuery("SELECT COUNT(*) FROM Reviews");
        }

        private int ExecuteCountQuery(string query)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}
