﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormChanger.ChangeForm(this, new SignUpForm());
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginManager loginManager = new LoginManager();


            if (loginManager.LogIn(textBoxUsername.Text, textBoxPassword.Text))
            {
                UINotification.Popup(Color.Green, "Succesful Login", "Logged in to the system");
                FormChanger.ChangeForm(this, new SignUpForm());
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
            FormChanger.ChangeForm(this, new ForgotUsernameForm());
        }

        private void linkLabelPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormChanger.ChangeForm(this, new ForgotPasswordEmailForm());
        }
    }
}
