namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class ChangePasswordForm
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
            panelUsername = new Panel();
            pictureBox2 = new PictureBox();
            textBoxOldPassword = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBoxNewPassword = new TextBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            textBoxConfirmNewPassword = new TextBox();
            buttonClose = new Button();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.White;
            panelUsername.Controls.Add(pictureBox2);
            panelUsername.Controls.Add(textBoxOldPassword);
            panelUsername.Location = new Point(12, 147);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(460, 45);
            panelUsername.TabIndex = 38;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.padlock;
            pictureBox2.Location = new Point(6, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBoxOldPassword
            // 
            textBoxOldPassword.BorderStyle = BorderStyle.None;
            textBoxOldPassword.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOldPassword.Location = new Point(36, 16);
            textBoxOldPassword.Name = "textBoxOldPassword";
            textBoxOldPassword.PlaceholderText = "Enter current password";
            textBoxOldPassword.Size = new Size(421, 20);
            textBoxOldPassword.TabIndex = 9;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancel.BackColor = Color.LightSkyBlue;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(40, 405);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 35);
            buttonCancel.TabIndex = 40;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.LightSkyBlue;
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(289, 405);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(148, 35);
            buttonSave.TabIndex = 39;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Rockwell Nova Cond", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(129, 31);
            label5.Name = "label5";
            label5.Size = new Size(229, 41);
            label5.TabIndex = 37;
            label5.Text = "Change Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxNewPassword);
            panel1.Location = new Point(12, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 45);
            panel1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.change_password;
            pictureBox1.Location = new Point(6, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.BorderStyle = BorderStyle.None;
            textBoxNewPassword.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNewPassword.Location = new Point(36, 16);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PlaceholderText = "Enter a new password";
            textBoxNewPassword.Size = new Size(421, 20);
            textBoxNewPassword.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(textBoxConfirmNewPassword);
            panel2.Location = new Point(12, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 45);
            panel2.TabIndex = 39;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.change_password;
            pictureBox3.Location = new Point(6, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // textBoxConfirmNewPassword
            // 
            textBoxConfirmNewPassword.BorderStyle = BorderStyle.None;
            textBoxConfirmNewPassword.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConfirmNewPassword.Location = new Point(36, 16);
            textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            textBoxConfirmNewPassword.PlaceholderText = "Confirm the new password";
            textBoxConfirmNewPassword.Size = new Size(421, 20);
            textBoxConfirmNewPassword.TabIndex = 9;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.LightSkyBlue;
            buttonClose.Location = new Point(444, -1);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 41;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(buttonClose);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelUsername);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            TopMost = true;
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUsername;
        private PictureBox pictureBox2;
        private TextBox textBoxOldPassword;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBoxNewPassword;
        private Panel panel2;
        private PictureBox pictureBox3;
        private TextBox textBoxConfirmNewPassword;
        private Button buttonClose;
    }
}