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
        TextBox lastMarkedTextBox;
        Panel lastMarkedPanel;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegistrationManager registrationManager = new RegistrationManager();


            if (registrationManager.Register(textBoxUsername.Text, textBoxPassword.Text, textBoxName.Text, textBoxLastName.Text, textBoxEmail.Text))
            {
                UINotification.Popup(Color.Green, "Registered", "Successfully registered to the database!");

                LoginForm loginForm = new LoginForm();
                FormChanger.ChangeForm(this, loginForm);

            }
            else
            {
                UINotification.Popup(Color.Red, "Invalid Fields", "Make sure that the fields are not empty");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormChanger.ChangeForm(this, new LoginForm());
        }

        private void Mark(TextBox textBoxMark, Panel panelMark)
        {

            if (lastMarkedTextBox != null)
            {
                lastMarkedTextBox.BackColor = Color.White;
            }

            if (lastMarkedPanel != null)
            {
                lastMarkedPanel.BackColor = Color.White;
            }

            lastMarkedTextBox = textBoxMark;
            lastMarkedPanel = panelMark;

            textBoxMark.BackColor = SystemColors.Control;
            panelMark.BackColor = SystemColors.Control;

        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            Mark(textBoxUsername, panelUsername);
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            Mark(textBoxPassword, panelPassword);
        }

        private void textBoxName_Click(object sender, EventArgs e)
        {
            Mark(textBoxName, panelName);
        }

        private void textBoxLastName_Click(object sender, EventArgs e)
        {
            Mark(textBoxLastName, panelLastName);
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            Mark(textBoxEmail, panelEmail);
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            textBoxUsername_Click(sender, e);
        }
    }
}
