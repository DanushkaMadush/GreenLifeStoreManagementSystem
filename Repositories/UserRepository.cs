using GreenLifeStoreManagementSystem.Models;
using System.Data.SqlClient;
using GreenLifeStoreManagementSystem.Data;
using System;
using System.Security.Cryptography;
using System.Text;

namespace GreenLifeStoreManagementSystem.Repositories
{
    public class UserRepository
    {
        public bool Register(User user)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"INSERT INTO Users
                                        (FullName, Username, Password, Email, Phone, Address, Role)
                                        VALUES
                                        (@FullName, @Username, @Password, @Email, @Phone, @Address, @Role)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", HashPassword(user.Password));
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Phone", user.Phone);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@Role", user.Role);

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

        public User Login(string username, string password)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"SELECT * FROM Users
                                         WHERE Username=@Username AND Password=@Password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", HashPassword(password));

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    User user = new User();
                    user.UserId = Convert.ToInt32(reader["UserId"]);
                    user.FullName = reader["FullName"].ToString();
                    user.Username = reader["Username"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.Phone = reader["Phone"].ToString();
                    user.Address = reader["Address"].ToString();
                    user.Role = reader["Role"].ToString();

                    return user;
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

        public User GetUserById(int userId)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = @"SELECT * FROM Users WHERE UserId = @UserId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", userId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    User user = new User();
                    user.UserId = Convert.ToInt32(reader["UserId"]);
                    user.FullName = reader["FullName"].ToString();
                    user.Username = reader["Username"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.Phone = reader["Phone"].ToString();
                    user.Address = reader["Address"].ToString();
                    user.Role = reader["Role"].ToString();

                    return user;
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

        public bool UpdateUser(User user)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query;
                SqlCommand cmd;

                if (string.IsNullOrEmpty(user.Password))
                {
                    query = @"UPDATE Users
                             SET FullName = @FullName,
                                 Email = @Email,
                                 Phone = @Phone,
                                 Address = @Address
                             WHERE UserId = @UserId";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@Address", user.Address);
                    cmd.Parameters.AddWithValue("@UserId", user.UserId);
                }
                else
                {
                    query = @"UPDATE Users
                             SET FullName = @FullName,
                                 Email = @Email,
                                 Phone = @Phone,
                                 Address = @Address,
                                 Password = @Password
                             WHERE UserId = @UserId";

                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@Address", user.Address);
                    cmd.Parameters.AddWithValue("@Password", HashPassword(user.Password));
                    cmd.Parameters.AddWithValue("@UserId", user.UserId);
                }

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

        public bool UserNameExists(string username)
        {
            SqlConnection con = null;

            try
            {
                con = DbConnection.GetConnection();

                string query = "SELECT COUNT(*) FROM Users WHERE Username=@Username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);

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

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}