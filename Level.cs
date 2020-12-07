using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowlexClasses
{
    public class Level
    {
      
        public int level_id { get; set; }
        public string name { get; set; }
        public int hours { get; set; }
        public decimal hourly_rate { get; set; }
        public decimal fee { get; set; }

        
    }
}
