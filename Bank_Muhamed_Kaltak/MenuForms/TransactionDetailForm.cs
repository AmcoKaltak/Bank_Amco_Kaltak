using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Muhamed_Kaltak.MenuForms
{
    public partial class TransactionDetailForm : Form
    {

        public UserClient userClient;

        private const string userDeleted = "USER DELETED";
        private const string accountDeleted = "ACCOUNT DELETED";

        public TransactionDetailForm()
        {
            InitializeComponent();
        }

        private void TransactionDetail_Load(object sender, EventArgs e)
        {
            GetTransactionDetails();
        }

        private void GetTransactionDetails()
        {
            var userSenderAccount = userClient.accountManager.GetSenderAccountFromTransaction(userClient.selectedTransaction);

            if (userSenderAccount != null)
            {
                labelSenderAccountName.Text = userSenderAccount.AccountName;
                labelSenderAccountCode.Text = userSenderAccount.AccountCode;
            }
            else
            {
                labelSenderAccountName.Text = accountDeleted;
                labelSenderAccountCode.Text = accountDeleted;
            }

            var userSender = userClient.accountManager.GetUserFromAccount(userSenderAccount);

            if (userSender != null)
            {
                labelSenderUserFullName.Text = $"{userSender.Name} {userSender.LastName}";
                labelSenderUserEmail.Text = userSender.Email;
            }
            else
            {
                labelSenderUserFullName.Text = userDeleted;
                labelSenderUserEmail.Text = userDeleted;
            }


            var userReceiverAccount = userClient.accountManager.GetReceiverAccountFromTransaction(userClient.selectedTransaction);

            if (userReceiverAccount != null)
            {
                labelReceiverAccountName.Text = userReceiverAccount.AccountName;
                labelReceiverAccountCode.Text = userReceiverAccount.AccountCode;
            }
            else
            {
                labelReceiverAccountName.Text = accountDeleted;
                labelReceiverAccountCode.Text = accountDeleted;
            }

            var userReceiver = userClient.accountManager.GetUserFromAccount(userReceiverAccount);

            if (userReceiver != null)
            {
                labelReceiverUserFullName.Text = $"{userReceiver.Name} {userReceiver.LastName}";
                labelReceiverUserEmail.Text = userReceiver.Email;
            }
            else
            {
                labelReceiverUserFullName.Text = userDeleted;
                labelReceiverUserEmail.Text = userDeleted;
            }


            labelTransactionName.Text += userClient.selectedTransaction.Name;
            labelTransactionAmount.Text += userClient.selectedTransaction.Amount + " kr";
            labelTransactionDate.Text += userClient.selectedTransaction.TransactionDate.Date.ToString("yyyy/MM/dd");
            labelTransactionTime.Text += userClient.selectedTransaction.TransactionDate.ToShortTimeString();


        }
    }
}
