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

        public Account account;

        public AccountManager accountManager;

        public UserClient(User user)
        {
            this.user = user;

            accountManager = new AccountManager();
        }



    }
}
