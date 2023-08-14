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
    public partial class ChangePasswordForm : Form
    {
        public UserClient userClient;

        public SettingsForm settingsForm;

        public ChangePasswordForm()
        {
            InitializeComponent();

            buttonSave.Select();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void ChangePassword()
        {

        }
    }
}
