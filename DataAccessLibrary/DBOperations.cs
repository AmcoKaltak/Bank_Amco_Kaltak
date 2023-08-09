using DataAccessLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.DataContext;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLibrary
{
    public class DBOperations
    {

        public void Transaction(Account senderAccount, Account receiverAccount, string name, float amount)
        {
            using Context context = new Context();

            var sender = context.Accounts.FirstOrDefault(a => a.Id == senderAccount.Id);
            var receiver = context.Accounts.FirstOrDefault(a=> a.Id == receiverAccount.Id);

            if (sender != null && receiver != null)
            {

                Transaction transaction = new Transaction();

                transaction.Name = name;
                transaction.Amount = amount;
                transaction.TransactionDate = DateTime.Now;

                AddTransaction(transaction);

                var accountTransactionSender = new AccountTransaction
                {
                    AccountId = sender.Id,
                    TransactionId = transaction.Id,
                    TransactionType = "Sender"
                };

                var accountTransactionReceiver = new AccountTransaction
                {
                    AccountId = receiver.Id,
                    TransactionId = transaction.Id,
                    TransactionType = "Receiver"
                };

                try
                {
                    context.AccountTransactions.AddRange(accountTransactionSender, accountTransactionReceiver);

                }
                catch (Exception exception)
                {
                    context.Transactions.Remove(transaction);
                    throw;
                }


                sender.Money -= amount;
                receiver.Money += amount;

                context.SaveChanges();

            }
        }

        public void AddTransaction(Transaction transaction)
        {
            Context context = new Context();

            context.Transactions.Add(transaction);

            context.SaveChanges();
        }

        public void AddAccountToUser(User user,Account account)
        {
            using Context context = new Context();

            var userClient = context.Users.FirstOrDefault(u => u.Id == user.Id);

            if (userClient != null)
            {
                userClient.Accounts.Add(account);
            }

            context.SaveChanges();
        }

        public bool AddAccountToOtherUserAccount(User user, Account account)
        {
            using Context context = new Context();

            var checkExisting = context.OtherUserAccounts.Where(oua => oua.UserId == user.Id && oua.AccountId == account.Id).FirstOrDefault();

            if (checkExisting == null && user != null && account != null)
            {
                context.OtherUserAccounts.Add(new OtherUserAccount { UserId = user.Id, AccountId = account.Id });
                context.SaveChanges();


                return true;
            }
            else
            {
                return false;
            }


        }

        public void AddUser(User user)
        {
            using Context context = new Context();

            context.Users.Add(user);

            context.SaveChanges();
        }

        public void AddPasswordTokenAndDateToUser(string email,string passwordResetToken,DateTime passwordResetDate)
        {
            using Context context = new Context();

            var user = context.Users.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                user.PasswordResetToken = passwordResetToken;
                user.PasswordResetDate = passwordResetDate;
            }

            context.SaveChanges();
        }

        public void ChangePassword(string email,string newPassword)
        {
            using Context context = new Context();

            var user = context.Users.FirstOrDefault(u => u.Email == email);

            if (user != null)
            {
                user.Password = newPassword;

            }

            context.SaveChanges();
        }

        public void UpdateAccountName (Account account,string accountName)
        {
            using Context context = new Context();

            var accountClient = context.Accounts.FirstOrDefault(a => a.Id == account.Id);

            if (accountClient != null)
            {
                accountClient.AccountName = accountName;
            }

            context.SaveChanges();

        }

        public User GetUserFromUsername(string username) //Hittat en entity i databasen med matchande användar namn
        {
            using Context context= new Context();

            var user = context.Users.FirstOrDefault(u => u.Username == username);

            //var user = context.Users //Linq queries är i normala fal alltid case insensitive, för att fixa detta kan man göra den dubbel check i client eller altera databasen
            //        .Where(u => u.username == username && u.password == password )
            //        .FirstOrDefault();

            return user;
        }

        public User GetUserFromEmail(string email) //Hittat en entity i databasen med matchande email
        {
            using Context context = new Context();

            var user = context.Users.FirstOrDefault(u => u.Email == email);

            //var user = context.Users //Linq queries är i normala fal alltid case insensitive, för att fixa detta kan man göra den dubbel check i client eller altera databasen
            //        .Where(u => u.username == username && u.password == password )
            //        .FirstOrDefault();

            return user;
        }

        public User GetUserFromAccount(Account account)
        {
            using Context context = new Context();

            var user = context.Users.Where(u => u.Accounts.Any(a => a.Id == account.Id)).FirstOrDefault();

            return user;
        }

        public Account GetSenderAccountFromTransaction(Transaction transaction)
        {
            using Context context = new Context();

            var account = context.Accounts
                .Include(a=> a.AccountTransactions)
                .ThenInclude(at=> at.Transaction)
                .Where(a=> a.AccountTransactions.Any(at=> at.TransactionType.Equals("Sender") && at.Transaction.Id == transaction.Id)).AsSplitQuery().First();

            return account;
        }

        public Account GetAccountFromEmailAndAccountCode(string email, string accountCode)
        {
            using Context context = new Context();

            var account = context.Accounts.Where(a=> a.User.Email == email && a.AccountCode == accountCode).FirstOrDefault();

            return account;
        }

        public Account GetReceiverAccountFromTransaction(Transaction transaction)
        {
            using Context context = new Context();

            var account = context.Accounts
                .Include(a => a.AccountTransactions)
                .ThenInclude(at => at.Transaction)
                .Where(a => a.AccountTransactions.Any(at => at.TransactionType.Equals("Receiver") && at.Transaction.Id == transaction.Id)).AsSplitQuery().FirstOrDefault();

            return account;
        }

        public List<Account> GetUserAccounts(User user)
        {
            using Context context = new Context();

            var accounts = context.Accounts.Where(a => a.UserId == user.Id && a.IsDeleleted == false).ToList();

            return accounts;
        }

        public List<Account> GetOtherUserAccounts(User user)
        {
            using Context context = new Context();

            var accounts = context.Accounts.Where(a => a.OtherUserAccounts.Any(oua => oua.UserId == user.Id && oua.Account.IsDeleleted == false)).ToList();

            return accounts;
        }

        public List<Account> GetUserSearchedAccounts(User user, string search)
        {
            using Context context = new Context();

            var accounts = context.Accounts.Where(a => a.UserId == user.Id && a.IsDeleleted == false && a.AccountName.Contains(search)).ToList();

            return accounts;
        }

        public List<Transaction> GetAccountTransactions(Account account)
        {
            using Context context = new Context();

            var transactions = context.Accounts.Where(a => a.Id == account.Id).SelectMany(a => a.Transactions).OrderByDescending(t => t.TransactionDate).ToList();

            return transactions;
        }

        public List<Transaction> GetAccountSentTransactions(Account account)
        {
            using Context context = new Context();

            var transactions = context.Transactions
                .Include(t => t.AccountTransactions)
                .ThenInclude(at => at.Account)
                .Where(t => t.AccountTransactions.Any(at => at.TransactionType.Equals("Sender") && at.Account.Id == account.Id)).OrderByDescending(t => t.TransactionDate).AsSplitQuery().ToList();

            return transactions;
        }

        public List<Transaction> GetAccountReceivedTransactions(Account account)
        {
            using Context context = new Context();

            var transactions = context.Transactions
                .Include(t => t.AccountTransactions)
                .ThenInclude(at => at.Account)
                .Where(t => t.AccountTransactions.Any(at => at.TransactionType.Equals("Receiver") && at.Account.Id == account.Id)).OrderByDescending(t => t.TransactionDate).AsSplitQuery().ToList();

            return transactions;
        }

        public List<Transaction> GetUserTransactions (User user)
        {
            using Context context = new Context();

            var transactions = context.Accounts.Where(a=> a.UserId == user.Id).SelectMany(a=> a.Transactions).OrderByDescending(t=> t.TransactionDate).ToList();

            return transactions;
        }

        public List<Transaction> GetUserSentTransactions(User user)
        {
            using Context context = new Context();

            var transactions = context.Transactions
                .Include(t=> t.AccountTransactions)
                .ThenInclude(at=> at.Account)
                .Where(t=> t.AccountTransactions.Any(at=> at.TransactionType.Equals("Sender") && at.Account.UserId == user.Id)).OrderByDescending(t=> t.TransactionDate).AsSplitQuery().ToList();

            return transactions;
        }

        public List<Transaction> GetUserReceivedTransactions(User user)
        {
            using Context context = new Context();

            var transactions = context.Transactions
                .Include(t => t.AccountTransactions)
                .ThenInclude(at => at.Account)
                .Where(t => t.AccountTransactions.Any(at => at.TransactionType.Equals("Receiver") && at.Account.UserId == user.Id)).OrderByDescending(t => t.TransactionDate).AsSplitQuery().ToList();

            return transactions;
        }

        public bool CheckUniqueUser(User user)
        {

            using Context context = new Context();

            var userUnique = context.Users //Linq queries är i normala fal alltid case insensitive, för att fixa detta kan man göra den dubbel check i client eller altera databasen
                    .Where(u => u.Username == user.Username || u.Email == user.Email )
                    .FirstOrDefault();

            if (userUnique == null)
            {
                return true;
            }

            return false;
        }

        public void DeleteAccount (Account account)
        {
            using Context context= new Context();

            var accountClient = context.Accounts.FirstOrDefault(a => a.Id == account.Id);

            if (accountClient != null)
            {
                if (accountClient.Money > 0)
                {
                    Random random = new Random();

                    var randomAccountFromUser = context.Accounts
                        .Where(a => a.UserId == account.UserId)
                        .FirstOrDefault();

                    if (randomAccountFromUser != null)
                    {
                        randomAccountFromUser.Money += accountClient.Money;
                    }
                }

                accountClient.IsDeleleted = true;
            }

            context.SaveChanges();
        }

        public bool DeleteOtherUserAccount(User user,Account account)
        {
            using Context context = new Context();

            var otherUserAccountToDelete = context.OtherUserAccounts.Where(oua => oua.UserId == user.Id && oua.AccountId == account.Id).FirstOrDefault();

            if (otherUserAccountToDelete != null)
            {
                context.OtherUserAccounts.Remove(otherUserAccountToDelete);

                context.SaveChanges();

                return true;
            }

            return false;

        }

        //public void RemoveUser()
        //{
        //    using Context context = new Context();

        //    var user = context.Users.Where(u => u.Id == 3).FirstOrDefault();

        //    context.Remove(user);

        //    context.SaveChanges();
        //}
    }
}
