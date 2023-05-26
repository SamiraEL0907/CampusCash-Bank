using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.ApplicationServices;

namespace CampusCashBank
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        public int UserID { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public decimal? NegativeLimit { get; set; }

        public List<Transaction> GetTransactionHistory()
        {
            Database db = new Database();
            return db.GetTransactionHistory(this.AccountID);
        }
    }
}

