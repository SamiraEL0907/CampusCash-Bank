﻿using System;
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
            if (user.ValidateUser(email, password))
            {
                // Login successful
                AccountsForm accountsForm = new AccountsForm(user); // Pass the user object to the AccountsForm
                accountsForm.Show();
                this.Hide();
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid email or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
            }
        }


    }
}
