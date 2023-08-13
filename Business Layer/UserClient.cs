using DataAccessLibrary;
using DataAccessLibrary.DataContext;
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

        public DBOperations dboperations;

        public Account selectedAccount;
        public Transaction selectedTransaction;

        public AccountManager accountManager;
        public TransactionManager transactionManager;
        public Settings settings;

        public UserClient(User user)
        {
            this.user = user;

            dboperations = new DBOperations();

            accountManager = new AccountManager(ref this.user,dboperations);
            transactionManager = new TransactionManager(ref this.user, dboperations);
            settings = new Settings(ref this.user,dboperations);
        }



    }
}
