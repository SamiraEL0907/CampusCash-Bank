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
        [Key]
        public int TransactionID { get; set; }

        [ForeignKey("SenderAccount")]
        public int SenderAccountID { get; set; }
        public Account SenderAccount { get; set; }

        [ForeignKey("ReceiverAccount")]
        public int ReceiverAccountID { get; set; }
        public Account ReceiverAccount { get; set; }

        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
