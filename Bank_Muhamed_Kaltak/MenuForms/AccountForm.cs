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
            if (SelectedAccountValid())
            {
                userClient.accountManager.DeleteAccount(userClient.account);

                AddAccountsToDatagridviewFromClient();
            }
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
                userClient.account = selectedAccount;
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

        private void AccountForm_Load(object sender, EventArgs e)
        {
            AddAccountsToDatagridviewFromClient();

            if (isTransactionAccountSelection)
            {
                buttonAddAccount.Visible = false;
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
            }
            else
            {
                buttonExternalAccount.Visible = false;
            }
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
            if (userClient.account != null)
            {
                return true;
            }

            return false;
        }



    }
}
