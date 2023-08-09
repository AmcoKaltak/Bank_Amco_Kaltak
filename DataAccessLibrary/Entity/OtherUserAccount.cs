using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Entity
{
    public class OtherUserAccount
    {
        public int UserId { get; set; }
        public int AccountId { get; set; }

        public virtual User User { get; set; }
        public virtual Account Account { get; set; }
    }
}
