using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Data;
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
            if (reader.Read())
            {
                user = new Users();
                user.UserID = reader.GetInt32(reader.GetOrdinal("UserID"));
                user.Email = reader.GetString(reader.GetOrdinal("Email"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
                user.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                user.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                user.ProfilePicture = reader.GetString(reader.GetOrdinal("ProfilePicture"));
            }
            reader.Close();
            connection.Close();
            return user;
        }


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
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT * FROM Account WHERE UserID = @userID";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@userID", userID);

            connection.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();
            return dataTable;
        }








    }
}
