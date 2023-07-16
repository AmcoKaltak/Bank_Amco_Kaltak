using DataAccessLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.DataContext;

namespace DataAccessLibrary
{
    public class DBOperations
    {
        public void AddUser(User user)
        {
            using Context context = new Context();

            context.Users.Add(user);

            context.SaveChanges();
        }

        public void AddPasswordTokenAndDateToUser(string email,string passwordResetToken,DateTime passwordResetDate)
        {
            using Context context = new Context();

            var user = context.Users.FirstOrDefault(u => u.email == email);

            user.passwordResetToken = passwordResetToken;
            user.passwordResetDate = passwordResetDate;

            context.SaveChanges();
        }

        public void ChangePassword(string email,string newPassword)
        {
            using Context context = new Context();

            var user = context.Users.FirstOrDefault(u => u.email == email);

            user.password = newPassword;

            context.SaveChanges();
        }

        public User GetUserFromUsername(string username) //Hittat en entity i databasen med matchande användar namn
        {
            using Context context= new Context();

            var user = context.Users.FirstOrDefault(u => u.username == username);

            //var user = context.Users //Linq queries är i normala fal alltid case insensitive, för att fixa detta kan man göra den dubbel check i client eller altera databasen
            //        .Where(u => u.username == username && u.password == password )
            //        .FirstOrDefault();

            return user;
        }

        public User GetUserFromEmail(string email) //Hittat en entity i databasen med matchande email
        {
            using Context context = new Context();

            var user = context.Users.FirstOrDefault(u => u.email == email);

            //var user = context.Users //Linq queries är i normala fal alltid case insensitive, för att fixa detta kan man göra den dubbel check i client eller altera databasen
            //        .Where(u => u.username == username && u.password == password )
            //        .FirstOrDefault();

            return user;
        }

        public bool CheckUniqueUser(User user)
        {

            using Context context = new Context();

            var userUnique = context.Users //Linq queries är i normala fal alltid case insensitive, för att fixa detta kan man göra den dubbel check i client eller altera databasen
                    .Where(u => u.username == user.username || u.email == user.email )
                    .FirstOrDefault();

            if (userUnique == null)
            {
                return true;
            }

            return false;
        }

        public List<Account> GetUserAccounts(User user)
        {
            using Context context = new Context();

            var accounts = context.Accounts.Where(a => a.UserId == user.Id).ToList();

            return accounts;
        }

        //public void RemoveUser()
        //{
        //    using Context context = new Context();

        //    var user = context.Users.Where(u => u.Id == 3).FirstOrDefault();

        //    context.Remove(user);

        //    context.SaveChanges();
        //}
    }
}
