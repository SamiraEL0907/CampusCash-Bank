using crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CampusCashBank
{
    public partial class AdminSignUp : Form
    {
        public AdminSignUp()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            Admin admin = Admin.Authenticate(email, password);

            if (admin != null)
            {
                // The admin was authenticated successfully
                AdminForm adminForm = new AdminForm(admin);
                adminForm.Show();

                // Close the sign in form
                this.Close();
            }
            else
            {
                // The admin could not be authenticated
                MessageBox.Show("The email or password is incorrect.");
            }
        }

        private void StartPage_Click(object sender, EventArgs e)
        {
            var Sartform = new StartForm();
            Sartform.Show();
            this.Hide();
        }
    }
}
