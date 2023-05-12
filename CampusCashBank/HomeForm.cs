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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.Show();
            this.Hide();

        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountsForm accountsForm = new AccountsForm();
            accountsForm.Show();
            this.Hide();
        }


    }
}
