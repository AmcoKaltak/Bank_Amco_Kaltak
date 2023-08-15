using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Microsoft.IdentityModel.Tokens;

namespace Bank_Muhamed_Kaltak.MenuForms
{
    public partial class ModifyAccountForm : Form
    {
        public UserClient userClient { get; set; }

        public bool isAdd { get; set; }
        public bool isEdit { get; set; }


        public ModifyAccountForm()
        {
            InitializeComponent();
        }

        private void ModifyAccountForm_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                labelDetail.Text = "Add a new account";
                textBoxAccount.PlaceholderText = "Enter account name";
            }
            else
            {
                labelDetail.Text = "Edit selected account";
                textBoxAccount.Text = userClient.selectedAccount.AccountName;
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChange();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.userClient = userClient;

            FormChanger.OpenForm(accountForm);
        }

        private void textBoxAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveChange();
            }
        }

        private void SaveChange()
        {
            if (isAdd && ValidSaveChange())
            {

                userClient.accountManager.AddNewAccount(textBoxAccount.Text);

                UINotification.Popup(Color.Green, "Succesfully added a new account",$"A new account called {textBoxAccount.Text} has been added to your user");

                ReturnToAccountForm();

            }
            else if (isEdit && ValidSaveChange())
            {
                userClient.accountManager.UpdateAccount(userClient.selectedAccount, textBoxAccount.Text);

                UINotification.Popup(Color.Green, "Succesfully changed the name of an account", $"The account name {userClient.selectedAccount.AccountName} has been changed to {textBoxAccount.Text}");

                ReturnToAccountForm();
            }
        }

        private void ReturnToAccountForm()
        {
            AccountForm accountForm = new AccountForm();
            accountForm.userClient = userClient;

            FormChanger.OpenForm(accountForm);
        }

        private bool ValidSaveChange()
        {
            if (!textBoxAccount.Text.IsNullOrEmpty())
            {
                return true;
            }

            UINotification.Popup(Color.Red, "ERROR", "Please put in a value for the account name");
            return false;
        }


    }
}
