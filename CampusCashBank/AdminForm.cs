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
        private Database db;
        private Admin _admin;

        public AdminForm()
        {
            InitializeComponent();
            db = new Database();
            dataGridViewUsers.CellDoubleClick += dataGridViewUsers_CellDoubleClick;
        }

        public AdminForm(Admin admin) : this() // Call parameterless constructor for shared initialization
        {
            _admin = admin;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = db.GetUsers();
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Getting the UserID of the clicked row
                int userID = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["UserID"].Value);

                // Creating and showing the UserAccountsForm
                UserAccountsForm userAccountsForm = new UserAccountsForm(userID);
                userAccountsForm.Show();
            }
        }

    }
}
