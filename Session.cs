using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowlexClasses
{
    public class Session
    {
        public int session_id { get; set; }
        public int mentor_id { get; set; }
        public int mentee_id { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public System.DateTime date { get; set; }
        public System.DateTime sessionStart { get; set; }
        public System.DateTime sessionEnd { get; set; }
        public decimal cost { get; set; }

        public Invoice Invoice
        {
            get => default;
            set
            {
            }
        }

        public void openSession()
        {
            throw new System.NotImplementedException();
        }

        public void endSession()
        {
            throw new System.NotImplementedException();
        }

        public void scheduleSession()
        {
            throw new System.NotImplementedException();
        }

        public void modifySession()
        {
            throw new System.NotImplementedException();
        }
    }
}
