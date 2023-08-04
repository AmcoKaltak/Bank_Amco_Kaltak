using DataAccessLibrary;
using DataAccessLibrary.Entity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class TransactionManager
    {
        public Account senderAccount;
        public Account receiverAccount;

        DBOperations dBOperations = new DBOperations();

        public void MakeTransaction(Account senderAccount, Account receiverAccount, string name, float amount)
        {
            if (name.IsNullOrEmpty())
            {
                name = $"Transaction between {senderAccount.AccountName} and {receiverAccount.AccountName} ";
            }

            dBOperations.Transaction(senderAccount, receiverAccount, name, amount);
        }

        public List<Transaction> GetUserTransactions(User user)
        {
            return dBOperations.GetUserTransactions(user);
        }

        public List<Transaction> GetUserSentTransactions(User user)
        {
            return dBOperations.GetUserSentTransactions(user);
        }

        public List<Transaction> GetUserReceivedTransactions (User user)
        {
            return dBOperations.GetUserReceivedTransactions(user);
        }

        public List<Transaction> GetAccountTransactions(Account account)
        {
            return dBOperations.GetAccountTransactions(account);
        }

        public List<Transaction> GetAccountSentTransactions(Account account)
        {
            return dBOperations.GetAccountSentTransactions(account);
        }

        public List<Transaction> GetAccountReceivedTransactions(Account account)
        {
            return dBOperations.GetAccountReceivedTransactions(account);
        }

        public Account GetSenderAccountFromTransaction(Transaction transaction) //Flytta dessa två nedanför till accountmanager
        {
            return dBOperations.GetSenderAccountFromTransaction(transaction);
        }

        public Account GetReceiverAccountFromTransaction(Transaction transaction)
        {
            return dBOperations.GetReceiverAccountFromTransaction(transaction);
        }

    }
}
