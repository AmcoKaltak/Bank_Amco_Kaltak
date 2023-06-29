namespace Bank_Muhamed_Kaltak
{
    partial class SignUpForm
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
            panelUsername = new Panel();
            pictureBox2 = new PictureBox();
            textBoxUsername = new TextBox();
            panelPassword = new Panel();
            pictureBox3 = new PictureBox();
            textBoxPassword = new TextBox();
            buttonCancel = new Button();
            buttonRegister = new Button();
            panelLastName = new Panel();
            pictureBox1 = new PictureBox();
            textBoxLastName = new TextBox();
            panelName = new Panel();
            pictureBox4 = new PictureBox();
            textBoxName = new TextBox();
            panelEmail = new Panel();
            pictureBox5 = new PictureBox();
            textBoxEmail = new TextBox();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelLastName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell Nova Cond", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(77, 28);
            label5.Name = "label5";
            label5.Size = new Size(294, 41);
            label5.TabIndex = 14;
            label5.Text = "Register a new account";
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.White;
            panelUsername.Controls.Add(pictureBox2);
            panelUsername.Controls.Add(textBoxUsername);
            panelUsername.Location = new Point(1, 128);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(480, 45);
            panelUsername.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(6, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(36, 16);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Enter your username";
            textBoxUsername.Size = new Size(434, 20);
            textBoxUsername.TabIndex = 9;
            textBoxUsername.Click += textBoxUsername_Click;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.Controls.Add(pictureBox3);
            panelPassword.Controls.Add(textBoxPassword);
            panelPassword.Location = new Point(1, 189);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(480, 45);
            panelPassword.TabIndex = 16;
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
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(35, 14);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Enter your password";
            textBoxPassword.Size = new Size(434, 20);
            textBoxPassword.TabIndex = 11;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Click += textBoxPassword_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancel.BackColor = Color.LightSkyBlue;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(88, 514);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 35);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRegister.BackColor = Color.LightSkyBlue;
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(242, 514);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(148, 35);
            buttonRegister.TabIndex = 17;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // panelLastName
            // 
            panelLastName.BackColor = Color.White;
            panelLastName.Controls.Add(pictureBox1);
            panelLastName.Controls.Add(textBoxLastName);
            panelLastName.Location = new Point(1, 314);
            panelLastName.Name = "panelLastName";
            panelLastName.Size = new Size(480, 45);
            panelLastName.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.id_card;
            pictureBox1.Location = new Point(5, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BorderStyle = BorderStyle.None;
            textBoxLastName.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(35, 14);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Enter your last name";
            textBoxLastName.Size = new Size(434, 20);
            textBoxLastName.TabIndex = 11;
            textBoxLastName.UseSystemPasswordChar = true;
            textBoxLastName.Click += textBoxLastName_Click;
            // 
            // panelName
            // 
            panelName.BackColor = Color.White;
            panelName.Controls.Add(pictureBox4);
            panelName.Controls.Add(textBoxName);
            panelName.Location = new Point(1, 252);
            panelName.Name = "panelName";
            panelName.Size = new Size(480, 45);
            panelName.TabIndex = 15;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.id_card1;
            pictureBox4.Location = new Point(6, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(36, 16);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Enter your name";
            textBoxName.Size = new Size(434, 20);
            textBoxName.TabIndex = 9;
            textBoxName.Click += textBoxName_Click;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Controls.Add(pictureBox5);
            panelEmail.Controls.Add(textBoxEmail);
            panelEmail.Location = new Point(1, 389);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(480, 45);
            panelEmail.TabIndex = 16;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.email;
            pictureBox5.Location = new Point(5, 10);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(35, 14);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Enter your email";
            textBoxEmail.Size = new Size(434, 20);
            textBoxEmail.TabIndex = 11;
            textBoxEmail.UseSystemPasswordChar = true;
            textBoxEmail.Click += textBoxEmail_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 561);
            Controls.Add(label5);
            Controls.Add(panelName);
            Controls.Add(panelEmail);
            Controls.Add(panelLastName);
            Controls.Add(panelUsername);
            Controls.Add(panelPassword);
            Controls.Add(buttonCancel);
            Controls.Add(buttonRegister);
            Name = "SignUpForm";
            Text = "SignUpForm";
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelLastName.ResumeLayout(false);
            panelLastName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelName.ResumeLayout(false);
            panelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panelUsername;
        private PictureBox pictureBox2;
        private TextBox textBoxUsername;
        private Panel panelPassword;
        private PictureBox pictureBox3;
        private TextBox textBoxPassword;
        private Button buttonCancel;
        private Button buttonRegister;
        private Panel panelLastName;
        private PictureBox pictureBox1;
        private TextBox textBoxLastName;
        private Panel panelName;
        private PictureBox pictureBox4;
        private TextBox textBoxName;
        private Panel panelEmail;
        private PictureBox pictureBox5;
        private TextBox textBoxEmail;
    }
}