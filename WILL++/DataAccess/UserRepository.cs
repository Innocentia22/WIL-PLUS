using Microsoft.Data.SqlClient;

namespace WIL__
{
    public class UserRepository
    {
        private readonly DbConnection dbConnection = new DbConnection();

        public bool Login(string email, string password)
        {
            string query = @"
                SELECT COUNT(*)
                FROM Users
                WHERE Email = @Email
                AND PasswordHash = @PasswordHash
                AND IsActive = 1";

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PasswordHash", password);

                    int result = (int)command.ExecuteScalar();

                    return result > 0;
                }
            }
        }
    }
}