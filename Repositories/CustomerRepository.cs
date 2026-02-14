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
    public class CustomerRepository
    {
        public List<Customer> GetAllCustomers()
        {
            SqlConnection con = null;
            List<Customer> customers = new List<Customer>();

            try
            {
                con = DbConnection.GetConnection();

                string query = @"SELECT * FROM Users WHERE Role = 'Customer'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        UserId = Convert.ToInt32(reader["UserId"]),
                        FullName = reader["FullName"].ToString(),
                        Username = reader["Username"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString(),
                        Role = reader["Role"].ToString()
                    };

                    customers.Add(customer);
                }
            }
            catch (Exception)
            {
                return customers;
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return customers;
        }
    }
}
