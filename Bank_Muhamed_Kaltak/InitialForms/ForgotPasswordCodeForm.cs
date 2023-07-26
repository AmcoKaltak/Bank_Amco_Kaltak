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
    public partial class ForgotPasswordCodeForm : Form
    {
        public string userEmail { get; set; }

        public ForgotPasswordCodeForm()
        {
            InitializeComponent();
        }

        private void buttonSubmitCode_Click(object sender, EventArgs e)
        {
            SubmitCode();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //FormChanger.ChangeForm(this, new LoginForm());
            FormChanger.CloseForm(this);
        }

        private void textBoxCode_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxCode, panelCode);
        }

        private void ForgotPasswordCodeForm_Load(object sender, EventArgs e)
        {
            textBoxCode_Click(sender, e);
        }

        private void textBoxCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitCode();
            }
        }

        private void SubmitCode()
        {
            LoginManager loginManager = new LoginManager();

            if (loginManager.CheckValidVerficationCode(userEmail, textBoxCode.Text))
            {
                ForgotPasswordRegisterForm forgotPasswordRegisterForm = new ForgotPasswordRegisterForm();
                forgotPasswordRegisterForm.userEmail = userEmail;
                forgotPasswordRegisterForm.enteredCode = textBoxCode.Text;

                FormChanger.OpenForm(forgotPasswordRegisterForm);
            }
            else
            {
                UINotification.Popup(Color.Red, "ERROR", "INVALID CODE");
            }
        }
    }
}
