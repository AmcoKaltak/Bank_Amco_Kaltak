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
    public partial class AccountForm : Form
    {
        public UserClient userClient { get; set; }

        public bool isTransactionAccountSelection;
        public bool isTransactionAccountFrom;
        public bool isTransactionAccountTo;

        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            AddAccountsToDatagridviewFromClient();

            if (isTransactionAccountSelection)
            {
                buttonAddAccount.Visible = false;
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
                buttonDetail.Visible = false;


                if (isTransactionAccountFrom)
                {
                    buttonOtherAccount.Visible = false;
                }
            }
            else
            {
                buttonOtherAccount.Visible = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchAccount();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            ModifyAccountForm modifyAccountForm = SendUserClientToModifyForm();

            modifyAccountForm.isAdd = true;

            FormChanger.OpenForm(modifyAccountForm);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (SelectedAccountValid())
            {
                ModifyAccountForm modifyAccountForm = SendUserClientToModifyForm();

                modifyAccountForm.isEdit = true;

                FormChanger.OpenForm(modifyAccountForm);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SelectedAccountValid() && EnoughAccounts())
            {
                userClient.accountManager.DeleteAccount(userClient.selectedAccount);

                AddAccountsToDatagridviewFromClient();

                var accountRetrieverFromDeletion = (DataAccessLibrary.Entity.Account)dataGridViewAccount.Rows[0].DataBoundItem;

                UINotification.Popup(Color.Green, "Deletion of an account",
                        $"Succesfully deleted {userClient.selectedAccount.AccountName}, {userClient.selectedAccount.Money} kr from the account has been transferred to {accountRetrieverFromDeletion.AccountName} ");
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (SelectedAccountValid())
            {
                AccountTransactionDetails();
            }
        }

        private void buttonOtherAccount_Click(object sender, EventArgs e)
        {
            GetToSavedNonClientAccountForm();
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedAccount = (DataAccessLibrary.Entity.Account)dataGridViewAccount.SelectedRows[0].DataBoundItem;

            if (isTransactionAccountSelection && isTransactionAccountFrom)
            {
                userClient.transactionManager.senderAccount = selectedAccount;

                ReturnToMakeTransaction();

            }
            else if (isTransactionAccountSelection && isTransactionAccountTo)
            {
                userClient.transactionManager.receiverAccount = selectedAccount;

                ReturnToMakeTransaction();

            }
            else
            {
                userClient.selectedAccount = selectedAccount;
            }
        }


        private void GetToSavedNonClientAccountForm()
        {
            SavedOtherAccountForm savedNonClientAccountForm = new SavedOtherAccountForm();

            savedNonClientAccountForm.userClient = userClient;

            FormChanger.OpenForm(savedNonClientAccountForm);
        }

        private void dataGridViewAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectedAccountValid())
            {
                AccountTransactionDetails();
            }
        }

        private void textBoxSearchAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchAccount();
            }
        }

        public void AddAccountsToDatagridviewFromClient()
        {
            dataGridViewAccount.DataSource = userClient.accountManager.GetAccounts(userClient.user);
        }

        private ModifyAccountForm SendUserClientToModifyForm()
        {
            ModifyAccountForm modifyAccount = new ModifyAccountForm();

            modifyAccount.userClient = userClient;

            return modifyAccount;
        }

        private void SearchAccount()
        {
            dataGridViewAccount.DataSource = userClient.accountManager.GetSearchedAccounts(userClient.user, textBoxSearchAccount.Text);
        }



        private void ReturnToMakeTransaction()
        {
            MakeTransactionForm makeTransactionForm = new MakeTransactionForm();

            makeTransactionForm.userClient = userClient;

            FormChanger.OpenForm(makeTransactionForm);
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

        private bool EnoughAccounts()
        {
            if (dataGridViewAccount.RowCount > 1)
            {
                return true;
            }

            UINotification.Popup(Color.Red, "ERROR", "You cannot delete your only left account");
            return false;
        }

        private void AccountTransactionDetails()
        {
            TransactionForm transactionForm = new TransactionForm();

            transactionForm.userClient = userClient;

            transactionForm.isAccountTransactions = true;

            FormChanger.OpenForm(transactionForm);
        }


    }
}
