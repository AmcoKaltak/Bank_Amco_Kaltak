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
                if (CheckPassword(password, user))
                {
                    return user;
                }
            }

            return null;

        }

        private bool CheckPassword(string enteredPassword, User user)
        {
            Security security = new Security();

            if (security.HashPassword($"{enteredPassword}{user.salt}") == user.password)
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
