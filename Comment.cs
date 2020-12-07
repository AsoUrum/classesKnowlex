using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowlexClasses
{

    public class Comment
    {
        public int comment_id { get; set; }
        public int mentor_id { get; set; }
        public int mentee_id { get; set; }
        public string title { get; set; }
        public string message { get; set; }
        public string date { get; set; }
        public string status { get; set; }

       
    }

}
