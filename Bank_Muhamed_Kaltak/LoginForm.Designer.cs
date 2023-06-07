namespace Bank_Muhamed_Kaltak
{
    partial class LoginForm
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
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(412, 274);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(78, 33);
            this.buttonSignUp.TabIndex = 13;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(310, 204);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 16);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(310, 222);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(180, 23);
            this.textBoxPassword.TabIndex = 11;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Verdana Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(310, 116);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(75, 16);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(310, 134);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(180, 23);
            this.textBoxUsername.TabIndex = 9;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(310, 274);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(78, 33);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(350, 160);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 14);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Login Credentials?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonLogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSignUp;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Button buttonLogin;
        private LinkLabel linkLabel1;
    }
}