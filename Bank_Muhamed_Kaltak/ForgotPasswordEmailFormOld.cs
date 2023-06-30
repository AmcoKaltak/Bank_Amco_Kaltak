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
    public partial class ForgotPasswordEmailFormOld : Form
    {
        public ForgotPasswordEmailFormOld()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormChanger.ChangeForm(this, new LoginForm());
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            EmailManager emailManager = new EmailManager();

            emailManager.SendVerificationCode(textBoxEmail.Text);

            ForgotPasswordCodeFormOld forgotPasswordCodeForm = new ForgotPasswordCodeFormOld();
            forgotPasswordCodeForm.userEmail = textBoxEmail.Text;

            UINotification.Popup(Color.Green, "Succesfully sent verification code", "Verification code has beent sent to the specified email adress");

            //FormChanger.ChangeForm(this, forgotPasswordCodeForm);
            FormChanger.OpenForm(new ForgotPasswordCodeFormOld());
        }
    }
}
