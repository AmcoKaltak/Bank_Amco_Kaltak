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
    public partial class SignUpForm : Form
    {

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //FormChanger.ChangeForm(this, new LoginForm());
            FormChanger.CloseForm(this);
        }


        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxUsername, panelUsername);
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxPassword, panelPassword);
        }

        private void textBoxName_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxName, panelName);
        }

        private void textBoxLastName_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxLastName, panelLastName);
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxEmail, panelEmail);
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            textBoxUsername_Click(sender, e);
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Register();
            }
        }

        private void Register()
        {
            RegistrationManager registrationManager = new RegistrationManager();


            if (registrationManager.Register(textBoxUsername.Text, textBoxPassword.Text, textBoxName.Text, textBoxLastName.Text, textBoxEmail.Text))
            {
                UINotification.Popup(Color.Green, "Registered", "Successfully registered to the database!");

                FormChanger.CloseForm(this);

            }
            else
            {
                UINotification.Popup(Color.Red, "Invalid Fields", "Make sure that the fields are not empty");
            }
        }
    }
}
