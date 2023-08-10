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
            var userSender = userClient.accountManager.GetUserFromAccount(userSenderAccount);


            var userReceiverAccount = userClient.accountManager.GetReceiverAccountFromTransaction(userClient.selectedTransaction);
            var userReceiver = userClient.accountManager.GetUserFromAccount(userReceiverAccount);

            labelSenderAccountName.Text = userSenderAccount.AccountName;
            labelSenderAccountCode.Text = userSenderAccount.AccountCode;

            labelSenderUserName.Text = userSender.Name;
            labelSenderUserLastName.Text = userSender.LastName;
            labelSenderUserEmail.Text = userSender.Email;


            labelReceiverAccountName.Text = userReceiverAccount.AccountName;
            labelReceiverAccountCode.Text = userReceiverAccount.AccountCode;

            labelReceiverUserName.Text = userReceiver.Name;
            labelReceiverUserLastName.Text = userReceiver.LastName;
            labelReceiverUserEmail.Text = userReceiver.Email;

            labelTransactionName.Text += userClient.selectedTransaction.Name;
            labelTransactionAmount.Text += userClient.selectedTransaction.Amount + " kr";
            labelTransactionDate.Text += userClient.selectedTransaction.TransactionDate.Date.ToString("yyyy/MM/dd");
            labelTransactionTime.Text += userClient.selectedTransaction.TransactionDate.ToShortTimeString();


        }
    }
}
