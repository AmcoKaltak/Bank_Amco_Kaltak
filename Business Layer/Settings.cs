using DataAccessLibrary.DataContext;
using DataAccessLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Settings
    {
        private DBOperations dBOperations;
        private User user;

        public Settings(ref User user,DBOperations dBOperations)
        {
            this.user = user;
            this.dBOperations = dBOperations;
        }

        public bool ChangeUsername(string username)
        {
            if (dBOperations.ChangeUsername(user, username))
            {
                user.Username = username;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ChangePassword(string password)
        {
            dBOperations.ChangePassword(user, password);
        }

        public bool DeleteUser()
        {
            return dBOperations.DeleteUser(user);
        }
    }
}
