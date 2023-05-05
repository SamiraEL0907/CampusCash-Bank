using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusCashBank
{
    public class AutomaticTransfer
    {
        [Key]
        public int AutomaticTransferID { get; set; }

        [ForeignKey("Account")]
        public int AccountID { get; set; }
        public Account Account { get; set; }

        public int Frequency { get; set; }
    }
}
