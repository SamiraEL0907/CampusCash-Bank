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
    public partial class PasswordResetForm : Form
    {
        public PasswordResetForm()
        {
            InitializeComponent();
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            // Get the user's inputs
            int userId = int.Parse(txtUserID.Text);
            string email = txtEmail.Text;
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmNewPassword.Text;

            // Check if the new password and confirm password match
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }

            // Check if the user exists and the email is correct
            Users user = new Users();
            Users existingUser = user.Database.GetUserByEmailAndId(email, userId);
            if (existingUser == null || existingUser.Email != email)
            {
                MessageBox.Show("User ID or Email is incorrect.");
                return;
            }

            // Update the user's password
            bool success = user.UpdateUserPassword(userId, newPassword);
            if (success)
            {
                MessageBox.Show("Password has been updated successfully.");
            }
            else
            {
                MessageBox.Show("There was an error updating the password. Please try again.");
            }
        }

    }
}
