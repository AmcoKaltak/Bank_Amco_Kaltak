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
    public partial class ChangeUsernameForm : Form
    {

        public UserClient userClient;
        public SettingsForm settingsForm;

        public ChangeUsernameForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (userClient.settings.ChangeUsername(textBoxUsername.Text))
            {
                UINotification.Popup(Color.Green, "Succesfully changed username", "Your username has succesfully been changed");

                settingsForm.userClient = userClient;
                settingsForm.GetUserData();

                CloseForm();
            }
            else
            {
                UINotification.Popup(Color.Red, "ERROR", "Could not change your username, try to use another username");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            FormChanger.CloseForm(this);
        }
    }
}
