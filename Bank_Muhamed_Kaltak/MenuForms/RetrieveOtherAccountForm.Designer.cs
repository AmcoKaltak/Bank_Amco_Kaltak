namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class RetrieveOtherAccountForm
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
            panelEmail = new Panel();
            pictureBox2 = new PictureBox();
            textBoxEmail = new TextBox();
            buttonCancel = new Button();
            buttonRetrieve = new Button();
            label5 = new Label();
            panelAccountCode = new Panel();
            pictureBox3 = new PictureBox();
            textBoxAccountCode = new TextBox();
            buttonClose = new Button();
            panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAccountCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Controls.Add(pictureBox2);
            panelEmail.Controls.Add(textBoxEmail);
            panelEmail.Location = new Point(12, 162);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(460, 45);
            panelEmail.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.email;
            pictureBox2.Location = new Point(6, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(36, 16);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Enter the connected accounts email";
            textBoxEmail.Size = new Size(421, 20);
            textBoxEmail.TabIndex = 9;
            textBoxEmail.Click += textBoxEmail_Click;
            textBoxEmail.KeyDown += textBoxEmail_KeyDown;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancel.BackColor = Color.LightSkyBlue;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(78, 383);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 35);
            buttonCancel.TabIndex = 30;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonRetrieve
            // 
            buttonRetrieve.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRetrieve.BackColor = Color.LightSkyBlue;
            buttonRetrieve.Cursor = Cursors.Hand;
            buttonRetrieve.FlatStyle = FlatStyle.Flat;
            buttonRetrieve.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRetrieve.ForeColor = Color.White;
            buttonRetrieve.Location = new Point(245, 383);
            buttonRetrieve.Name = "buttonRetrieve";
            buttonRetrieve.Size = new Size(148, 35);
            buttonRetrieve.TabIndex = 29;
            buttonRetrieve.Text = "Retrieve";
            buttonRetrieve.UseVisualStyleBackColor = false;
            buttonRetrieve.Click += buttonRetrieve_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Rockwell Nova Cond", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(4, 60);
            label5.Name = "label5";
            label5.Size = new Size(481, 41);
            label5.TabIndex = 27;
            label5.Text = "Retrieve an account from another user";
            // 
            // panelAccountCode
            // 
            panelAccountCode.BackColor = Color.White;
            panelAccountCode.Controls.Add(pictureBox3);
            panelAccountCode.Controls.Add(textBoxAccountCode);
            panelAccountCode.Location = new Point(12, 213);
            panelAccountCode.Name = "panelAccountCode";
            panelAccountCode.Size = new Size(460, 45);
            panelAccountCode.TabIndex = 31;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.account_code;
            pictureBox3.Location = new Point(5, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // textBoxAccountCode
            // 
            textBoxAccountCode.BorderStyle = BorderStyle.None;
            textBoxAccountCode.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAccountCode.Location = new Point(35, 14);
            textBoxAccountCode.Name = "textBoxAccountCode";
            textBoxAccountCode.PlaceholderText = "Enter the account code";
            textBoxAccountCode.Size = new Size(422, 20);
            textBoxAccountCode.TabIndex = 11;
            textBoxAccountCode.UseSystemPasswordChar = true;
            textBoxAccountCode.Click += textBoxAccountCode_Click;
            textBoxAccountCode.KeyDown += textBoxAccountCode_KeyDown;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.LightSkyBlue;
            buttonClose.Location = new Point(445, -1);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 32;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // RetrieveOtherAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(buttonClose);
            Controls.Add(panelEmail);
            Controls.Add(buttonCancel);
            Controls.Add(buttonRetrieve);
            Controls.Add(label5);
            Controls.Add(panelAccountCode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RetrieveOtherAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RetrieveOtherAccountForm";
            TopMost = true;
            Load += RetrieveOtherAccountForm_Load;
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAccountCode.ResumeLayout(false);
            panelAccountCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelEmail;
        private PictureBox pictureBox2;
        private TextBox textBoxEmail;
        private Button buttonCancel;
        private Button buttonRetrieve;
        private Label label5;
        private Panel panelAccountCode;
        private PictureBox pictureBox3;
        private TextBox textBoxAccountCode;
        private Button buttonClose;
    }
}