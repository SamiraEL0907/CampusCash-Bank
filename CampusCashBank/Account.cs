using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

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

        public Account() { }

        public Account(DataRow row)
        {
            AccountID = Convert.ToInt32(row["AccountID"]);
            UserID = Convert.ToInt32(row["UserID"]);
            AccountName = row["AccountName"].ToString();
            Balance = Convert.ToDecimal(row["Balance"]);
            NegativeLimit = row["NegativeLimit"] as decimal?;
        }

        public List<Transaction> GetTransactionHistory()
        {
            Database db = new Database();
            return db.GetTransactionHistory(this.AccountID);
        }
    }
}

