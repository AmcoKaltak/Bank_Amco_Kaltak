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
       private DBOperations dBOperations;
       private User user;

        public AccountManager(ref User user,DBOperations dBOperations)
        {
            this.user = user;
            this.dBOperations = dBOperations;
        }

        public void AddNewAccount(string accountName)
        {
            Security security = new Security();
            Account account = new Account();

            account.AccountName = accountName;
            account.Money = 0;
            account.AccountCode = security.GenerateVerificationCode();
            dBOperations.AddAccountToUser(user, account);


        }

        public bool AddAccountToOtherUserAccount(Account account)
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

        public bool DeleteOtherUserAccount(Account account)
        {
           return dBOperations.DeleteOtherUserAccount(user,account);
        }

        public List<Account> GetAccounts()
        {
            var accounts = dBOperations.GetUserAccounts(user);

            return accounts;

        }

        public List<Account> GetAccountsByCount(int count)
        {
            return dBOperations.GetUserAccountsByCount(user, count);
        }

        public List<Account> GetOtherUserAccounts()
        {
            return dBOperations.GetOtherUserAccounts(user);
        }

        public Account GetAccountByEmailAndAccountCode(string email,string accountCode)
        {
            return dBOperations.GetAccountFromEmailAndAccountCode(email, accountCode);
        }

        public List<Account> GetSearchedAccounts(string search)
        {
            var accountsSearched = dBOperations.GetUserSearchedAccounts(user, search);

            return accountsSearched;
        }

        public List<Account> GetSearchedOtherUserAccounts(string search)
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
