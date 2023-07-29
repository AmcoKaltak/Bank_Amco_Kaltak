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
    public partial class MakeTransactionForm : Form
    {
        public UserClient userClient;


        public MakeTransactionForm()
        {
            InitializeComponent();
        }

        private void panelSelectFromAccount_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();

            accountForm.userClient = userClient;
            accountForm.isTransactionAccountSelection = true;

            FormChanger.OpenForm(accountForm);
        }
    }
}
