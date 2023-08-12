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
    public partial class OtherAccountDetail : Form
    {
        public UserClient userClient;

        public OtherAccountDetail()
        {
            InitializeComponent();
        }

        private void OtherAccountDetail_Load(object sender, EventArgs e)
        {
            GetSelectedAccountDetails();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void GetSelectedAccountDetails()
        {
            if (userClient != null)
            {
                var user = userClient.accountManager.GetUserFromAccount(userClient.selectedAccount);
                var account = userClient.selectedAccount;

                labelOtherAccountUserFullName.Text = $"{user.Name} {user.LastName}";
                labelOtherAccountUserEmail.Text = user.Email;

                labelOtherAccountName.Text = account.AccountName;
                labelOtherAccountCode.Text = account.AccountCode;
                labelOtherAccountMoney.Text = account.Money.ToString();


            }
        }
    }
}
