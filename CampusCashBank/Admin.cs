using System;
using BCrypt.Net;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace CampusCashBank
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private Database db;

        public Admin(int adminID, string email, string password)
        {
            AdminID = adminID;
            Email = email;
            Password = password;

            db = new Database();
        }

        public bool VerifyPassword(string enteredPassword)
        {
            // Since we're not hashing passwords, a simple string comparison can be used
            return Password == enteredPassword;
        }

        public static Admin Authenticate(string email, string password)
        {
            Database db = new Database();
            Admin admin = db.GetAdminByEmail(email);

            if (admin != null && admin.VerifyPassword(password))
            {
                return admin;
            }
            else
            {
                return null;
            }
        }

        public List<Users> GetAllUsers()
        {
            var dataTable = db.GetUsers();
            var userList = new List<Users>();

            foreach (DataRow row in dataTable.Rows)
            {
                var user = new Users
                {
                    UserID = Convert.ToInt32(row["UserID"]),
                    Email = Convert.ToString(row["Email"]),
                    FirstName = Convert.ToString(row["FirstName"]),
                    LastName = Convert.ToString(row["LastName"])
                };

                userList.Add(user);
            }

            return userList;
        }

        public Users GetUserById(int userId)
        {
            DataTable userTable = db.GetUserDataById(userId); // use the 'db' instance here

            if (userTable.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                var userRow = userTable.Rows[0];
                var user = new Users
                {
                    UserID = Convert.ToInt32(userRow["UserID"]),
                    Email = Convert.ToString(userRow["Email"]),
                    FirstName = Convert.ToString(userRow["FirstName"]),
                    LastName = Convert.ToString(userRow["LastName"]),
                };
                return user;
            }

           
        }

        public bool DeleteUser(int userId)
        {
            Database db = new Database(); // Create a new instance of the Database class
            return db.DeleteUser(userId);
        }
    }
}
