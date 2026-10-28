
using Microsoft.Data.SqlClient;
using System;

namespace AutoCareSystem
{
    public class Database
    {
        private readonly string connectionString =
            @"Server=A;Database=AutoCareDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Database connection failed: " + ex.Message);
                return false;
            }
        }
    }
}
