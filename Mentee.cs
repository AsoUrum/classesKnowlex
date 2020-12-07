using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowlexClasses
{
    public class Mentee
    {
        
        public int mentee_id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> dateOfBirth { get; set; }
        public string program { get; set; }
        public string credits { get; set; }
        public string spokenLanguage { get; set; }
        public Nullable<System.DateTime> enrollDate { get; set; }
        public string password { get; set; }
        public byte[] profile_picture { get; set; }
        public Nullable<int> institution_id { get; set; }

        public string accountType
        {
            get => default;
            set
            {
            }
        }

        public Institution Institution
        {
            get => default;
            set
            {
            }
        }

        public Session Session
        {
            get => default;
            set
            {
            }
        }

        public Rating Rating
        {
            get => default;
            set
            {
            }
        }

        public Post Post
        {
            get => default;
            set
            {
            }
        }

        public Comment Comment
        {
            get => default;
            set
            {
            }
        }

        public CreditCard CreditCard
        {
            get => default;
            set
            {
            }
        }

        public Searchable Searchable
        {
            get => default;
            set
            {
            }
        }

        public void createAccount()
        {
            throw new System.NotImplementedException();
        }

        public void upgradeToMentor()
        {
            throw new System.NotImplementedException();
        }

        public void signIn()
        {
            throw new System.NotImplementedException();
        }

        public void createPost()
        {
            throw new System.NotImplementedException();
        }

        public void search()
        {
            throw new System.NotImplementedException();
        }

        public void rateMentor()
        {
            throw new System.NotImplementedException();
        }

        public void comment()
        {
            throw new System.NotImplementedException();
        }
    }
}
