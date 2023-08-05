using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Entity
{
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AccountName { get; set; }
        public float Money { get; set; }
        public string AccountCode { get; set; }

        //Ska användas för Soft Delete
        public bool IsDeleleted { get; set; }


        public User User { get; set; } = null!;

        //Many-To-Many
        public List<Transaction> Transactions { get; } = new();
        public List<AccountTransaction> AccountTransactions { get; } = new();
    }
}
