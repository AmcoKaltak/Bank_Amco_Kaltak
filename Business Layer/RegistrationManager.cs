using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;
using DataAccessLibrary.DataContext;
using DataAccessLibrary.Entity;

namespace Business_Layer
{
    public class RegistrationManager
    {
        DBOperations dBOperations = new DBOperations();
        Security security = new Security();
        User user = new User();

        public bool Register(string username, string password, string name, string lastName, string email) //Checks på att fieldsen är valid
            //Checks på att varje users username,password och email är unikt i databasen
        {

            Random random = new Random();

            user.username = username;
            user.salt = DateTime.Now.ToString();
            user.password = security.Hash($"{password}{user.salt}");
            user.name = name;
            user.lastName = lastName;
            user.email = email;
            user.moneyBalance = random.Next(10000, 1000000);


            if (string.IsNullOrWhiteSpace(user.username) || string.IsNullOrWhiteSpace(user.password) || string.IsNullOrWhiteSpace(user.name) || string.IsNullOrWhiteSpace(user.lastName) || string.IsNullOrWhiteSpace(user.email) || dBOperations.CheckUniqueUser(user) == false)
            {
                return false;
            } 
            else
            {
                dBOperations.AddUser(user);
                return true;

            }

        }

        public void RegisterNewPassword(string email, string newPassword)
        {
            user = dBOperations.GetUserFromEmail(email);

            dBOperations.ChangePassword(email, security.Hash($"{newPassword}{user.salt}"));
        }


    }
}
