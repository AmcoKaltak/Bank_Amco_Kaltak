using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Security
    {
       public string HashPassword(string password)
        {
            SHA256 hash = SHA256.Create();

            var passwordByte = Encoding.Default.GetBytes(password); //Tar in en string och returnar en array av bytes

            var hashedPassword = hash.ComputeHash(passwordByte); //Hashar det man sätter in i form av bytes och returnerar en array av det

            return Convert.ToHexString(hashedPassword); //Konverterar hash arrayen och returnarn hash värdet i form av en string



        }
    }
}
