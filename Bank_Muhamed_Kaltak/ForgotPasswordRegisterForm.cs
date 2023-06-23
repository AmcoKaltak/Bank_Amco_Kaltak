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
            FormChanger.ChangeForm(this, new LoginForm());
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            LoginManager loginManager = new LoginManager();

            if (loginManager.CheckValidVerficationCode(userEmail,enteredCode)) //Checka en sista gång att tokenet är giltigt och att 10 min ej passerat innan lösenordet ändras
            {
                RegistrationManager registrationManager = new RegistrationManager();
                registrationManager.RegisterNewPassword(userEmail, textBoxConfirmPassword.Text);

                MessageBox.Show("Passwords have been changed");

                FormChanger.ChangeForm(this, new LoginForm());
            }
            else
            {
                MessageBox.Show("ERROR: Something Went Wrong");
            }
        }
    }
}
