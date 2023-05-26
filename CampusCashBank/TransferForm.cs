using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class TransferForm : Form
    {

        private int _accountId;
        private Account _currentAccount;
        private Users _user; // Add this line

        public TransferForm(Users user, int accountId) // Modify the constructor to accept a Users object
        {
            InitializeComponent();

            _accountId = accountId;
            _user = user; // Initialize the _user field

            // Use the _user field to get the account
            _currentAccount = _user.GetAccountById(accountId);

            this.Load += TransferForm_Load;
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            List<Transaction> transactionHistory = _currentAccount.GetTransactionHistory();

            // Clear the DataGridView
            dgvTransactionHistory.Rows.Clear();

            // For each transaction in the history, add a new row to the DataGridView
            foreach (Transaction transaction in transactionHistory)
            {
                int index = dgvTransactionHistory.Rows.Add();
                DataGridViewRow row = dgvTransactionHistory.Rows[index];

                row.Cells["TransactionID"].Value = transaction.TransactionID;
                row.Cells["OtherPartyID"].Value = transaction.OtherPartyID;
                row.Cells["Sent"].Value = transaction.IsSender ? transaction.Amount : (decimal?)null;
                row.Cells["Received"].Value = !transaction.IsSender ? transaction.Amount : (decimal?)null;
                row.Cells["Timestamp"].Value = transaction.Timestamp;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            // Parse the receiver account ID and the amount from the text boxes
            int receiverAccountId = int.Parse(txtReceiverAccountId.Text);
            decimal amount = decimal.Parse(txtAmount.Text);

            // Create a new transaction and perform it
            Transaction transaction = new Transaction();
            bool success = transaction.PerformTransaction(_accountId, receiverAccountId, amount, this);



            if (success)
            {
                // The transaction was successful, reload the transaction history
                LoadTransactionHistory();

                // Display success message
                MessageBox.Show("Transaction completed successfully!");

                // Update the accounts list in the AccountsForm
                ((AccountsForm)this.Owner).RefreshAccounts();
            }
            else
            {
                // The transaction failed (e.g., not enough funds), show an error message
                MessageBox.Show("The transaction could not be completed.");
            }
        }

        public void RefreshTransactionHistory()
        {
            LoadTransactionHistory();
        }

        
    }
}
