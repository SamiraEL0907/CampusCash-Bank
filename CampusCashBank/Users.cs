using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CampusCashBank
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicture { get; set; }

        public Database Database { get; set; }
        public bool IsActive { get; set; }

        public Users()
        {
            Database = new Database();
        }

        public string HashPassword(string password)
        {
            // Use the bcrypt hashing algorithm to hash the password
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public int ValidateUserLogin(string email, string password)
        {
            Users user = Database.GetUserByEmail(email);
            if (user == null)
            {
                // No user with the given email exists in the database
                return -1; // user not found
            }
            else if (!user.IsActive)
            {
                // User is not active
                return 0; // user inactive
            }
            else
            {
                // Check password
                bool isValidPassword = BCrypt.Net.BCrypt.Verify(password, user.Password);
                if (isValidPassword)
                {
                    // Set the properties of this Users object to the properties of the user retrieved from the database
                    this.UserID = user.UserID;
                    this.Email = user.Email;
                    this.Password = user.Password;
                    this.FirstName = user.FirstName;
                    this.LastName = user.LastName;
                    this.ProfilePicture = user.ProfilePicture;
                    this.IsActive = user.IsActive;
                    return 1; // user active and password correct
                }
                else
                {
                    return -2; // password incorrect
                }
            }
        }




        public bool AddAccount(string accountName, decimal balance, decimal? negativeLimit)
        {
            Database db = new Database();
            return db.AddAccount(this.UserID, accountName, balance, negativeLimit);
        }

        public Account GetAccountById(int accountId)
        {
            Database db = new Database();
            return db.GetAccountById(accountId);
        }

        public List<Account> GetAccounts()
        {
            DataTable accountTable = Database.GetAccountsDataTableByUserID(this.UserID);
            List<Account> accounts = new List<Account>();
            foreach (DataRow row in accountTable.Rows)
            {
                accounts.Add(new Account(row));
            }
            return accounts;
        }

        //forgot password 

        public bool UpdateUserPassword(int userId, string newPassword)
        {
            // Hash the new password
            string hashedPassword = HashPassword(newPassword);

            // Call the Database method to update the user's password
            return Database.UpdateUserPassword(userId, hashedPassword);
        }

        //photo

        public bool UpdateUserPicture(int userId, string base64Image)
        {
            Database db = new Database();
            return db.UpdateUserPicture(userId, base64Image);
        }

        public string GetUserProfilePicture(int userId)
        {
            Database db = new Database();
            return db.GetUserProfilePicture(userId);
        }






    }
}
