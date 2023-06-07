using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Net;
using DataAccessLibrary;
using DataAccessLibrary.Entity;

namespace Business_Layer
{
    public class EmailManager
    {
        public void SendVerificationCode(string receiver)
        {

            string subject = "Verification";

            DBOperations dBOperations = new DBOperations();
            User user = dBOperations.GetUserFromEmail(receiver);

            if (user == null)
            {
                return;
            }

            try
            {
                string sender = "muhamedkaltakprojekt@outlook.com";
                string password = "MuhamedKaltak_Projekt";
                string host = "smtp.office365.com";
                int port = 587;

                using (MailMessage mail = new MailMessage(sender, receiver, subject, "Username: " +  user.username))
                {
                    using (SmtpClient smtp = new SmtpClient(host, port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(sender, password);
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
