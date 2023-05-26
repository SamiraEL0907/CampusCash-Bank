using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;

namespace CampusCashBank
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public bool IsSender { get; set; }
        public int OtherPartyID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public int SenderAccountID { get; set; }  // Add this property

   


        private Database db;

        public Transaction()
        {
            db = new Database();
        }

        public Transaction(int transactionID, bool isSender, int senderAccountID, int otherPartyID, decimal amount, DateTime timestamp)
        {
            TransactionID = transactionID;
            IsSender = isSender;
            SenderAccountID = senderAccountID;
            OtherPartyID = otherPartyID;
            Amount = amount;
            Timestamp = timestamp;
        }


        public bool PerformTransaction(int senderAccountID, int receiverAccountID, decimal amount, TransferForm form)
        {
            // Make sure the sender has enough funds
            Account senderAccount = db.GetAccountById(senderAccountID);
            if (senderAccount.Balance < amount)
            {
                // Not enough funds
                return false;
            }

            // Subtract the amount from the sender's balance
            senderAccount.Balance -= amount;
            db.UpdateAccount(senderAccount);

            // Add the amount to the receiver's balance
            Account receiverAccount = db.GetAccountById(receiverAccountID);
            receiverAccount.Balance += amount;
            db.UpdateAccount(receiverAccount);

            // Add the transaction to the Transaction table
            Transaction transaction = new Transaction(0, true, senderAccountID, receiverAccountID, amount, DateTime.Now);
            db.AddTransaction(transaction);

            // Update the transaction history in the TransferForm
            form.RefreshTransactionHistory();

            return true;
        }







    }



}
