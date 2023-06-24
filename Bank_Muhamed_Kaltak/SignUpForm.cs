using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Tulpep.NotificationWindow;

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
            RegistrationManager registrationManager = new RegistrationManager();



            if (registrationManager.Register(textBoxUsername.Text, textBoxPassword.Text, textBoxName.Text, textBoxLastName.Text, textBoxEmail.Text))
            {
                UINotification.Popup(Color.Green, "Registered", "Successfully registered to the database!");

                LoginForm loginForm = new LoginForm();
                FormChanger.ChangeForm(this,loginForm);

            }
            else
            {
                UINotification.Popup(Color.Red,"Invalid Fields", "Make sure that the fields are not empty");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            FormChanger.ChangeForm(this, loginForm);
        }



        
    }
}
