using Business_Layer;
using DataAccessLibrary.Entity;
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
        private Account selectedAccount { get; set; }

        public AccountForm()
        {
            InitializeComponent();
        }

        public void addAccountsToDatagridviewFromClient()
        {
            dataGridViewAccount.DataSource = userClient.GetAccounts();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            ModifyAccountForm modifyAccountForm = SendUserClientToModifyForm();

            modifyAccountForm.isAdd = true;

            FormChanger.OpenForm(modifyAccountForm);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ModifyAccountForm modifyAccountForm = SendUserClientToModifyForm();

            modifyAccountForm.isEdit = true;

            modifyAccountForm.selectedAccount = selectedAccount;

            FormChanger.OpenForm(modifyAccountForm);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            userClient.DeleteAccount(selectedAccount);

            addAccountsToDatagridviewFromClient();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            addAccountsToDatagridviewFromClient();
        }

        private ModifyAccountForm SendUserClientToModifyForm()
        {
            ModifyAccountForm modifyAccount = new ModifyAccountForm();

            modifyAccount.userClient = userClient;

            return modifyAccount;
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedAccount = dataGridViewAccount.SelectedRows[0].DataBoundItem as Account;
        }


    }
}
