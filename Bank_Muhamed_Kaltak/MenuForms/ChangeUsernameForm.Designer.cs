namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class ChangeUsernameForm
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
            textBoxUsername = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            label5 = new Label();
            buttonClose = new Button();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.White;
            panelUsername.Controls.Add(pictureBox2);
            panelUsername.Controls.Add(textBoxUsername);
            panelUsername.Location = new Point(10, 184);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(460, 45);
            panelUsername.TabIndex = 34;
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
            textBoxUsername.PlaceholderText = "Enter new username";
            textBoxUsername.Size = new Size(421, 20);
            textBoxUsername.TabIndex = 9;
            textBoxUsername.Click += textBoxUsername_Click;
            textBoxUsername.KeyDown += textBoxUsername_KeyDown;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancel.BackColor = Color.LightSkyBlue;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(46, 405);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 35);
            buttonCancel.TabIndex = 36;
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
            buttonSave.Location = new Point(279, 405);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(148, 35);
            buttonSave.TabIndex = 35;
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
            label5.Location = new Point(114, 61);
            label5.Name = "label5";
            label5.Size = new Size(235, 41);
            label5.TabIndex = 33;
            label5.Text = "Change Username";
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
            buttonClose.TabIndex = 38;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // ChangeUsernameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 461);
            Controls.Add(panelUsername);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label5);
            Controls.Add(buttonClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeUsernameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeUsernameForm";
            TopMost = true;
            Load += ChangeUsernameForm_Load;
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUsername;
        private PictureBox pictureBox2;
        private TextBox textBoxUsername;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label5;
        private Button buttonClose;
    }
}