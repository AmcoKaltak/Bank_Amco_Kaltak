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

        public HomeForm()
        {
            InitializeComponent();
        }

        public string LabelUserFullNameValue
        {
            get { return labelUserFullName.Text; }
            set { labelUserFullName.Text = value; }
        }

        public void addAccountsToDatagridviewFromClient(UserClient userClient)
        {

            dataGridView1.DataSource = userClient.getAccounts();

        }

    }
}
