using Business_Layer;
using Microsoft.IdentityModel.Tokens;
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
    public partial class RetrieveExternalAccountForm : Form
    {
        public UserClient userClient;

        public RetrieveExternalAccountForm()
        {
            InitializeComponent();

            buttonRetrieve.Select(); //Fix för att undvika att denna popup formen väljer automatiskt en textbox. Sker pga form.ShowDialog();
        }

        private void RetrieveExternalAccountForm_Load(object sender, EventArgs e)
        {
            textBoxEmail_Click(sender, e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxEmail, panelEmail);
        }

        private void textBoxAccountCode_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxAccountCode, panelAccountCode);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            if (CheckValidInputs())
            {
                var externalAccount = userClient.accountManager.GetAccountByEmailAndAccountCode(textBoxEmail.Text, textBoxAccountCode.Text);

                if (externalAccount != null)
                {
                    userClient.transactionManager.receiverAccount = externalAccount;

                    ReturnToMakeTransactionForm();

                    FormChanger.CloseForm(this);

                }
                else
                {
                    UINotification.Popup(Color.Red, "ERROR", "The account was not found in the system");
                }
            }
            


        }

        private bool CheckValidInputs()
        {
            if (textBoxEmail.Text.IsNullOrEmpty())
            {
                UINotification.Popup(Color.Red, "ERROR", "The email text field cannot be empty");
                return false;
            }
            else if (textBoxAccountCode.Text.IsNullOrEmpty())
            {
                UINotification.Popup(Color.Red, "ERROR", "The account code text field cannot be empty");
                return false;
            }

            return true;
        }

        private void ReturnToMakeTransactionForm()
        {
            MakeTransactionForm makeTransactionForm = new MakeTransactionForm();

            makeTransactionForm.userClient = userClient;

            FormChanger.OpenForm(makeTransactionForm);
        }
    }
}
