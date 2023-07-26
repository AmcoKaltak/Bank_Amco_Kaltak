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
    public partial class ForgotPasswordEmailForm : Form
    {
        public ForgotPasswordEmailForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SendVerificationCodeToEmail();
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxEmail, panelEmail);
        }

        private void ForgotPasswordEmailForm_Load(object sender, EventArgs e)
        {
            textBoxEmail_Click(sender, e);
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendVerificationCodeToEmail();
            }
        }

        private void SendVerificationCodeToEmail()
        {
            EmailManager emailManager = new EmailManager();

            emailManager.SendVerificationCode(textBoxEmail.Text);

            ForgotPasswordCodeForm forgotPasswordCodeForm = new ForgotPasswordCodeForm();
            forgotPasswordCodeForm.userEmail = textBoxEmail.Text;

            UINotification.Popup(Color.Green, "Succesfully sent verification code", "Verification code has beent sent to the specified email adress");

            //FormChanger.ChangeForm(this, forgotPasswordCodeForm);
            FormChanger.OpenForm(forgotPasswordCodeForm);
        }
    }
}
