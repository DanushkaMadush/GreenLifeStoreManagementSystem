using System;
using System.Data;
using System.Data.SqlClient;
using GreenLifeStoreManagementSystem.Data;

namespace GreenLifeStoreManagementSystem.Repositories
{
    public class ReportsRepository
    {
        public DataTable GetSalesReport(DateTime? fromDate, DateTime? toDate)
        {
            DataTable table = new DataTable();
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"SELECT 
                                    o.OrderId,
                                    u.FullName AS CustomerName,
                                    o.OrderDate,
                                    o.TotalAmount,
                                    o.Status
                                 FROM Orders o
                                 INNER JOIN Users u ON o.CustomerId = u.UserId
                                 WHERE (@FromDate IS NULL OR o.OrderDate >= @FromDate)
                                   AND (@ToDate IS NULL OR o.OrderDate <= @ToDate)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FromDate", (object)fromDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ToDate", (object)toDate ?? DBNull.Value);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception)
            {
                return table;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return table;
        }

        public DataTable GetStockReport()
        {
            DataTable table = new DataTable();
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"SELECT 
                                    ProductName,
                                    Category,
                                    Stock,
                                    Supplier,
                                    Discount
                                 FROM Products";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception)
            {
                return table;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return table;
        }

        public DataTable GetCustomerOrderHistory(int customerId)
        {
            DataTable table = new DataTable();
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"SELECT 
                                    o.OrderId,
                                    o.OrderDate,
                                    o.TotalAmount,
                                    o.Status
                                 FROM Orders o
                                 WHERE o.CustomerId = @CustomerId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception)
            {
                return table;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return table;
        }
    }
}
