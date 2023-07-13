using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Entity
{
    public class User
    {
        public int Id { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Account> Accounts { get; } = new List<Account>(); //One to many

        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string? passwordResetToken { get; set; } //? Ser till att variabeln kan vara null
        public DateTime passwordResetDate { get; set; }



    }
}