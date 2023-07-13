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
        public User user { get; set; } = null!;

        public string accountName { get; set; }

        public float money { get; set; }

        public string accountCode { get; set; }
    }
}
