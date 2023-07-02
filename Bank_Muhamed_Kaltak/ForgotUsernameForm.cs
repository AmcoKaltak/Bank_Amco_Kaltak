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
    public partial class ForgotUsernameForm : Form
    {
        public ForgotUsernameForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            EmailManager emailManager = new EmailManager();

            emailManager.SendUsername(textBoxEmail.Text);

            UINotification.Popup(Color.Green, "Succesfully sent username", "Username has been sent to the specified email adress");//Man ska ej nämna om det lyckades eller ej för att ge så lite
            //- information som möljigt till hackare

            FormChanger.CloseForm(this);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormChanger.CloseForm(this);
        }
    }
}
