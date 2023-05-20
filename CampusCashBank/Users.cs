using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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

        public Users()
        {
            Database = new Database();
        }

        public string HashPassword(string password)
        {
            // Use the bcrypt hashing algorithm to hash the password
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool ValidateUser(string email, string password)
        {
            Users user = Database.GetUserByEmail(email);
            if (user == null)
            {
                // No user with the given email exists in the database
                return false;
            }
            else
            {
                // Use the BCrypt Verify method to compare the provided password with the stored password
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
                }
                return isValidPassword;
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

    }
}
