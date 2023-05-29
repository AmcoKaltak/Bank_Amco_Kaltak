using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Entity
{
    public class User
    {
        public int Id { get; set; }
        public ICollection<Transaction> Transactions { get; set; }


        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public float moneyBalance { get; set; }



    }
}