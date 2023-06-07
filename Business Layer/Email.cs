using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Net;

namespace Business_Layer
{
    public class Email
    {
        public void lol()
        {

            try
            {
                string to = "abedking@hotmail.se";
                string subject = "lol";
                string body = "body";

                string email = "abedking@hotmail.se"; //TODO fixa en ny mail just för projekt/tester
                string password = "";//TODO fixa en ny mail just för projekt/tester
                string host = "smtp.office365.com";
                int port = 587;

                using (MailMessage mail = new MailMessage(email, to, subject, body))
                {
                    using (SmtpClient smtp = new SmtpClient(host, port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(email, password);
                        smtp.Send(mail);
                       
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            

        }
    }
}
