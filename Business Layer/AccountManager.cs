using DataAccessLibrary.Entity;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            account.accountName = accountName;
            account.money = 0;
            account.accountCode = security.GenerateVerificationCode();
            dBOperations.AddAccountToUser(user, account);


        }

        public void UpdateAccount(Account account, string accountName)
        {
            dBOperations.UpdateAccountName(account, accountName);
        }

        public void DeleteAccount(Account account)
        {
            dBOperations.DeleteAccount(account);
        }
        public List<Account> GetAccounts(User user)
        {
            var accounts = dBOperations.GetUserAccounts(user);

            return accounts;

        }

        public List<Account> GetSearchedAccounts(User user, string search)
        {
            var accountsSearched = dBOperations.GetUserSearchedAccounts(user, search);

            return accountsSearched;
        }
    }
}
