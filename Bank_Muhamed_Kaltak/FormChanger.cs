using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Muhamed_Kaltak
{
    public static class FormChanger
    {
        public static Form activeForm;
        public static Panel activePanel;

        public static void ChangeForm(Form existingForm, Form newForm)
        {
            existingForm.Hide();
            newForm.ShowDialog();
            existingForm.Close();
        }

        public static void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            activePanel.Controls.Add(form);
            activePanel.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
