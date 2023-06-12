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
    public partial class AdminTransactionForm : Form
    {
        private int _accountId;
        private Database _database;

        public AdminTransactionForm(int accountId)
        {
            InitializeComponent();

            _accountId = accountId;
            _database = new Database();

            this.Load += AdminTransactionForm_Load;
        }

        private void AdminTransactionForm_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            List<Transaction> transactionHistory = _database.GetTransactionHistory(_accountId);

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
    }
}
