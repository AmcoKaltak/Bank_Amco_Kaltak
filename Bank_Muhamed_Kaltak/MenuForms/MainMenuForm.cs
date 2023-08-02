using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Muhamed_Kaltak.MenuForms
{
    public partial class MainMenuForm : Form
    {
        public UserClient userClient { get; set; }

        private int borderSize = 2;
        private Size formSize; //Ha koll på form storleken när man minimerar och expanderar, sparar värdet innan man minimerar och återställer det när man maximerar.

        public MainMenuForm()
        {
            InitializeComponent();

            this.Padding = new Padding(borderSize); //Border storlek

            FormChanger.activePanel = panelMainMenu;
            FormChanger.activeForm = null;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;

            ChangeToHome();
        }

        private void MainMenuForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }



        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            CollapseOrExpandMenu();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormChanger.ChangeForm(this, new LoginForm());
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximera formen (Efter)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Återställ formen (Efter)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void CollapseOrExpandMenu()
        {
            if (this.panelSideMenu.Width > 200) //Kollapsa menyn
            {
                panelSideMenu.Width = 100;
                pictureBox1.Visible = false;
                buttonMenu.Dock = DockStyle.Top;

                CollapseButtonsInPanel(panelSideMenu);
                CollapseButtonsInPanel(panelTransactionSubMenu);
            }
            else
            { //Expandera menyn

                panelSideMenu.Width = 230;
                pictureBox1.Visible = true;
                buttonMenu.Dock = DockStyle.None;

                ExpandButtonsInPanel(panelSideMenu);
                ExpandButtonsInPanel(panelTransactionSubMenu);

            }
        }

        private void CollapseButtonsInPanel(Panel panel)
        {
            foreach (Button menuButton in panel.Controls.OfType<Button>())
            {
                menuButton.Text = "";
                menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                menuButton.Padding = new Padding(0);
            }
        }

        private void ExpandButtonsInPanel(Panel panel)
        {
            foreach (Button menuButton in panel.Controls.OfType<Button>())
            {
                menuButton.Text = "   " + menuButton.Tag.ToString();
                menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                menuButton.Padding = new Padding(10, 0, 0, 0);
            }
        }

        protected override void WndProc(ref Message m) // https://learn.microsoft.com/en-us/windows/win32/winmsg/wm-nccalcsize
        {
            const int WM_NCCALCSIZE = 0x0083;//Standard Title Bar
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimera form (Tidigare)
            const int SC_RESTORE = 0xF120; //Återställ form (Tidigare)
            const int WM_NCHITTEST = 0x0084;//Win32, Mus Input Notifiering: Bestämmer vilken del av windowen som korresponderar till en punkt, gör så att man kan adjustera storleken.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Ändra Storlek/WM_NCHITTEST values
            const int HTCLIENT = 1; //Representerar client delen av windowen
            const int HTLEFT = 10;  //Vänstra delen av windowen, tillåter justeringar horisontellt
            const int HTRIGHT = 11; //Högra delen av windowen, tillåter justeringar horisontellt åt höger
            const int HTTOP = 12;   //Övre-horisontella delen av windowen, tillåter justeringar vertikalt upp 
            const int HTTOPLEFT = 13;//Övre-vänstra delen av windowen, tillåter justeringar diagonalt åt vänster
            const int HTTOPRIGHT = 14;//Övre-högre delen av windowen, tillåter justeringar diagonalt åt höger
            const int HTBOTTOM = 15; //Nedre-horisontella delen av windowen, tillåter justeringar vertikalt ner
            const int HTBOTTOMLEFT = 16;//Nedre-vänstre delen av windowen, tillåter justeringar diagonalt åt vänster
            const int HTBOTTOMRIGHT = 17;//Nedre-högre delen av windowen, tillåter justeringar diagonalt åt höger
            ///<Doc> Mer informaton: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //Om windowen m är WM_NCHITTEST dvs mus pekaren
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Ändra storleken på formen om det är i normala skedett
                {
                    if ((int)m.Result == HTCLIENT)//Om resultatet av m (mus pekaren) är i klient arean av windowen
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Hämtar skärm punkt koordinaterna(X och Y koordinater av mus pekaren)                         
                        Point clientPoint = this.PointToClient(screenPoint); //Räknar ut lokationen av skräm punkten in till klient koordinaterna                        
                        if (clientPoint.Y <= resizeAreaSize)//Om pekaren är vid övre delen av formen (inom resizeAreaSize X koordinaten)
                        {
                            if (clientPoint.X <= resizeAreaSize) //Om pekaren är vid koordinaten x=0 eller mindre än resizing area (x = 10)
                                m.Result = (IntPtr)HTTOPLEFT; //Ändra storleken diagonalt åt vänster
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//Om pekaren är vid koordinaten x = 11 eller mindre än bredden av formen (X = Form.Width - resizeArea)
                                m.Result = (IntPtr)HTTOP; //Ändra storleken vertikalt upp
                            else //Ändra storleken åt höger
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) // Om pekaren är inuti formen vid y koordinaten
                        {
                            if (clientPoint.X <= resizeAreaSize)//Ändra storleken åt vänster
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Ändra storleken åt höger
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Ändra storleken diagonalt åt vänster
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Ändra storleken vertikalt ner
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Ändra storleken diagonalt åt höger
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Ta bort bordern och behåll snap windowen
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Behåll ursprungliga form storleken när det är minimerat eller maximerat
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <Doc> Mer information="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Tidigare
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Återställ formen(Tidigare)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }



        private void ChangeToHome()
        {
            labelDashboard.Text = "Home";

            HomeForm homeForm = new HomeForm();

            homeForm.LabelUserFullNameValue = $"Hello {userClient.user.Name} {userClient.user.LastName} !";
            homeForm.addAccountsToDatagridviewFromClient(userClient);


            FormChanger.OpenForm(homeForm);
        }

        private void ChangeToAccount()
        {
            labelDashboard.Text = "Account";

            AccountForm accountForm = new AccountForm();

            accountForm.userClient = userClient;

            FormChanger.OpenForm(accountForm);

        }

        private void ChangeToMakeTransaction()
        {
            labelDashboard.Text = "Transaction";

            MakeTransactionForm makeTransactionForm = new MakeTransactionForm();

            makeTransactionForm.userClient = userClient;

            FormChanger.OpenForm(makeTransactionForm);
        }

        private void ChangeToTransaction()
        {
            labelDashboard.Text = "Transaction";

            TransactionForm transactionForm = new TransactionForm();

            FormChanger.OpenForm(transactionForm);
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            ChangeToAccount();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            ChangeToHome();
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            if (panelTransactionSubMenu.Size.Height < 109)
            {
                panelTransactionSubMenu.Size = panelTransactionSubMenu.MaximumSize;

            }
            else
            {
                panelTransactionSubMenu.Size = panelTransactionSubMenu.MinimumSize;
            }
        }

        private void buttonMakeTransaction_Click(object sender, EventArgs e)
        {
            ChangeToMakeTransaction();
        }

        private void buttonViewTransaction_Click(object sender, EventArgs e)
        {
            ChangeToTransaction();
        }
    }
}
