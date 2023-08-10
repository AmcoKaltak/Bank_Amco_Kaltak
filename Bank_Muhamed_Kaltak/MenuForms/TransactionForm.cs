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
    public partial class TransactionForm : Form
    {
        public UserClient userClient { get; set; }

        public bool isAccountTransactions { get; set; }

        private bool inAll,inSend,inReceive;

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            inSection(ref inAll);

            if (isAccountTransactions)
            {
                GetAccountTransactions();
            }
            else
            {
                GetUserTransactions();
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            inSection(ref inAll);

            if (isAccountTransactions)
            {
                GetAccountTransactions();
            }
            else
            {
                GetUserTransactions();
            }
        }

        private void buttonSent_Click(object sender, EventArgs e)
        {
            inSection(ref inSend);

            if (isAccountTransactions)
            {
                GetAccountSentTransactions();
            }
            else
            {
                GetUserSentTransactions();
            }
        }

        private void buttonReceived_Click(object sender, EventArgs e)
        {
            inSection(ref inReceive);

            if (isAccountTransactions)
            {
                GetAccountReceivedTransactions();
            }
            else
            {
                GetUserReceivedTransactions();
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            ChangeToTransactionDetail();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (isAccountTransactions)
            {
                SearchForAccountTransactions();
            }
            else
            {
                SearchForUserTransactions();
            }
        }

        private void dataGridViewTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userClient.selectedTransaction = (DataAccessLibrary.Entity.Transaction)dataGridViewTransaction.SelectedRows[0].DataBoundItem;
        }

        private void dataGridViewTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userClient.selectedTransaction = (DataAccessLibrary.Entity.Transaction)dataGridViewTransaction.SelectedRows[0].DataBoundItem;

            ChangeToTransactionDetail();
        }

        private void textBoxSearchTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isAccountTransactions)
            {
                SearchForAccountTransactions();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SearchForUserTransactions();
            }
        }

        private void GetUserTransactions()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetUserTransactions(userClient.user);
        }

        private void GetUserSentTransactions()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetUserSentTransactions(userClient.user);
        }

        private void GetUserReceivedTransactions()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetUserReceivedTransactions(userClient.user);
        }

        private void GetAccountTransactions()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetAccountTransactions(userClient.selectedAccount);
        }

        private void GetAccountSentTransactions()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetAccountSentTransactions(userClient.selectedAccount);
        }

        private void GetAccountReceivedTransactions()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetAccountReceivedTransactions(userClient.selectedAccount);
        }

        private void SearchForUserTransactions()
        {
            if (inAll)
            {
                SearchUserTransactionAll();
            }
            else if (inSend)
            {
                SearchUserTransactionSent();
            }
            else
            {
                SearchUserTransactionReceived();
            }
        }

        private void SearchUserTransactionAll()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetUserSearchedTransactionsAll(userClient.user, textBoxSearchTransaction.Text);
        }

        private void SearchUserTransactionSent()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetUserSearchedTransactionsSent(userClient.user, textBoxSearchTransaction.Text);
        }

        private void SearchUserTransactionReceived()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetUserSearchedTransactionsReceived(userClient.user, textBoxSearchTransaction.Text);
        }

        private void SearchForAccountTransactions()
        {
            if (inAll)
            {
                SearchAccountTransactionAll();
            }
            else if (inSend)
            {
                SearchAccountTransactionSent();
            }
            else
            {
                SearchAccountTransactionReceived();
            }
        }

        private void SearchAccountTransactionAll()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetAccountSearchedTransactionsAll(userClient.selectedAccount, textBoxSearchTransaction.Text);

        }

        private void SearchAccountTransactionSent()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetAccountSearchedTransactionsSent(userClient.selectedAccount, textBoxSearchTransaction.Text);

        }

        private void SearchAccountTransactionReceived()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetAccountSearchedTransactionsReceived(userClient.selectedAccount, textBoxSearchTransaction.Text);

        }

        private void ChangeToTransactionDetail()
        {

            if (SelectedTransactionValid())
            {
                TransactionDetailForm transactionDetail = new TransactionDetailForm();

                transactionDetail.userClient = userClient;

                FormChanger.OpenForm(transactionDetail);
            }

        }

        private bool SelectedTransactionValid()
        {
            if (userClient.selectedTransaction != null)
            {
                return true;
            }

            UINotification.Popup(Color.Red, "ERROR", "You have not selected an account");
            return false;
        }

        private void inSection(ref bool inWhere)
        {
            inAll = false;
            inSend = false;
            inReceive = false;

            inWhere = true;
        }
    }
}
