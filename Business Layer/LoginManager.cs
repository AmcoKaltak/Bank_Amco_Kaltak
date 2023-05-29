using DataAccessLibrary;
using DataAccessLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class LoginManager
    {
        public User LogIn(string username,string password)
        {
            DBOperations dBOperations = new DBOperations();
            User user = new User();

            user = dBOperations.LogInUser(username,password);

            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }

        }

    }
}
