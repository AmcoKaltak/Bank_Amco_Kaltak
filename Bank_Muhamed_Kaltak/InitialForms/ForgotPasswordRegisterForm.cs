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

namespace Bank_Muhamed_Kaltak
{
    public partial class ForgotPasswordRegisterForm : Form
    {

        public string userEmail { get; set; }

        public string enteredCode { get; set; }

        public ForgotPasswordRegisterForm()
        {
            InitializeComponent();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
            {
                UINotification.Popup(Color.Red, "Not Matching Passwords", "The passwords do not match, please try again");

                textBoxNewPassword.Text = "";
                textBoxConfirmPassword.Text = "";

                return;
            }
            else if (string.IsNullOrWhiteSpace(textBoxNewPassword.Text) || string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text))
            {
                UINotification.Popup(Color.Red, "Empty Passwords", "New password cannot be empty");
                return;
            }

            LoginManager loginManager = new LoginManager();

            if (loginManager.CheckValidVerficationCode(userEmail, enteredCode)) //Checka en sista gång att tokenet är giltigt och att 10 min ej passerat innan lösenordet ändras
            {
                RegistrationManager registrationManager = new RegistrationManager();
                registrationManager.RegisterNewPassword(userEmail, textBoxConfirmPassword.Text);

                UINotification.Popup(Color.Green, "Succesfully changed passwords", "Passwords have been changed for your account");

                FormChanger.CloseForm(this);
            }
            else
            {
                UINotification.Popup(Color.Red, "ERROR", "Someting went wrong");
            }
        }

        private void textBoxNewPassword_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxNewPassword, panelNewPassword);
        }

        private void textBoxConfirmPassword_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxConfirmPassword, panelConfirmPassword);
        }

        private void ForgotPasswordRegisterForm_Load(object sender, EventArgs e)
        {
            textBoxNewPassword_Click(sender,e);
        }
    }
}
