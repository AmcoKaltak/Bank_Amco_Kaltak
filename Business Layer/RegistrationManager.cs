using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
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

            

            user.Username = username;
            user.Salt = GenerateUniqueSalt();
            user.Password = security.Hash($"{password}{user.Salt}");
            user.Name = name;
            user.LastName = lastName;
            user.Email = email;
            user.Accounts.Add(RegisterStartingMoneyAccount());


            if (dBOperations.CheckIfUsernameOrEmailExists(user))
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

            dBOperations.ChangePassword(email, security.Hash($"{newPassword}{user.Salt}"));
        }

        private string GenerateUniqueSalt()
        {
            var salt = DateTime.Now.ToString();

            if (dBOperations.CheckIfSaltExists(salt) == false)
            {
                return salt;
            }
            else
            {
               return GenerateUniqueSalt();
            }
        }

        private Account RegisterStartingMoneyAccount()
        {
            Account account = new Account();
            Random random = new Random();

            //account.user = user;
            account.AccountName = "Sparkonto";
            account.Money = random.Next(10000, 1000000);
            account.AccountCode = security.GenerateVerificationCode();

            return account;
        }

    }
}
