using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Business_Layer
{
    public class Security
    {
       public string Hash(string value)
        {
            SHA256 hash = SHA256.Create();

            var passwordByte = Encoding.Default.GetBytes(value); //Tar in en string och returnar en array av bytes

            var hashedPassword = hash.ComputeHash(passwordByte); //Hashar det man sätter in i form av bytes och returnerar en array av det

            return Convert.ToHexString(hashedPassword); //Konverterar hash arrayen och returnarn hash värdet i form av en string



        }

        public string GenerateVerificationCode()
        {
            Byte[] bytes;
            String bytesBase64Url; //Detta är Base64Url-Encoded och inte Base64-encoded, vilket innebär att det är säkert att använda i en url, se bara till att konvertera det till Base64 först när man decodar det.
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {

                bytes = new Byte[12]; //En multipel av 3 ex(3,6,12..) används för att undvika outputs med trailing padding.
                rng.GetBytes(bytes);


                //Konverterar det först till Base64 och därefter till Base64Url string.
                bytesBase64Url = Convert.ToBase64String(bytes).Replace('+', '-').Replace('/', '_');
            }

            return bytesBase64Url;
        }
    }
}
