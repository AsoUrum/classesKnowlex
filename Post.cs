using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowlexClasses
{

    public class Post
    {
        public int post_id { get; set; }
        public Nullable<int> mentee_id { get; set; }
        public string title { get; set; }
        public string descrition { get; set; }
        public string upload_doc { get; set; }
        public Nullable<System.DateTime> dueDate { get; set; }
        public Nullable<int> category_id { get; set; }
    }
}
