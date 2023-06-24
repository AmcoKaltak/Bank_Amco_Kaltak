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
        public static void Popup(Color color, string title, string body) //Möljigtvist att jag gör det till en klass och har denna metoden med, om det ska användas i andra pos
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
    }
}
