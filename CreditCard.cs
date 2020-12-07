using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowlexClasses
{

    public class CreditCard
    {
      

        public int card_id { get; set; }
        public string cardNumber { get; set; }
        public Nullable<int> securityCode { get; set; }
        public string cardHolder { get; set; }
        public Nullable<System.DateTime> expirationDate { get; set; }

        
    }
}
