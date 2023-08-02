using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Entity
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        //Many-To-Many
        public List<Account> Accounts { get; } = new();
        public List<AccountTransaction> AccountTransactions { get; } = new();
    }
}
