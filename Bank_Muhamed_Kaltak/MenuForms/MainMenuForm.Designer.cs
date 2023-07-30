namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideMenu = new Panel();
            buttonSetting = new FontAwesome.Sharp.IconButton();
            buttonContact = new FontAwesome.Sharp.IconButton();
            panelTransactionSubMenu = new Panel();
            buttonViewTransaction = new FontAwesome.Sharp.IconButton();
            buttonMakeTransaction = new FontAwesome.Sharp.IconButton();
            buttonTransaction = new FontAwesome.Sharp.IconButton();
            buttonAccount = new FontAwesome.Sharp.IconButton();
            buttonHome = new FontAwesome.Sharp.IconButton();
            buttonLogout = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            buttonMenu = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panelDashboard = new Panel();
            labelDashboard = new Label();
            buttonMinimize = new FontAwesome.Sharp.IconButton();
            buttonMaximize = new FontAwesome.Sharp.IconButton();
            buttonClose = new FontAwesome.Sharp.IconButton();
            panelMainMenu = new Panel();
            panelSideMenu.SuspendLayout();
            panelTransactionSubMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.LightSkyBlue;
            panelSideMenu.Controls.Add(buttonSetting);
            panelSideMenu.Controls.Add(buttonContact);
            panelSideMenu.Controls.Add(panelTransactionSubMenu);
            panelSideMenu.Controls.Add(buttonAccount);
            panelSideMenu.Controls.Add(buttonHome);
            panelSideMenu.Controls.Add(buttonLogout);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(230, 561);
            panelSideMenu.TabIndex = 0;
            // 
            // buttonSetting
            // 
            buttonSetting.Dock = DockStyle.Top;
            buttonSetting.FlatAppearance.BorderSize = 0;
            buttonSetting.FlatStyle = FlatStyle.Flat;
            buttonSetting.Font = new Font("Verdana Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSetting.ForeColor = Color.White;
            buttonSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            buttonSetting.IconColor = Color.White;
            buttonSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonSetting.IconSize = 30;
            buttonSetting.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSetting.Location = new Point(0, 300);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Padding = new Padding(10, 0, 0, 0);
            buttonSetting.Size = new Size(230, 43);
            buttonSetting.TabIndex = 11;
            buttonSetting.Tag = "Settings";
            buttonSetting.Text = "   Settings";
            buttonSetting.TextAlign = ContentAlignment.MiddleLeft;
            buttonSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSetting.UseVisualStyleBackColor = true;
            // 
            // buttonContact
            // 
            buttonContact.Dock = DockStyle.Top;
            buttonContact.FlatAppearance.BorderSize = 0;
            buttonContact.FlatStyle = FlatStyle.Flat;
            buttonContact.Font = new Font("Verdana Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonContact.ForeColor = Color.White;
            buttonContact.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            buttonContact.IconColor = Color.White;
            buttonContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonContact.IconSize = 30;
            buttonContact.ImageAlign = ContentAlignment.MiddleLeft;
            buttonContact.Location = new Point(0, 257);
            buttonContact.Name = "buttonContact";
            buttonContact.Padding = new Padding(10, 0, 0, 0);
            buttonContact.Size = new Size(230, 43);
            buttonContact.TabIndex = 10;
            buttonContact.Tag = "Contacts";
            buttonContact.Text = "   Contacts";
            buttonContact.TextAlign = ContentAlignment.MiddleLeft;
            buttonContact.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonContact.UseVisualStyleBackColor = true;
            // 
            // panelTransactionSubMenu
            // 
            panelTransactionSubMenu.BackColor = Color.DarkGray;
            panelTransactionSubMenu.Controls.Add(buttonViewTransaction);
            panelTransactionSubMenu.Controls.Add(buttonMakeTransaction);
            panelTransactionSubMenu.Controls.Add(buttonTransaction);
            panelTransactionSubMenu.Dock = DockStyle.Top;
            panelTransactionSubMenu.Location = new Point(0, 214);
            panelTransactionSubMenu.MaximumSize = new Size(0, 109);
            panelTransactionSubMenu.MinimumSize = new Size(0, 43);
            panelTransactionSubMenu.Name = "panelTransactionSubMenu";
            panelTransactionSubMenu.Size = new Size(230, 43);
            panelTransactionSubMenu.TabIndex = 8;
            // 
            // buttonViewTransaction
            // 
            buttonViewTransaction.BackColor = Color.DarkGray;
            buttonViewTransaction.Dock = DockStyle.Top;
            buttonViewTransaction.FlatAppearance.BorderSize = 0;
            buttonViewTransaction.FlatStyle = FlatStyle.Flat;
            buttonViewTransaction.Font = new Font("Verdana Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonViewTransaction.ForeColor = Color.White;
            buttonViewTransaction.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            buttonViewTransaction.IconColor = Color.White;
            buttonViewTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonViewTransaction.IconSize = 30;
            buttonViewTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewTransaction.Location = new Point(0, 76);
            buttonViewTransaction.Name = "buttonViewTransaction";
            buttonViewTransaction.Padding = new Padding(10, 0, 0, 0);
            buttonViewTransaction.Size = new Size(230, 33);
            buttonViewTransaction.TabIndex = 11;
            buttonViewTransaction.Tag = "View Transactions";
            buttonViewTransaction.Text = "   View Transactions";
            buttonViewTransaction.TextAlign = ContentAlignment.MiddleLeft;
            buttonViewTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonViewTransaction.UseVisualStyleBackColor = false;
            buttonViewTransaction.Click += buttonViewTransaction_Click;
            // 
            // buttonMakeTransaction
            // 
            buttonMakeTransaction.BackColor = Color.DarkGray;
            buttonMakeTransaction.Dock = DockStyle.Top;
            buttonMakeTransaction.FlatAppearance.BorderSize = 0;
            buttonMakeTransaction.FlatStyle = FlatStyle.Flat;
            buttonMakeTransaction.Font = new Font("Verdana Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMakeTransaction.ForeColor = Color.White;
            buttonMakeTransaction.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            buttonMakeTransaction.IconColor = Color.White;
            buttonMakeTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonMakeTransaction.IconSize = 30;
            buttonMakeTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMakeTransaction.Location = new Point(0, 43);
            buttonMakeTransaction.Name = "buttonMakeTransaction";
            buttonMakeTransaction.Padding = new Padding(10, 0, 0, 0);
            buttonMakeTransaction.Size = new Size(230, 33);
            buttonMakeTransaction.TabIndex = 10;
            buttonMakeTransaction.Tag = "Make Transaction";
            buttonMakeTransaction.Text = "   Make Transaction";
            buttonMakeTransaction.TextAlign = ContentAlignment.MiddleLeft;
            buttonMakeTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMakeTransaction.UseVisualStyleBackColor = false;
            buttonMakeTransaction.Click += buttonMakeTransaction_Click;
            // 
            // buttonTransaction
            // 
            buttonTransaction.BackColor = Color.LightSkyBlue;
            buttonTransaction.Dock = DockStyle.Top;
            buttonTransaction.FlatAppearance.BorderSize = 0;
            buttonTransaction.FlatStyle = FlatStyle.Flat;
            buttonTransaction.Font = new Font("Verdana Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTransaction.ForeColor = Color.White;
            buttonTransaction.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            buttonTransaction.IconColor = Color.White;
            buttonTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonTransaction.IconSize = 30;
            buttonTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaction.Location = new Point(0, 0);
            buttonTransaction.Name = "buttonTransaction";
            buttonTransaction.Padding = new Padding(10, 0, 0, 0);
            buttonTransaction.Size = new Size(230, 43);
            buttonTransaction.TabIndex = 9;
            buttonTransaction.Tag = "Transaction";
            buttonTransaction.Text = "   Transaction";
            buttonTransaction.TextAlign = ContentAlignment.MiddleLeft;
            buttonTransaction.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonTransaction.UseVisualStyleBackColor = false;
            buttonTransaction.Click += buttonTransaction_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.Dock = DockStyle.Top;
            buttonAccount.FlatAppearance.BorderSize = 0;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Font = new Font("Verdana Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAccount.ForeColor = Color.White;
            buttonAccount.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            buttonAccount.IconColor = Color.White;
            buttonAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonAccount.IconSize = 30;
            buttonAccount.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAccount.Location = new Point(0, 171);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Padding = new Padding(10, 0, 0, 0);
            buttonAccount.Size = new Size(230, 43);
            buttonAccount.TabIndex = 9;
            buttonAccount.Tag = "Accounts";
            buttonAccount.Text = "   Accounts";
            buttonAccount.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAccount.UseVisualStyleBackColor = true;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // buttonHome
            // 
            buttonHome.Dock = DockStyle.Top;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Verdana Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.ForeColor = Color.White;
            buttonHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            buttonHome.IconColor = Color.White;
            buttonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonHome.IconSize = 30;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(0, 128);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(10, 0, 0, 0);
            buttonHome.Size = new Size(230, 43);
            buttonHome.TabIndex = 8;
            buttonHome.Tag = "Home";
            buttonHome.Text = "   Home";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Dock = DockStyle.Bottom;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Verdana Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            buttonLogout.IconColor = Color.White;
            buttonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonLogout.IconSize = 30;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(0, 518);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(10, 0, 0, 15);
            buttonLogout.Size = new Size(230, 43);
            buttonLogout.TabIndex = 7;
            buttonLogout.Tag = "Log out";
            buttonLogout.Text = "   Log out";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(buttonMenu);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(230, 128);
            panelLogo.TabIndex = 0;
            // 
            // buttonMenu
            // 
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            buttonMenu.IconColor = Color.White;
            buttonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonMenu.IconSize = 30;
            buttonMenu.Location = new Point(164, 3);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(60, 60);
            buttonMenu.TabIndex = 1;
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bank2;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.WhiteSmoke;
            panelDashboard.Controls.Add(labelDashboard);
            panelDashboard.Controls.Add(buttonMinimize);
            panelDashboard.Controls.Add(buttonMaximize);
            panelDashboard.Controls.Add(buttonClose);
            panelDashboard.Dock = DockStyle.Top;
            panelDashboard.Location = new Point(230, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(904, 60);
            panelDashboard.TabIndex = 1;
            panelDashboard.MouseDown += panelTitleBar_MouseDown;
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.Font = new Font("Rockwell Nova Cond", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelDashboard.ForeColor = Color.LightSkyBlue;
            labelDashboard.Location = new Point(17, 9);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(149, 41);
            labelDashboard.TabIndex = 6;
            labelDashboard.Text = "Dashboard";
            // 
            // buttonMinimize
            // 
            buttonMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimize.BackColor = Color.WhiteSmoke;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.ForeColor = Color.LightSkyBlue;
            buttonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            buttonMinimize.IconColor = Color.LightSkyBlue;
            buttonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonMinimize.IconSize = 25;
            buttonMinimize.Location = new Point(778, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(45, 25);
            buttonMinimize.TabIndex = 4;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonMaximize
            // 
            buttonMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximize.BackColor = Color.WhiteSmoke;
            buttonMaximize.FlatAppearance.BorderSize = 0;
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.ForeColor = Color.LightSkyBlue;
            buttonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            buttonMaximize.IconColor = Color.LightSkyBlue;
            buttonMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonMaximize.IconSize = 25;
            buttonMaximize.Location = new Point(820, 0);
            buttonMaximize.Name = "buttonMaximize";
            buttonMaximize.Size = new Size(45, 25);
            buttonMaximize.TabIndex = 3;
            buttonMaximize.UseVisualStyleBackColor = false;
            buttonMaximize.Click += buttonMaximize_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.WhiteSmoke;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.ForeColor = Color.LightSkyBlue;
            buttonClose.IconChar = FontAwesome.Sharp.IconChar.X;
            buttonClose.IconColor = Color.LightSkyBlue;
            buttonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonClose.IconSize = 25;
            buttonClose.Location = new Point(859, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(45, 25);
            buttonClose.TabIndex = 2;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // panelMainMenu
            // 
            panelMainMenu.Dock = DockStyle.Fill;
            panelMainMenu.Location = new Point(230, 60);
            panelMainMenu.Name = "panelMainMenu";
            panelMainMenu.Size = new Size(904, 501);
            panelMainMenu.TabIndex = 2;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1134, 561);
            Controls.Add(panelMainMenu);
            Controls.Add(panelDashboard);
            Controls.Add(panelSideMenu);
            MinimumSize = new Size(1150, 600);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            Load += MainMenuForm_Load;
            Resize += MainMenuForm_Resize;
            panelSideMenu.ResumeLayout(false);
            panelTransactionSubMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelDashboard;
        private Panel panelMainMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton buttonLogout;
        private FontAwesome.Sharp.IconButton buttonClose;
        private FontAwesome.Sharp.IconButton buttonMaximize;
        private FontAwesome.Sharp.IconButton buttonMinimize;
        private Label labelDashboard;
        private FontAwesome.Sharp.IconButton buttonMenu;
        private Panel panelTransactionSubMenu;
        private FontAwesome.Sharp.IconButton buttonTransaction;
        private FontAwesome.Sharp.IconButton buttonViewTransaction;
        private FontAwesome.Sharp.IconButton buttonMakeTransaction;
        private FontAwesome.Sharp.IconButton buttonSetting;
        private FontAwesome.Sharp.IconButton buttonContact;
        private FontAwesome.Sharp.IconButton buttonAccount;
        private FontAwesome.Sharp.IconButton buttonHome;
    }
}