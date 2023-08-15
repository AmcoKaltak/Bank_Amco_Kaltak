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
using DataAccessLibrary;
using DataAccessLibrary.Entity;

namespace Bank_Muhamed_Kaltak.MenuForms
{
    public partial class HomeForm : Form
    {

        public UserClient userClient;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            AddAccountsToDatagridviewFromClient();
            AddTransactionsToDatagridViewFromClient();
        }

        private void AddAccountsToDatagridviewFromClient()
        {

            dataGridViewAccount.DataSource = userClient.accountManager.GetAccountsByCount(6);

        }

        private void AddTransactionsToDatagridViewFromClient()
        {
            dataGridViewTransaction.DataSource = userClient.transactionManager.GetUserTransactions();
        }

    }
}
