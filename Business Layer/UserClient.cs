using DataAccessLibrary;
using DataAccessLibrary.Entity;
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

        public List<Account> getAccounts()
        {
            DBOperations dBOperations = new DBOperations();

            var accounts = dBOperations.GetUserAccounts(user);

            return accounts;

        }

    }
}
