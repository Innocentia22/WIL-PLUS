using Microsoft.Data.SqlClient;

namespace WIL__
{
    public class DbConnection
    {
        private readonly string connectionString =
            @"Server=.\SQLEXPRESS01;Database=WILPlusDB;Trusted_Connection=True;TrustServerCertificate=True;";

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
            catch
            {
                return false;
            }
        }
    }
}