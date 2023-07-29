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
            ModifyAccountForm modifyAccountForm = SendUserClientToModifyForm();

            modifyAccountForm.isEdit = true;

            FormChanger.OpenForm(modifyAccountForm);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            userClient.DeleteAccount(userClient.account);

            AddAccountsToDatagridviewFromClient();
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userClient.account = (DataAccessLibrary.Entity.Account)dataGridViewAccount.SelectedRows[0].DataBoundItem;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            AddAccountsToDatagridviewFromClient();
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
            dataGridViewAccount.DataSource = userClient.GetAccounts();
        }

        private ModifyAccountForm SendUserClientToModifyForm()
        {
            ModifyAccountForm modifyAccount = new ModifyAccountForm();

            modifyAccount.userClient = userClient;

            return modifyAccount;
        }



        private void SearchAccount()
        {
            dataGridViewAccount.DataSource = userClient.GetSearchedAccounts(textBoxSearchAccount.Text);
        }
    }
}
