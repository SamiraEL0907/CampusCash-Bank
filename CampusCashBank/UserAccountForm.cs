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
        private Users _user;

        public UserAccountsForm(Users user)
        {
            InitializeComponent();
            this.Load += UserAccountsForm_Load;
            this._user = user;

            // Add a double click event to the ListView
            listViewAccounts.DoubleClick += ListViewAccounts_DoubleClick;
        }

        private void UserAccountsForm_Load(object sender, EventArgs e)
        {
            List<Account> accounts = _user.GetAccounts();

            foreach (Account account in accounts)
            {
                ListViewItem item = new ListViewItem(account.AccountID.ToString());
                item.SubItems.Add(account.AccountName);
                item.SubItems.Add(account.Balance.ToString());

                listViewAccounts.Items.Add(item);
            }
        }

        private void ListViewAccounts_DoubleClick(object sender, EventArgs e)
        {
            // Get the selected item
            ListViewItem selectedItem = listViewAccounts.SelectedItems[0];

            // Parse the AccountID from the first column of the selected item
            int accountId = int.Parse(selectedItem.SubItems[0].Text);

            // Open the AdminTransactionForm for the selected account
            AdminTransactionForm adminTransactionForm = new AdminTransactionForm(accountId);
            adminTransactionForm.Show();

        }
    }
}

