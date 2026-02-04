using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GreenLifeStoreManagementSystem.Models;
using GreenLifeStoreManagementSystem.Data;

namespace GreenLifeStoreManagementSystem.Repositories
{
    public class OrderRepository
    {
        public bool SaveOrder(Order order)
        {
            SqlConnection con = null;
            SqlTransaction transaction = null;

            try
            {
                con = DbConnection.GetConnection();
                con.Open();

                transaction = con.BeginTransaction();

                string orderQuery = @"INSERT INTO Orders
                                     (CustomerId, OrderDate, Status, TotalAmount)
                                     VALUES
                                     (@CustomerId, @OrderDate, @Status, @TotalAmount);
                                     SELECT SCOPE_IDENTITY();";

                SqlCommand orderCmd = new SqlCommand(orderQuery, con, transaction);
                orderCmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                orderCmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                orderCmd.Parameters.AddWithValue("@Status", order.Status);
                orderCmd.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);

                int orderId = Convert.ToInt32(orderCmd.ExecuteScalar());

                foreach (OrderItem item in order.Items)
                {
                    string itemQuery = @"INSERT INTO OrderItems
                                         (OrderId, ProductId, ProductName, Price, Quantity, SubTotal)
                                         VALUES
                                         (@OrderId, @ProductId, @ProductName,
                                          @Price, @Quantity, @SubTotal)";

                    SqlCommand itemCmd = new SqlCommand(itemQuery, con, transaction);
                    itemCmd.Parameters.AddWithValue("@OrderId", orderId);
                    itemCmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                    itemCmd.Parameters.AddWithValue("@ProductName", item.ProductName);
                    itemCmd.Parameters.AddWithValue("@Price", item.Price);
                    itemCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                    itemCmd.Parameters.AddWithValue("@SubTotal", item.SubTotal);

                    itemCmd.ExecuteNonQuery();

                    string stockQuery = @"UPDATE Products
                                          SET Stock = Stock - @Qty
                                          WHERE ProductId = @ProductId";

                    SqlCommand stockCmd = new SqlCommand(stockQuery, con, transaction);
                    stockCmd.Parameters.AddWithValue("@Qty", item.Quantity);
                    stockCmd.Parameters.AddWithValue("@ProductId", item.ProductId);

                    stockCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                if (transaction != null)
                    transaction.Rollback();

                return false;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public List<Order> GetOrdersByCustomer(int customerId)
        {
            SqlConnection con = null;
            List<Order> orders = new List<Order>();

            try
            {
                con = DbConnection.GetConnection();

                string query = "SELECT * FROM Orders WHERE CustomerId=@CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Order order = new Order();
                    order.OrderId = Convert.ToInt32(reader["OrderId"]);
                    order.CustomerId = customerId;
                    order.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                    order.Status = reader["Status"].ToString();
                    order.TotalAmount = Convert.ToDecimal(reader["TotalAmount"]);

                    orders.Add(order);
                }
            }
            catch (Exception)
            {
                return orders;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return orders;
        }

        public List<Order> GetAllOrders()
        {
            SqlConnection con = null;
            List<Order> orders = new List<Order>();

            try
            {
                con = DbConnection.GetConnection();
                string query = "SELECT * FROM Orders";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Order order = new Order();
                    order.OrderId = Convert.ToInt32(reader["OrderId"]);
                    order.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    order.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                    order.Status = reader["Status"].ToString();
                    order.TotalAmount = Convert.ToDecimal(reader["TotalAmount"]);

                    orders.Add(order);
                }
            }
            catch (Exception)
            {
                return orders;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return orders;
        }

        public List<OrderItem> GetOrderItems(int orderId)
        {
            SqlConnection con = null;
            List<OrderItem> items = new List<OrderItem>();

            try
            {
                con = DbConnection.GetConnection();

                string query = "SELECT * FROM OrderItems WHERE OrderId=@OrderId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@OrderId", orderId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OrderItem item = new OrderItem();
                    item.OrderItemId = Convert.ToInt32(reader["OrderItemId"]);
                    item.OrderId = orderId;
                    item.ProductId = Convert.ToInt32(reader["ProductId"]);
                    item.ProductName = reader["ProductName"].ToString();
                    item.Price = Convert.ToDecimal(reader["Price"]);
                    item.Quantity = Convert.ToInt32(reader["Quantity"]);
                    item.SubTotal = Convert.ToDecimal(reader["SubTotal"]);

                    items.Add(item);
                }
            }
            catch (Exception)
            {
                return items;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return items;
        }

        public bool UpdateOrderStatus(int orderId, string status)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"UPDATE Orders
                                 SET Status=@Status
                                 WHERE OrderId=@OrderId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@OrderId", orderId);

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
    }
}
