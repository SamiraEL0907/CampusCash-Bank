using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Data;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;


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

    
        public string HashPassword(string password)
        {
            // Use the bcrypt hashing algorithm to hash the password
            return BCrypt.Net.BCrypt.HashPassword(password);
        }


        public string GetPasswordByEmail(string email)
        {
            OpenConnection();
            string query = "SELECT Password FROM Users WHERE Email = @Email";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", email);
            MySqlDataReader reader = cmd.ExecuteReader();
            string storedPassword = null;
            if (reader.Read())
            {
                storedPassword = reader.GetString("Password");
            }
            reader.Close();
            CloseConnection();
            return storedPassword;
        }

        public Users GetUserByEmail(string email)
        {
            Users user = null;
            string query = "SELECT * FROM Users WHERE Email = @Email";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Email", email);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("No user found with this email: " + email); // Debugging line
            }

            if (reader.Read())
            {
                user = new Users();
                user.UserID = reader.GetInt32(reader.GetOrdinal("UserID"));
                user.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString("Email");
                user.Password = reader.IsDBNull(reader.GetOrdinal("Password")) ? null : reader.GetString("Password");
                user.FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString("FirstName");
                user.LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString("LastName");
                user.ProfilePicture = reader.IsDBNull(reader.GetOrdinal("ProfilePicture")) ? null : reader.GetString("ProfilePicture");
                user.IsActive = reader.IsDBNull(reader.GetOrdinal("IsActive")) ? false : reader.GetBoolean("IsActive");
            }

            reader.Close();
            connection.Close();
            return user;
        }

        //Forgot password 

        public Users GetUserByEmailAndId(string email, int userId)
        {
            Users user = null;

            // Open the connection
            OpenConnection();

            // Create a query to select the user with the provided email and ID
            string query = "SELECT * FROM Users WHERE Email = @email AND UserId = @userId";

            // Create MySqlCommand
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                // Add parameters
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@userId", userId);

                // Execute the query
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check if reader has any rows
                    if (reader.Read())
                    {
                        user = new Users()
                        {
                            UserID = reader.GetInt32("UserID"),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString("Email"),
                            Password = reader.IsDBNull(reader.GetOrdinal("Password")) ? null : reader.GetString("Password"),
                            FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString("FirstName"),
                            LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString("LastName"),
                            ProfilePicture = reader.IsDBNull(reader.GetOrdinal("ProfilePicture")) ? null : reader.GetString("ProfilePicture"),
                            IsActive = reader.IsDBNull(reader.GetOrdinal("IsActive")) ? false : reader.GetBoolean("IsActive")
                        };
                    }
                }
            }

            // Close the connection
            CloseConnection();

            // Return the user
            return user;
        }




        public bool UpdateUserPassword(int userId, string hashedPassword)
        {
            // Open the connection
            OpenConnection();

            // Create a query to update the user's password
            string query = "UPDATE Users SET Password = @password WHERE UserID = @userID";

            // Create MySqlCommand
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                // Add parameters
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@userID", userId);

                // Execute the query
                cmd.ExecuteNonQuery();
            }

            // Close the connection
            CloseConnection();

            return true;
        }

        //photo uploading 

        public bool UpdateUserPicture(int userId, string base64Image)
        {
            bool result = false;

            try
            {
                this.OpenConnection();

                string query = "UPDATE Users SET ProfilePicture = @ProfilePicture WHERE UserID = @UserId";

                using (MySqlCommand cmd = new MySqlCommand(query, this.connection))
                {
                    cmd.Parameters.AddWithValue("@ProfilePicture", base64Image);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    int rowsUpdated = cmd.ExecuteNonQuery();
                    result = rowsUpdated > 0;
                }

                this.CloseConnection();
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as necessary
            }

            return result;
        }

        public string GetUserProfilePicture(int userId)
        {
            string result = null;

            try
            {
                this.OpenConnection();

                string query = "SELECT ProfilePicture FROM Users WHERE UserID = @UserId";

                using (MySqlCommand cmd = new MySqlCommand(query, this.connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    object queryResult = cmd.ExecuteScalar();

                    if (queryResult != DBNull.Value)
                    {
                        result = (string)queryResult;
                    }
                }

                this.CloseConnection();
            }
            catch (Exception ex)
            {
               
            }

            return result;
        }


        //Account class

        public List<Account> GetAccountsByUserID(int userID)
    {
        List<Account> accounts = new List<Account>();
        string query = "SELECT * FROM Accounts WHERE UserID = @UserID";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@UserID", userID);
        connection.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Account account = new Account();
                account.AccountID = reader.GetInt32(reader.GetOrdinal("AccountID"));
                account.UserID = reader.GetInt32(reader.GetOrdinal("UserID"));
                account.AccountName = reader.GetString(reader.GetOrdinal("AccountName"));
                account.Balance = reader.GetDecimal(reader.GetOrdinal("Balance"));
                if (!reader.IsDBNull(reader.GetOrdinal("NegativeLimit")))
                {
                    account.NegativeLimit = reader.GetDecimal(reader.GetOrdinal("NegativeLimit"));
                }
                accounts.Add(account);
            }

            reader.Close();
            connection.Close();

            return accounts;
        }

        public bool AddAccount(int userId, string accountName, decimal balance, decimal? negativeLimit)
        {
            string query = "INSERT INTO Accounts (UserID, AccountName, Balance, NegativeLimit) VALUES (@UserID, @AccountName, @Balance, @NegativeLimit)";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@AccountName", accountName);
            cmd.Parameters.AddWithValue("@Balance", balance);
            if (negativeLimit.HasValue)
            {
                cmd.Parameters.AddWithValue("@NegativeLimit", negativeLimit.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@NegativeLimit", DBNull.Value);
            }

            connection.Open();

            int rowsAffected = cmd.ExecuteNonQuery();

            connection.Close();

            return rowsAffected > 0;
        }

        // this is for Accountsclass 

        public Account GetAccountById(int accountId)
        {
            Account account = null;

            string query = "SELECT * FROM Accounts WHERE AccountID = @AccountID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@AccountID", accountId);

            connection.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                account = new Account();
                account.AccountID = reader.GetInt32(reader.GetOrdinal("AccountID"));
                account.UserID = reader.GetInt32(reader.GetOrdinal("UserID"));
                account.AccountName = reader.GetString(reader.GetOrdinal("AccountName"));
                account.Balance = reader.GetDecimal(reader.GetOrdinal("Balance"));
                if (!reader.IsDBNull(reader.GetOrdinal("NegativeLimit")))
                {
                    account.NegativeLimit = reader.GetDecimal(reader.GetOrdinal("NegativeLimit"));
                }
            }

            reader.Close();
            connection.Close();

            return account;
        }

        public List<Transaction> GetTransactionHistory(int accountId)
        {
            List<Transaction> transactions = new List<Transaction>();

            OpenConnection();

            string query = "SELECT * FROM Transactions WHERE SenderAccountID = @accountId OR ReceiverAccountID = @accountId";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@accountId", accountId);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                bool isSender = reader.GetInt32(reader.GetOrdinal("SenderAccountID")) == accountId;

                Transaction transaction = new Transaction(
                    reader.GetInt32(reader.GetOrdinal("TransactionID")),
                    isSender,
                    reader.GetInt32(reader.GetOrdinal("SenderAccountID")),
                    isSender ? reader.GetInt32(reader.GetOrdinal("ReceiverAccountID")) : reader.GetInt32(reader.GetOrdinal("SenderAccountID")),
                    reader.GetDecimal(reader.GetOrdinal("Amount")),
                    reader.GetDateTime(reader.GetOrdinal("Timestamp"))
                );

                transactions.Add(transaction);
            }

            reader.Close();
            CloseConnection();

            return transactions;
        }


        public bool UpdateAccount(Account account)
        {
            try
            {
                OpenConnection();

                string query = "UPDATE Accounts SET Balance = @Balance WHERE AccountID = @AccountID";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@AccountID", account.AccountID);
                cmd.Parameters.AddWithValue("@Balance", account.Balance);

                int rowsAffected = cmd.ExecuteNonQuery();

                CloseConnection();

                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                // Handle the exception
                CloseConnection();
                return false;
            }
        }

        public bool AddTransaction(Transaction transaction)
        {
            try
            {
                OpenConnection();

                string query = "INSERT INTO Transactions (SenderAccountID, ReceiverAccountID, Amount, Timestamp) VALUES (@SenderAccountID, @ReceiverAccountID, @Amount, @Timestamp)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SenderAccountID", transaction.SenderAccountID);
                cmd.Parameters.AddWithValue("@ReceiverAccountID", transaction.OtherPartyID);
                cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                cmd.Parameters.AddWithValue("@Timestamp", transaction.Timestamp);

                int rowsAffected = cmd.ExecuteNonQuery();

                CloseConnection();

                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                // Log the exception message to the debug console
                System.Diagnostics.Debug.WriteLine(e.Message);
                CloseConnection();
                return false;
            }

        }

        //this is for the admin 

        public Admin GetAdminByEmail(string email)
        {
            try
            {
                OpenConnection();

                string query = "SELECT * FROM Admins WHERE Email = @Email";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Email", email);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Admin admin = new Admin(
                        reader.GetInt32(reader.GetOrdinal("AdminID")),
                        reader.GetString(reader.GetOrdinal("Email")),
                        reader.GetString(reader.GetOrdinal("Password"))
                    );

                    reader.Close();
                    CloseConnection();

                    return admin;
                }
                else
                {
                    reader.Close();
                    CloseConnection();

                    return null;
                }
            }
            catch (Exception e)
            {
                // Handle the exception
                CloseConnection();
                return null;
            }
        }


        public DataTable GetUsers()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT UserID, Email, FirstName, LastName FROM Users";

            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();
            return dataTable;
        }

        public DataTable GetAccountsDataTableByUserID(int userID)
        {
            string query = "SELECT * FROM Accounts WHERE UserID = @userID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@userID", userID);

            connection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();

            return dataTable;
        }

        public DataTable GetUserDataById(int userId)
        {
            string query = "SELECT * FROM Users WHERE UserID = @userID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@userID", userId);

            connection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();

            return dataTable;
        }

        public bool DeleteUser(int userId)
        {
            string query = "UPDATE Users SET IsActive = 0 WHERE UserID = @userID";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@userID", userId);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowsAffected > 0;
        }


        public bool AddUser(Users user)
        {
            // Hash the password before storing it
            string hashedPassword = user.HashPassword(user.Password);

            string query = "INSERT INTO Users (FirstName, LastName, Email, Password, IsActive) VALUES (@FirstName, @LastName, @Email, @Password, @IsActive)";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
            cmd.Parameters.AddWithValue("@LastName", user.LastName);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", hashedPassword);
            cmd.Parameters.AddWithValue("@IsActive", true);

            connection.Open();

            int rowsAffected = cmd.ExecuteNonQuery();

            connection.Close();

            return rowsAffected > 0;
        }












    }
}
