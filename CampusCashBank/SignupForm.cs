using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using BCrypt.Net;



namespace CampusCashBank
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Hash the password before saving it to the database for security reasons.
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

            // Create a new instance of the Database class
            Database db = new Database();

            // Add the new user to the Users table
            db.AddUser(txtFirstName.Text, txtLastName.Text, txtEmail.Text, hashedPassword, ""); // Assuming you don't have a ProfilePicture input yet

            // Optionally, display a message to confirm the user has been registered
            MessageBox.Show("User registered successfully!");

            // Close the SignupForm and return to the StartForm
            this.Close();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }


    }
}
