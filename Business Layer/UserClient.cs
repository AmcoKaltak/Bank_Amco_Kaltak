using DataAccessLibrary;
using DataAccessLibrary.Entity;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class UserClient
    {
        public User user;

        public UserClient(User user)
        {
            this.user = user;
        }

        public void AddNewAccount(string accountName)
        {
            DBOperations dBOperations = new DBOperations();
            Security security = new Security();

            Account account = new Account();
            account.accountName = accountName;
            account.money = 0;
            account.accountCode = security.GenerateVerificationCode();

            dBOperations.AddAccountToUser(user,account);


        }

        public List<Account> GetAccounts()
        {
            DBOperations dBOperations = new DBOperations();

            var accounts = dBOperations.GetUserAccounts(user);

            return accounts;

        }

    }
}
