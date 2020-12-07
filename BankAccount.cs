using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowlexClasses
{
    public class BankAccount
    {
       
        public int account_id { get; set; }
        public string accountNumber { get; set; }
        public string bankName { get; set; }
        public string interacEmail { get; set; }

        public Invoice Invoice
        {
            get => default;
            set
            {
            }
        }
    }

}
