using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? PasswordResetToken { get; set; } //? Ser till att variabeln kan vara null
        public DateTime PasswordResetDate { get; set; }


        public ICollection<Account> Accounts { get; } = new List<Account>(); //One to many

        //Many-To-Many <-> User och Account
        public List<OtherUserAccount> OtherUserAccounts { get; } = new ();


    }
}