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

        public User LogInUser(string username, string password) //Hittat en entity i databasen med matchande användar namn samt lösenord
        {
            using Context context= new Context();

            var user = context.Users
                    .Where(u => u.username == username && u.password == password )
                    .FirstOrDefault();

            return user;
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
