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

        public string sender { get; set; }
        public string receiver { get; set; }
        public float amount { get; set; }
    }
}
