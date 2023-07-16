using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Muhamed_Kaltak.MenuForms;
using Business_Layer;
using DataAccessLibrary.Entity; //Ta bort när projektet är klart -- Testing purposes

namespace Bank_Muhamed_Kaltak
{
    public partial class LoginForm : Form
    {
        User test = new User();

        public LoginForm()
        {
            test.username = "test";
            test.password = "test";
            InitializeComponent();

            FormChanger.activePanel = panelMain;
        }



        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            //FormChanger.ChangeForm(this, new SignUpForm());
            FormChanger.OpenForm(new SignUpForm());
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginManager loginManager = new LoginManager();
            User user = new User();

            user = loginManager.LogIn(textBoxUsername.Text, textBoxPassword.Text);


            if (user != null)
            {
                UINotification.Popup(Color.Green, "Succesful Login", "Logged in to the system");

                MainMenuForm mainMenuForm = new MainMenuForm();

                mainMenuForm.userClient = new UserClient(user);

                FormChanger.ChangeForm(this, mainMenuForm);
            }
            else
            {
                UINotification.Popup(Color.Red, "Failed Login", "Invalid username/password");
            }


            //if (String.Equals(test.username,textBoxUsername.Text) && String.Equals(test.username,textBoxPassword.Text))
            //{
            //    this.Hide();
            //    SignUpForm signUpForm = new SignUpForm();
            //    signUpForm.ShowDialog();
            //    this.Close();
            //}
        }

        private void linkLabelUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormChanger.OpenForm(new ForgotUsernameForm());
        }

        private void linkLabelPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FormChanger.ChangeForm(this, new ForgotPasswordEmailForm());
            FormChanger.OpenForm(new ForgotPasswordEmailForm());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxUsername, panelUsername);
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            UINotification.Mark(textBoxPassword, panelPassword);
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxUsername_Click(sender, e);
        }
    }
}
