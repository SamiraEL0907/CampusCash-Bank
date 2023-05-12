using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;


namespace CampusCashBank
{
    public class Database
    {
        private string connectionString;
        private MySqlConnection connection;

        public Database()
        {
            connectionString =
                "datasource=127.0.0.1;" +
                "port=3306;" +
                "username=root;" +
                "password=root;" +
                "database=campuscashbank"; // Update the database name here
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void AddUser(string firstName, string lastName, string email, string password, string profilePicture)
        {
            OpenConnection();

            string query = "INSERT INTO Users (FirstName, LastName, Email, Password, ProfilePicture) VALUES (@FirstName, @LastName, @Email, @Password, @ProfilePicture)";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@ProfilePicture", profilePicture);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public string TestConnection()
        {
            try
            {
                OpenConnection();
                CloseConnection();
                return "Connection to the database is successful.";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public string HashPassword(string password)
        {
            // Use the bcrypt hashing algorithm to hash the password
            return BCrypt.Net.BCrypt.HashPassword(password);
        }


        public bool ValidateUser(string email, string password) 
        {
            OpenConnection();
            string query = "SELECT Password FROM Users WHERE Email = @Email";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", email);
            MySqlDataReader reader = cmd.ExecuteReader();

            bool isValidUser = false;
            if (reader.Read())
            {
                string storedPassword = reader.GetString("Password");
                // Use the BCrypt Verify method to compare the provided password with the stored password
                isValidUser = BCrypt.Net.BCrypt.Verify(password, storedPassword);
            }
            reader.Close();
            CloseConnection();
            return isValidUser;
        }




    }
}
