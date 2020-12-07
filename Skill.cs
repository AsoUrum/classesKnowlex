using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowlexClasses
{
    public partial class Skill
    {
        public int skill_id { get; set; }
        public Nullable<int> mentor_id { get; set; }
        public Nullable<int> category_id { get; set; }
        public string name { get; set; }
        public Nullable<int> sLevel { get; set; }
        public string specialization { get; set; }
    }
}
