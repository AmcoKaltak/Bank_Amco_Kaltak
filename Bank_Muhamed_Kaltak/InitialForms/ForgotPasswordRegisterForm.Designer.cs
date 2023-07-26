namespace Bank_Muhamed_Kaltak
{
    partial class ForgotPasswordRegisterForm
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
            label5 = new Label();
            panelNewPassword = new Panel();
            pictureBox2 = new PictureBox();
            textBoxNewPassword = new TextBox();
            panelConfirmPassword = new Panel();
            pictureBox3 = new PictureBox();
            textBoxConfirmPassword = new TextBox();
            buttonCancel = new Button();
            buttonRegister = new Button();
            panelNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelConfirmPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell Nova Cond", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(99, 80);
            label5.Name = "label5";
            label5.Size = new Size(255, 41);
            label5.TabIndex = 14;
            label5.Text = "Enter new password";
            // 
            // panelNewPassword
            // 
            panelNewPassword.BackColor = Color.White;
            panelNewPassword.Controls.Add(pictureBox2);
            panelNewPassword.Controls.Add(textBoxNewPassword);
            panelNewPassword.Location = new Point(2, 252);
            panelNewPassword.Name = "panelNewPassword";
            panelNewPassword.Size = new Size(480, 45);
            panelNewPassword.TabIndex = 15;
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
            // textBoxNewPassword
            // 
            textBoxNewPassword.BorderStyle = BorderStyle.None;
            textBoxNewPassword.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNewPassword.Location = new Point(36, 16);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PlaceholderText = "Enter a new password";
            textBoxNewPassword.Size = new Size(434, 20);
            textBoxNewPassword.TabIndex = 9;
            textBoxNewPassword.UseSystemPasswordChar = true;
            textBoxNewPassword.Click += textBoxNewPassword_Click;
            textBoxNewPassword.KeyDown += textBoxNewPassword_KeyDown;
            // 
            // panelConfirmPassword
            // 
            panelConfirmPassword.BackColor = Color.White;
            panelConfirmPassword.Controls.Add(pictureBox3);
            panelConfirmPassword.Controls.Add(textBoxConfirmPassword);
            panelConfirmPassword.Location = new Point(2, 303);
            panelConfirmPassword.Name = "panelConfirmPassword";
            panelConfirmPassword.Size = new Size(480, 45);
            panelConfirmPassword.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.Location = new Point(5, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.BorderStyle = BorderStyle.None;
            textBoxConfirmPassword.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConfirmPassword.Location = new Point(35, 14);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PlaceholderText = "Confirm the password";
            textBoxConfirmPassword.Size = new Size(434, 20);
            textBoxConfirmPassword.TabIndex = 11;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            textBoxConfirmPassword.Click += textBoxConfirmPassword_Click;
            textBoxConfirmPassword.KeyDown += textBoxConfirmPassword_KeyDown;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightSkyBlue;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(74, 443);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 35);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.LightSkyBlue;
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(228, 443);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(148, 35);
            buttonRegister.TabIndex = 17;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // ForgotPasswordRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 561);
            Controls.Add(label5);
            Controls.Add(panelNewPassword);
            Controls.Add(panelConfirmPassword);
            Controls.Add(buttonCancel);
            Controls.Add(buttonRegister);
            Name = "ForgotPasswordRegisterForm";
            Text = "ForgotPasswordRegisterForm";
            Load += ForgotPasswordRegisterForm_Load;
            panelNewPassword.ResumeLayout(false);
            panelNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelConfirmPassword.ResumeLayout(false);
            panelConfirmPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panelNewPassword;
        private PictureBox pictureBox2;
        private TextBox textBoxNewPassword;
        private Panel panelConfirmPassword;
        private PictureBox pictureBox3;
        private TextBox textBoxConfirmPassword;
        private Button buttonCancel;
        private Button buttonRegister;
    }
}