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
    public partial class SettingsForm : Form
    {
        public UserClient userClient;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void buttonChangeUsername_Click(object sender, EventArgs e)
        {
            GetToChangeUsernameForm();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            GetToChangePasswordForm();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            GetUserData();
        }

        public void GetUserData()
        {
            labelName.Text = $"Name: {userClient.user.Name}";
            labelLastname.Text = $"Last Name: {userClient.user.LastName}";

            labelUsername.Text = $"Username: {userClient.user.Username}";
            labelEmail.Text = $"Email: {userClient.user.Email}";
        }

        private void GetToChangeUsernameForm()
        {
            ChangeUsernameForm changeUsernameForm = new ChangeUsernameForm();

            changeUsernameForm.userClient = userClient;
            changeUsernameForm.settingsForm = this;

            FormChanger.OpenPopupForm(changeUsernameForm);
        }

        private void GetToChangePasswordForm()
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();

            changePasswordForm.userClient = userClient;
            changePasswordForm.settingsForm = this;

            FormChanger.OpenPopupForm(changePasswordForm);
        }
    }
}
