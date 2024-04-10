/*
namespace StoryHub
{
    class DatabaseManager
    {
        // Database connection string (replace with your actual connection string)
        private string connectionString = "Data Source=localhost;Initial Catalog=StoryHubDB;Integrated Security=True;";

        // Constructor
        public DatabaseManager()
        {
            // Additional initialization if needed
        }

        // Method to store user accounts in the database
        public void StoreUserAccount(string username, string password, string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // Execute SQL commands to store user account data in the database
                    string sqlQuery = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.ExecuteNonQuery();

                    // Close the database connection
                    connection.Close();
                }

                Console.WriteLine($"User account stored: {username}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error storing user account: {ex.Message}");
            }
        }

        // Method to retrieve user accounts from the database
        public string RetrieveUserAccounts()
        {
            string retrievedUserAccounts = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // Execute SQL commands to retrieve user account data from the database
                    string sqlQuery = "SELECT Username, Email FROM Users";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Process the retrieved user account data
                    while (reader.Read())
                    {
                        string username = reader["Username"].ToString();
                        string email = reader["Email"].ToString();
                        retrievedUserAccounts += $"Username: {username}, Email: {email}\n";
                    }

                    // Close the database connection
                    connection.Close();
                }

                Console.WriteLine("User accounts retrieved");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving user accounts: {ex.Message}");
            }

            return retrievedUserAccounts;
        }
    }
}
*/
