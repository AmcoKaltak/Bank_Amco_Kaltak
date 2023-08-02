﻿using DataAccessLibrary;
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

        public List<Transaction> GetTransactions(User user)
        {
            return dBOperations.GetUserTransactions(user);
        }

        public List<Transaction> GetSentTransactions(User user)
        {
            return dBOperations.GetUserSentTransactions(user);
        }

        public List<Transaction> GetReceivedTransactions (User user)
        {
            return dBOperations.GetUserReceivedTransactions(user);
        }
    }
}
