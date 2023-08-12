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
    public partial class SavedOtherAccountForm : Form
    {
        public UserClient userClient;

        public bool isTransactionAccountSelection;

        public SavedOtherAccountForm()
        {
            InitializeComponent();
        }

        private void SavedOtherAccountForm_Load(object sender, EventArgs e)
        {
            userClient.selectedAccount = null;

            AddAccountsToDatagridviewFromClient();
        }

        private void buttonAddOtherAccount_Click(object sender, EventArgs e)
        {
            GetToRetrieveOtherAccountForm();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (SelectedAccountValid())
            {
                GetToOtherAccountDetailForm();
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (SelectedAccountValid())
            {
                if (userClient.accountManager.DeleteOtherUserAccount(userClient.user, userClient.selectedAccount))
                {
                    AddAccountsToDatagridviewFromClient();
                    UINotification.Popup(Color.Green, "Sucessfully deleted saved account", "The selected account has been deleted from your saved other accounts");
                }
                else
                {
                    UINotification.Popup(Color.Red, "ERROR", "Could not delete the selected account");
                }
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchOtherUserAccount();
        }

        private void dataGridViewOtherAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedAccount = (DataAccessLibrary.Entity.Account)dataGridViewOtherAccount.SelectedRows[0].DataBoundItem;

            if (isTransactionAccountSelection)
            {
                userClient.transactionManager.receiverAccount = selectedAccount;

                MakeTransactionForm makeTransactionForm = new MakeTransactionForm();

                makeTransactionForm.userClient = userClient;

                FormChanger.OpenForm(makeTransactionForm);
            }
            else
            {
                userClient.selectedAccount = selectedAccount;
            }


        }

        private void GetToRetrieveOtherAccountForm()
        {
            RetrieveOtherAccountForm retrieveOtherAccountForm = new RetrieveOtherAccountForm();

            retrieveOtherAccountForm.savedOtherAccountForm = this;
            retrieveOtherAccountForm.userClient = userClient;

            FormChanger.OpenPopupForm(retrieveOtherAccountForm);
        }

        private void GetToOtherAccountDetailForm()
        {
            OtherAccountDetail otherAccountDetail = new OtherAccountDetail();

            otherAccountDetail.userClient = userClient;

            FormChanger.OpenPopupForm(otherAccountDetail);
        }

        public void AddAccountsToDatagridviewFromClient()
        {
            dataGridViewOtherAccount.DataSource = userClient.accountManager.GetOtherUserAccounts(userClient.user);
        }

        private bool SelectedAccountValid()
        {
            if (userClient.selectedAccount != null)
            {
                return true;
            }

            UINotification.Popup(Color.Red, "ERROR", "You have not selected an account");
            return false;
        }

        private void SearchOtherUserAccount()
        {
            dataGridViewOtherAccount.DataSource = userClient.accountManager.GetSearchedOtherUserAccounts(userClient.user, textBoxSearchOtherAccount.Text);

        }

        private void textBoxSearchOtherAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchOtherUserAccount();
            }
        }


    }
}
