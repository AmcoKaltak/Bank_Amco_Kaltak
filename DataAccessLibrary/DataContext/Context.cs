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
        public DbSet<AccountTransaction> AccountTransactions { get; set; }
        public DbSet<OtherUserAccount> OtherUserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDb;Initial Catalog=BankDB;Integrated Security=True;Pooling=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Many-to-many mellan Account och Transaction
            modelBuilder.Entity<Transaction>()
                .HasMany(t => t.Accounts)
                .WithMany(a => a.Transactions)
                .UsingEntity<AccountTransaction>();

            //Soft Delete värdet i Account ska ha en default värde av False
            modelBuilder.Entity<Account>()
                .Property(a => a.IsDeleleted)
                .HasDefaultValue(false);

            //Many-to-many mellan User och Account där Account foreign keyen ej är kopplad till Cascade Delete.
            modelBuilder.Entity<OtherUserAccount>()
                .HasKey(oua => new { oua.UserId, oua.AccountId });

            modelBuilder.Entity<OtherUserAccount>()
                .HasOne(oua => oua.User)
                .WithMany(u => u.OtherUserAccounts)
                .HasForeignKey(oua => oua.UserId);

            modelBuilder.Entity<OtherUserAccount>()
                .HasOne(oua => oua.Account)
                .WithMany(a => a.OtherUserAccounts)
                .HasForeignKey(oua => oua.AccountId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}