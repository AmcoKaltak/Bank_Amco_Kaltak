namespace Bank_Muhamed_Kaltak
{
    partial class SignUpFormOld
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
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            label1 = new Label();
            textBoxLastName = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label4 = new Label();
            textBoxEmail = new TextBox();
            buttonRegister = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Verdana Pro", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(143, 206);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 16);
            labelPassword.TabIndex = 16;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(143, 224);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(180, 23);
            textBoxPassword.TabIndex = 15;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Verdana Pro", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(143, 146);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(75, 16);
            labelUsername.TabIndex = 14;
            labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(143, 164);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(180, 23);
            textBoxUsername.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana Pro", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(143, 327);
            label1.Name = "label1";
            label1.Size = new Size(78, 16);
            label1.TabIndex = 20;
            label1.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(143, 345);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(180, 23);
            textBoxLastName.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana Pro", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(143, 267);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 18;
            label2.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(143, 285);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(180, 23);
            textBoxName.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana Pro", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(143, 385);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 22;
            label4.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(143, 403);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(180, 23);
            textBoxEmail.TabIndex = 21;
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Verdana Pro Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.Location = new Point(234, 448);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(89, 27);
            buttonRegister.TabIndex = 23;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Verdana Pro Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(143, 448);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(89, 27);
            buttonCancel.TabIndex = 24;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // SignUpFormOld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 561);
            Controls.Add(buttonCancel);
            Controls.Add(buttonRegister);
            Controls.Add(label4);
            Controls.Add(textBoxEmail);
            Controls.Add(label1);
            Controls.Add(textBoxLastName);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxUsername);
            Name = "SignUpFormOld";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Label label1;
        private TextBox textBoxLastName;
        private Label label2;
        private TextBox textBoxName;
        private Label label4;
        private TextBox textBoxEmail;
        private Button buttonRegister;
        private Button buttonCancel;
    }
}