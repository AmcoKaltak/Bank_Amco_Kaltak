namespace Bank_Muhamed_Kaltak
{
    partial class ForgotPasswordEmailForm
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
            buttonEmail = new Button();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // buttonEmail
            // 
            buttonEmail.Font = new Font("Verdana Pro Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEmail.Location = new Point(276, 221);
            buttonEmail.Name = "buttonEmail";
            buttonEmail.Size = new Size(78, 33);
            buttonEmail.TabIndex = 29;
            buttonEmail.Text = "Submit";
            buttonEmail.UseVisualStyleBackColor = true;
            buttonEmail.Click += buttonEmail_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Verdana Pro", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(174, 156);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(84, 16);
            labelEmail.TabIndex = 28;
            labelEmail.Text = "Enter Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(174, 174);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(180, 23);
            textBoxEmail.TabIndex = 27;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Verdana Pro Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(174, 221);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(78, 33);
            buttonCancel.TabIndex = 26;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ForgotPasswordEmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(buttonEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonCancel);
            Name = "ForgotPasswordEmailForm";
            Text = "ForgotPasswordEmailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEmail;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Button buttonCancel;
    }
}