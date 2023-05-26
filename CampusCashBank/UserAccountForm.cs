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
    public partial class UserAccountsForm : Form
    {
        private Database db;
        private int userID;

        public UserAccountsForm(int userID)
        {
            InitializeComponent();
            db = new Database();
            this.userID = userID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = db.GetAccountsDataTableByUserID(this.userID);
        }
    }
}
