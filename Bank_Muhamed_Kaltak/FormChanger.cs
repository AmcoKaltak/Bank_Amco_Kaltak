using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Muhamed_Kaltak
{
    public static class FormChanger
    {

        public static void ChangeForm(Form existingForm, Form newForm)
        {
            existingForm.Hide();
            newForm.ShowDialog();
            existingForm.Close();
        }
    }
}
