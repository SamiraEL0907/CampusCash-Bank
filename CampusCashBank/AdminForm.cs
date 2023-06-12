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
    public partial class AdminForm : Form
    {
        private Admin _admin;

        public AdminForm()
        {
            InitializeComponent();
            this.Load += AdminForm_Load;
            listViewUsers.DoubleClick += listViewUsers_DoubleClick;
        }

        public AdminForm(Admin admin) : this() // Call parameterless constructor for shared initialization
        {
            _admin = admin;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            List<Users> users = _admin.GetAllUsers();

            foreach (Users user in users)
            {
                ListViewItem item = new ListViewItem(user.UserID.ToString());
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.FirstName);
                item.SubItems.Add(user.LastName);

                listViewUsers.Items.Add(item);
            }
        }

        private void listViewUsers_DoubleClick(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewUsers.SelectedItems[0];
                int userID = Convert.ToInt32(item.SubItems[0].Text);

                // Get the selected user
                Users user = _admin.GetUserById(userID);

                // Creating and showing the UserAccountsForm
                UserAccountsForm userAccountsForm = new UserAccountsForm(user);
                userAccountsForm.Show();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewUsers.SelectedItems[0];
                int userId = Convert.ToInt32(selectedItem.SubItems[0].Text);

                bool success = _admin.DeleteUser(userId);

                if (success)
                {
                    // Refresh the list of users
                    LoadUsers();
                }
                else
                {
                    // Show an error message
                    MessageBox.Show("Failed to delete user");
                }
            }
        }

        private void LoadUsers()
        {
            listViewUsers.Items.Clear();
            List<Users> users = _admin.GetAllUsers();

            foreach (Users user in users)
            {
                ListViewItem item = new ListViewItem(user.UserID.ToString());
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.FirstName);
                item.SubItems.Add(user.LastName);

                listViewUsers.Items.Add(item);
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var Adminform = new AdminSignUp();
            Adminform.Show();
            this.Hide();
        }
    }
}
