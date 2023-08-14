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

        public ChangePasswordForm()
        {
            InitializeComponent();

            buttonSave.Select();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            textBoxCurrentPassword_Click(sender, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void textBoxCurrentPassword_KeyDown(object sender, KeyEventArgs e)
        {
            ChangePasswordIfEnterPressed(sender, e);
        }

        private void textBoxNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            ChangePasswordIfEnterPressed(sender, e);
        }

        private void textBoxConfirmNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            ChangePasswordIfEnterPressed(sender, e);
        }


        private void textBoxCurrentPassword_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxCurrentPassword, panelCurrentPassword);
        }

        private void textBoxNewPassword_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxNewPassword, panelNewPassword);
        }

        private void textBoxConfirmNewPassword_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxConfirmNewPassword, panelConfirmNewPassword);
        }

        private void ChangePasswordIfEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangePassword();
            }
        }

        private void ChangePassword()
        {
            Security security = new Security();

            if (security.CheckValidPassword(textBoxCurrentPassword.Text, userClient.user))
            {
                if (ValidFields())
                {
                    userClient.settings.ChangePassword(security.Hash($"{textBoxNewPassword.Text}{userClient.user.Salt}"));
                    UINotification.Popup(Color.Green, "Succesfully changed passwords", "Your password has been changed");
                    FormChanger.CloseForm(this);
                }
            }
            else
            {
                UINotification.Popup(Color.Red, "ERROR", "Could not change passwords, please try again");
            }
        }

        private bool ValidFields()
        {
            if (!textBoxNewPassword.Text.Equals(textBoxConfirmNewPassword.Text))
            {
                UINotification.Popup(Color.Red, "ERROR", "The new password does not match");
                return false;
            }
            else if (textBoxNewPassword.Text.Contains(" "))
            {
                UINotification.Popup(Color.Red, "ERROR", "The new password cannot have whitespaces");
                return false;
            }
            else if (textBoxConfirmNewPassword.Text.Contains(" "))
            {
                UINotification.Popup(Color.Red, "ERROR", "The new password cannot have whitespaces");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
