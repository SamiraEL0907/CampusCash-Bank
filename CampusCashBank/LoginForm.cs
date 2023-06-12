using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusCashBank
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            Users user = new Users();
            int loginStatus = user.ValidateUserLogin(email, password);
            switch (loginStatus)
            {
                case 1: // Login successful
                    AccountsForm accountsForm = new AccountsForm(user); // Pass the user object to the AccountsForm
                    accountsForm.Show();
                    this.Hide();
                    break;

                case -1: // User not found
                case -2: // Password incorrect
                    MessageBox.Show("Invalid email or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    break;

                case 0: // User inactive
                    MessageBox.Show("Your account is inactive. Please contact the administrator.", "Inactive User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    break;
            }
        }


        private void StartPage_Click(object sender, EventArgs e)
        {
            var Sartform = new StartForm();
            Sartform.Show();
            this.Hide();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
           
            PasswordResetForm passwordResetForm = new PasswordResetForm();
            passwordResetForm.Show();
        }
    }
}
