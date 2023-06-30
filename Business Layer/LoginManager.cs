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
        public bool LogIn(string username,string password) //Kollar först ifall det finns en användare i databasen med den angivna användarnamnet. Om det finns checkas lösenordet
        {
            DBOperations dBOperations = new DBOperations();

            var user = dBOperations.GetUserFromUsername(username);

            if (user != null && CheckValidUsernameAndPassword(username, password, user))
            {

                return true;
                
            }

            return false;

        }

        private bool CheckValidUsernameAndPassword(string enteredUsername,string enteredPassword, User user)
        {
            Security security = new Security();

            if (enteredUsername == user.username && security.Hash($"{enteredPassword}{user.salt}") == user.password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CheckValidVerficationCode(string email,string enteredCode)
        {
            DBOperations dBOperations = new DBOperations();

            Security security = new Security();

            User user = dBOperations.GetUserFromEmail(email);

            if (user == null)
            {
                return false;
            }

            TimeSpan timeSpan = DateTime.Now - user.passwordResetDate;

            if (user.passwordResetToken == security.Hash(enteredCode) && timeSpan.Minutes <= 10 ) //Kollar ifall coden matchar tokenet samt att det ej har passerat 10 min sen begäran av att ändra lösenordet skett
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
