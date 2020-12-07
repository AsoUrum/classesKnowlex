using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowlexClasses
{
    class Mentor
    {

        public int mentor_id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public System.DateTime dateOfBirth { get; set; }
        public int institution_id { get; set; }
        public decimal balance { get; set; }
        public int hoursTough { get; set; }
        public int rating_id { get; set; }
        public int level_id { get; set; }
        public string spokenLanguage { get; set; }
        public string password { get; set; }
        public string program { get; set; }
        public System.DateTime enrollDate { get; set; }
        public string studentNumber { get; set; }
        public string enrollmentProof { get; set; }
        public string profile_picture { get; set; }
        public int card_id { get; set; }
        public int bankAccount_id { get; set; }

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

        public BankAccount BankAccount
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

        public Level Level
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

        public void signIn()
        {
            throw new System.NotImplementedException();
        }

        public void setLevel()
        {
            throw new System.NotImplementedException();
        }

        public void search()
        {
            throw new System.NotImplementedException();
        }
    }
}
