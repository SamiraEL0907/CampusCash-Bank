using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampusCashBank
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public bool IsSender { get; set; }
        public int OtherPartyID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }

        public Transaction(int transactionID, bool isSender, int otherPartyID, decimal amount, DateTime timestamp)
        {
            TransactionID = transactionID;
            IsSender = isSender;
            OtherPartyID = otherPartyID;
            Amount = amount;
            Timestamp = timestamp;
        }
    }

}
