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
    public partial class AccountsForm : Form
    {


        private Users _currentUser;

        public AccountsForm(Users currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;

            // Add event handler for ItemActivate event
            lvUserAccounts.ItemActivate += new EventHandler(lvUserAccounts_ItemActivate);
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void LoadAccounts()
        {
            Database db = new Database();
            List<Account> accounts = db.GetAccountsByUserID(_currentUser.UserID);

            // Clear the ListView
            lvUserAccounts.Items.Clear();

            foreach (Account account in accounts)
            {
                ListViewItem newAccount = new ListViewItem(account.AccountName + " - " + account.Balance);
                newAccount.Tag = account.AccountID;
                lvUserAccounts.Items.Add(newAccount);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text;
            decimal balance = decimal.Parse(txtBalance.Text);
            decimal? negativeLimit = string.IsNullOrEmpty(txtNegativeLimit.Text) ? (decimal?)null : decimal.Parse(txtNegativeLimit.Text);

            if (_currentUser.AddAccount(accountName, balance, negativeLimit))
            {
                // Account added successfully, reload the accounts
                LoadAccounts();
            }
            else
            {
                // Failed to add account, show an error message
                MessageBox.Show("Failed to add account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvUserAccounts_ItemActivate(object sender, EventArgs e)
        {
            // Get the selected account
            ListViewItem selectedItem = lvUserAccounts.SelectedItems[0];
            int accountId = (int)selectedItem.Tag;  // Assuming the Tag property contains the account ID

            // Open the TransferForm for the selected account
            TransferForm transferForm = new TransferForm(_currentUser, accountId);

            // Set the Owner property of the TransferForm to this form
            transferForm.Owner = this;

            transferForm.Show();
        }

        private void lvUserAccounts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView.SelectedItems[0];
                int accountId = (int)selectedItem.Tag;

                TransferForm transferForm = new TransferForm(_currentUser, accountId);

                // Set the Owner property of the TransferForm to this form
                transferForm.Owner = this;

                transferForm.Show();
            }
        }

        public void RefreshAccounts()
        {
            LoadAccounts();
        }
        private void BtnEditSettings_Click(object sender, EventArgs e)
        {
            // Get the ID of the currently logged-in user.
            int userId = this._currentUser.UserID;

            // Pass the user ID to the SettingsForm constructor.
            SettingsForm settingsForm = new SettingsForm(userId);

            settingsForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var Sartform = new StartForm();
            Sartform.Show();
            this.Hide();
        }
    }
}
