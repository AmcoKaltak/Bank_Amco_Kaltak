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

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            GetUserTransactions();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            GetUserTransactions();
        }

        private void buttonSent_Click(object sender, EventArgs e)
        {
            GetUserSentTransactions();
        }

        private void buttonReceived_Click(object sender, EventArgs e)
        {
            GetUserReceivedTransactions();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            ChangeToTransactionDetail();
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

        private void GetUserTransactions()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetTransactions(userClient.user);
        }

        private void GetUserSentTransactions()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetSentTransactions(userClient.user);
        }

        private void GetUserReceivedTransactions()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetReceivedTransactions(userClient.user);
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

    }
}
