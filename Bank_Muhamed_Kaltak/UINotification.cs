using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace Bank_Muhamed_Kaltak
{
    public static class UINotification
    {
        static TextBox lastMarkedTextBox;
        static Panel lastMarkedPanel;

        public static void Popup(Color color, string title, string body)
        {
            PopupNotifier popupNotifier = new PopupNotifier();

            popupNotifier.BodyColor = color;
            popupNotifier.TitleText = title;
            popupNotifier.TitleColor = Color.White;
            popupNotifier.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popupNotifier.ContentText = body;
            popupNotifier.ContentColor = Color.White;
            popupNotifier.ContentFont = new Font("Century Gothic", 15);
            popupNotifier.Popup();
        }

        public static void Mark(TextBox textBoxMark, Panel panelMark)
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
    }
}
