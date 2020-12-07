using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowlexClasses
{
    public partial class Institution
    {
       

        public int institution_id { get; set; }
        public string name { get; set; }
        public string academic_level { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string streetName { get; set; }

    }
}
