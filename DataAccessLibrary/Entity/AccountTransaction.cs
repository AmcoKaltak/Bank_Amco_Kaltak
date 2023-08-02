using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Entity
{
    public class AccountTransaction
    {
        public int AccountId { get; set; }
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }


        //Navigation Properties
        public virtual Account Account { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
