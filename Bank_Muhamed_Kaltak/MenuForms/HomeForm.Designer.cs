namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class HomeForm
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
            buttonCancel = new Button();
            panelEmail = new Panel();
            pictureBox5 = new PictureBox();
            textBoxEmail = new TextBox();
            label5 = new Label();
            buttonSubmit = new Button();
            panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancel.BackColor = Color.LightSkyBlue;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(272, 393);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 35);
            buttonCancel.TabIndex = 23;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Controls.Add(pictureBox5);
            panelEmail.Controls.Add(textBoxEmail);
            panelEmail.Location = new Point(206, 204);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(480, 45);
            panelEmail.TabIndex = 22;
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell Nova Cond", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(321, 32);
            label5.Name = "label5";
            label5.Size = new Size(220, 41);
            label5.TabIndex = 20;
            label5.Text = "Enter your email";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSubmit.BackColor = Color.LightSkyBlue;
            buttonSubmit.Cursor = Cursors.Hand;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSubmit.ForeColor = Color.White;
            buttonSubmit.Location = new Point(511, 393);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(148, 35);
            buttonSubmit.TabIndex = 21;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(buttonCancel);
            Controls.Add(panelEmail);
            Controls.Add(label5);
            Controls.Add(buttonSubmit);
            Name = "HomeForm";
            Text = "Home";
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Panel panelEmail;
        private PictureBox pictureBox5;
        private TextBox textBoxEmail;
        private Label label5;
        private Button buttonSubmit;
    }
}