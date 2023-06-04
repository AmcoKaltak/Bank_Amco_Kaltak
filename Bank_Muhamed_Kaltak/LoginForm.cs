using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using DataAccessLibrary.Entity;

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
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            FormChanger.ChangeForm(this, signUpForm);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginManager loginManager = new LoginManager();
            User user = new User();

            user = loginManager.LogIn(textBoxUsername.Text, textBoxPassword.Text);


            if (user != null)
            {
                SignUpForm signUpForm = new SignUpForm();
                FormChanger.ChangeForm(this, signUpForm);
            }

            //if (String.Equals(test.username,textBoxUsername.Text) && String.Equals(test.username,textBoxPassword.Text))
            //{
            //    this.Hide();
            //    SignUpForm signUpForm = new SignUpForm();
            //    signUpForm.ShowDialog();
            //    this.Close();
            //}
        }

        private void linkCredentials_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
