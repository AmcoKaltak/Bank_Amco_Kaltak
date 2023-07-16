using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary.DataContext
{
    public class Context : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDb;Initial Catalog=BankDB;Integrated Security=True;Pooling=False");
        }
    }
}