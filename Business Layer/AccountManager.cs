using DataAccessLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.DataContext;

namespace Business_Layer
{
    public class AccountManager
    {
        DBOperations dBOperations;

        public AccountManager()
        {
            dBOperations = new DBOperations();
        }

        public void AddNewAccount(User user, string accountName)
        {
            Security security = new Security();
            Account account = new Account();

            account.AccountName = accountName;
            account.Money = 0;
            account.AccountCode = security.GenerateVerificationCode();
            dBOperations.AddAccountToUser(user, account);


        }

        public bool AddAccountToOtherUserAccount(User user, Account account)
        {
           return dBOperations.AddAccountToOtherUserAccount(user,account);
        }

        public void UpdateAccount(Account account, string accountName)
        {
            dBOperations.UpdateAccountName(account, accountName);
        }

        public void DeleteAccount(Account account)
        {
            dBOperations.DeleteAccount(account);
        }

        public bool DeleteOtherUserAccount(User user,Account account)
        {
           return dBOperations.DeleteOtherUserAccount(user,account);
        }

        public List<Account> GetAccounts(User user)
        {
            var accounts = dBOperations.GetUserAccounts(user);

            return accounts;

        }

        public List<Account> GetOtherUserAccounts(User user)
        {
            return dBOperations.GetOtherUserAccounts(user);
        }

        public Account GetAccountByEmailAndAccountCode(string email,string accountCode)
        {
            return dBOperations.GetAccountFromEmailAndAccountCode(email, accountCode);
        }

        public List<Account> GetSearchedAccounts(User user, string search)
        {
            var accountsSearched = dBOperations.GetUserSearchedAccounts(user, search);

            return accountsSearched;
        }

        public List<Account> GetSearchedOtherUserAccounts(User user, string search)
        {
            return dBOperations.GetSearchedOtherUserAccounts(user, search);
        }

        public User GetUserFromAccount(Account account)
        {
            return dBOperations.GetUserFromAccount(account);
        }

        public Account GetSenderAccountFromTransaction(Transaction transaction)
        {
            return dBOperations.GetSenderAccountFromTransaction(transaction);
        }

        public Account GetReceiverAccountFromTransaction(Transaction transaction)
        {
            return dBOperations.GetReceiverAccountFromTransaction(transaction);
        }
    }
}
