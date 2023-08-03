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
    public partial class MakeTransactionForm : Form
    {
        public UserClient userClient;


        public MakeTransactionForm()
        {
            InitializeComponent();
        }

        private void panelSelectFromAccount_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = SendDataToAccountForm();

            accountForm.isTransactionAccountFrom = true;

            FormChanger.OpenForm(accountForm);
        }

        private void panelSelectToAccount_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = SendDataToAccountForm();

            accountForm.isTransactionAccountTo = true;

            FormChanger.OpenForm(accountForm);
        }

        private void textBoxTransactionName_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxTransactionName, panelTransactionName);
        }

        private void textBoxTransactionAmount_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxTransactionAmount, panelAmount);
        }

        private void MakeTransactionForm_Load(object sender, EventArgs e)
        {
            RetrieveAccountDetails();
        }

        private AccountForm SendDataToAccountForm()
        {
            AccountForm accountForm = new AccountForm();

            accountForm.userClient = userClient;
            accountForm.isTransactionAccountSelection = true;

            return accountForm;
        }

        private void RetrieveAccountDetails()
        {
            if (userClient.transactionManager.senderAccount != null)
            {
                labelSenderAccountName.Text = userClient.transactionManager.senderAccount.AccountName;
                labelSenderAccountCode.Text = userClient.transactionManager.senderAccount.AccountCode;
                labelSenderAccountMoney.Text = userClient.transactionManager.senderAccount.Money.ToString();
            }

            if (userClient.transactionManager.receiverAccount != null)
            {
                labelReceiverAccountName.Text = userClient.transactionManager.receiverAccount.AccountName;
                labelReceiverAccountCode.Text = userClient.transactionManager.receiverAccount.AccountCode;
                labelReceiverAccountMoney.Text = userClient.transactionManager.receiverAccount.Money.ToString();
            }
        }

        private void buttonCommitTransaction_Click(object sender, EventArgs e)
        {
            if (CheckValidAccounts() && CheckValidAmount())
            {
                userClient.transactionManager.MakeTransaction(userClient.transactionManager.senderAccount, userClient.transactionManager.receiverAccount, textBoxTransactionName.Text, float.Parse(textBoxTransactionAmount.Text));
            }

        }

        private bool CheckValidAccounts()
        {
            if (userClient.transactionManager.senderAccount == null && userClient.transactionManager.receiverAccount == null)
            {
                UINotification.Popup(Color.Red, "ERROR", "You have not selected an account for both the sender and receiver");

                return false;
            }
            else if (userClient.transactionManager.senderAccount == null)
            {
                UINotification.Popup(Color.Red, "ERROR", "You have not selected an account for the sender");

                return false;
            }
            else if (userClient.transactionManager.receiverAccount == null)
            {
                UINotification.Popup(Color.Red, "ERROR", "You have not selected an account for the receiver");

                return false;
            }

            return true;
        }

        private bool CheckValidAmount()
        {
            float amount = 0;
            if (float.TryParse(textBoxTransactionAmount.Text, out amount) != true)
            {
                UINotification.Popup(Color.Red, "ERROR", "Please put in a numeric value for the amount");
                return false;
            }
            else if (float.Parse(textBoxTransactionAmount.Text) <= 0)
            {
                UINotification.Popup(Color.Red, "ERROR", "The amount of money has to be more than 0 kr");
                return false;
            }
            else if (userClient.transactionManager.senderAccount.Money < float.Parse(textBoxTransactionAmount.Text))
            {
                UINotification.Popup(Color.Red, "ERROR", "Sender account has insufficient amount of money, please lower the amount or transfer over money to the account.");
                return false;
            }

            return true;
        }

    }
}
