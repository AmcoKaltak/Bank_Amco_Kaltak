using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            buttonSave.Select();
        }

        private void ChangeUsernameForm_Load(object sender, EventArgs e)
        {
            textBoxUsername_Click(sender, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidField())
            {
                ChangeUsername();
            }

        }

        private bool ValidField()
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                UINotification.Popup(Color.Red, "ERROR", "The text field cannot be empty or only contain whitespaces");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxUsername, panelUsername);
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            SaveIfEnterPressed(sender, e);
        }

        private void SaveIfEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangeUsername();
            }
        }

        private void ChangeUsername()
        {
            

            if (userClient.settings.ChangeUsername(textBoxUsername.Text.Replace(" ","")))
            {
                UINotification.Popup(Color.Green, "Succesfully changed username", "Your username has succesfully been changed");

                settingsForm.userClient = userClient;
                settingsForm.GetUserData();

                FormChanger.CloseForm(this);
            }
            else
            {
                UINotification.Popup(Color.Red, "ERROR", "Could not change your username, try to use another username");
            }
        }
    }
}
