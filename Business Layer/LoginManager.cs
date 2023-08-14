using DataAccessLibrary.DataContext;
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
        public User LogIn(string username,string password) //Kollar först ifall det finns en användare i databasen med den angivna användarnamnet. Om det finns checkas lösenordet
        {
            DBOperations dBOperations = new DBOperations();
            Security security = new Security();

            var user = dBOperations.GetUserFromUsername(username);

            if (user != null && security.CheckValidUsernameAndPassword(username, password, user))
            {
                return user;
            }

            return null;

        }
    }
}
