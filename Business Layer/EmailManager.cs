using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Net;
using DataAccessLibrary.Entity;
using DataAccessLibrary.DataContext;

namespace Business_Layer
{
    public class EmailManager
    {
        const string SENDER = "muhamedkaltakprojekt@outlook.com";
        const string PASSWORD = "MuhamedKaltak_Projekt";
        const string HOST = "smtp.office365.com";
        const int PORT = 587;

        public void SendUsername(string receiver)
        {

            User user = GetUserFromEmail(receiver);

            if (user == null)
            {
                return;
            }

            SendEmail(receiver, "Username Recovery", "Your username is: " + user.Username);

        }

        public void SendVerificationCode(string receiver)
        {

            User user = GetUserFromEmail(receiver);

            Security security = new Security();

            DBOperations dBOperations = new DBOperations();

            string verificationCode = security.GenerateVerificationCode();

            if (user == null)
            {
                return;
            }

            SendEmail(receiver, "Password Verification Code", "Verification code: " +  verificationCode);


            dBOperations.AddPasswordTokenAndDateToUser(receiver,security.Hash(verificationCode), DateTime.Now);

            
        }

        


        private void SendEmail(string receiver, string subject, string body)
        {
            try
            {
                using (MailMessage mail = new MailMessage(SENDER, receiver, subject, body))
                {
                    using (SmtpClient smtp = new SmtpClient(HOST, PORT))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(SENDER, PASSWORD);
                        smtp.Send(mail);

                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

        private User GetUserFromEmail(string email)
        {
            DBOperations dBOperations = new DBOperations();

            return dBOperations.GetUserFromEmail(email);

        }
    }
}
