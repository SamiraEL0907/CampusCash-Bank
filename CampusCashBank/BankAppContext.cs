using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Principal;


namespace CampusCashBank
{
    public class BankAppContext : DbContext 
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<AutomaticTransfer> AutomaticTransfers { get; set; }
    }
}
