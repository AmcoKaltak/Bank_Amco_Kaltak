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
        public User LogIn(string username,string password) //Kollar först ifall det finns en användare i databasen med den angivna användarnamnet. Om det finns checkas lösenordet
        {
            DBOperations dBOperations = new DBOperations();

            var user = dBOperations.GetUser(username);

            if (user != null)
            {
                if (CheckValidUsernameAndPassword(username,password, user))
                {
                    return user;
                }
            }

            return null;

        }

        private bool CheckValidUsernameAndPassword(string enteredUsername,string enteredPassword, User user)
        {
            Security security = new Security();

            if (enteredUsername == user.username && security.HashPassword($"{enteredPassword}{user.salt}") == user.password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
