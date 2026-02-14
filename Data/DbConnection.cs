using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeStoreManagementSystem.Data
{
    public class DbConnection
    {
        private static string connectionString = "Server=DANUSHKA\\SQLEXPRESS;Database=GreenLifeDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
