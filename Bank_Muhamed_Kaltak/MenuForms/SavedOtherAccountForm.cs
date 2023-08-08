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

        public SavedOtherAccountForm()
        {
            InitializeComponent();
        }

        private void buttonAddOtherAccount_Click(object sender, EventArgs e)
        {
            GetToRetrieveOtherAccountForm();
        }

        private void GetToRetrieveOtherAccountForm()
        {
            RetrieveOtherAccountForm retrieveOtherAccountForm = new RetrieveOtherAccountForm();

            retrieveOtherAccountForm.userClient = userClient;

            FormChanger.OpenPopupForm(retrieveOtherAccountForm);
        }


    }
}
