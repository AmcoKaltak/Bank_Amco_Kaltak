namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class SettingsForm
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
            buttonChangeUsername = new Button();
            buttonChangePassword = new Button();
            buttonDeleteUser = new Button();
            panelSelectFromAccount = new Panel();
            labelLastname = new Label();
            pictureBox2 = new PictureBox();
            labelUsername = new Label();
            labelEmail = new Label();
            labelName = new Label();
            label5 = new Label();
            panelSelectFromAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonChangeUsername
            // 
            buttonChangeUsername.Anchor = AnchorStyles.Bottom;
            buttonChangeUsername.BackColor = Color.LightSkyBlue;
            buttonChangeUsername.Cursor = Cursors.Hand;
            buttonChangeUsername.FlatStyle = FlatStyle.Flat;
            buttonChangeUsername.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChangeUsername.ForeColor = Color.White;
            buttonChangeUsername.Location = new Point(185, 391);
            buttonChangeUsername.Name = "buttonChangeUsername";
            buttonChangeUsername.Size = new Size(158, 59);
            buttonChangeUsername.TabIndex = 15;
            buttonChangeUsername.Text = "Change Username";
            buttonChangeUsername.UseVisualStyleBackColor = false;
            buttonChangeUsername.Click += buttonChangeUsername_Click;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.Anchor = AnchorStyles.Bottom;
            buttonChangePassword.BackColor = Color.LightSkyBlue;
            buttonChangePassword.Cursor = Cursors.Hand;
            buttonChangePassword.FlatStyle = FlatStyle.Flat;
            buttonChangePassword.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChangePassword.ForeColor = Color.White;
            buttonChangePassword.Location = new Point(349, 391);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(158, 59);
            buttonChangePassword.TabIndex = 14;
            buttonChangePassword.Text = "Change Password";
            buttonChangePassword.UseVisualStyleBackColor = false;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Anchor = AnchorStyles.Bottom;
            buttonDeleteUser.BackColor = Color.LightSkyBlue;
            buttonDeleteUser.Cursor = Cursors.Hand;
            buttonDeleteUser.FlatStyle = FlatStyle.Flat;
            buttonDeleteUser.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteUser.ForeColor = Color.Red;
            buttonDeleteUser.Location = new Point(513, 391);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(158, 59);
            buttonDeleteUser.TabIndex = 16;
            buttonDeleteUser.Text = "Delete User";
            buttonDeleteUser.UseVisualStyleBackColor = false;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // panelSelectFromAccount
            // 
            panelSelectFromAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSelectFromAccount.BackColor = SystemColors.Control;
            panelSelectFromAccount.Controls.Add(labelLastname);
            panelSelectFromAccount.Controls.Add(pictureBox2);
            panelSelectFromAccount.Controls.Add(labelUsername);
            panelSelectFromAccount.Controls.Add(labelEmail);
            panelSelectFromAccount.Controls.Add(labelName);
            panelSelectFromAccount.Cursor = Cursors.Hand;
            panelSelectFromAccount.Location = new Point(46, 120);
            panelSelectFromAccount.Name = "panelSelectFromAccount";
            panelSelectFromAccount.Size = new Size(753, 153);
            panelSelectFromAccount.TabIndex = 18;
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Font = new Font("Verdana Pro Cond", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastname.Location = new Point(149, 109);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(108, 23);
            labelLastname.TabIndex = 17;
            labelLastname.Text = "Last Name: ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(13, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // labelUsername
            // 
            labelUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Verdana Pro Cond", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(445, 27);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(104, 23);
            labelUsername.TabIndex = 15;
            labelUsername.Text = "Username: ";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Verdana Pro Cond", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(445, 109);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(66, 23);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email: ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Verdana Pro Cond", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(149, 27);
            labelName.Name = "labelName";
            labelName.Size = new Size(69, 23);
            labelName.TabIndex = 11;
            labelName.Text = "Name: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell Nova Cond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(46, 87);
            label5.Name = "label5";
            label5.Size = new Size(144, 30);
            label5.TabIndex = 19;
            label5.Text = "Logged in user";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(label5);
            Controls.Add(panelSelectFromAccount);
            Controls.Add(buttonDeleteUser);
            Controls.Add(buttonChangeUsername);
            Controls.Add(buttonChangePassword);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            panelSelectFromAccount.ResumeLayout(false);
            panelSelectFromAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonChangeUsername;
        private Button buttonChangePassword;
        private Button buttonDeleteUser;
        private Panel panelSelectFromAccount;
        private PictureBox pictureBox2;
        private Label labelUsername;
        private Label labelEmail;
        private Label labelName;
        private Label labelLastname;
        private Label label5;
    }
}