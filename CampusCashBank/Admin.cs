using System;
using BCrypt.Net;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
    }
}
