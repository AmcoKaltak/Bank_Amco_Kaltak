namespace Bank_Muhamed_Kaltak
{
    partial class ForgotPasswordCodeForm
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
            panelCode = new Panel();
            pictureBox5 = new PictureBox();
            textBoxCode = new TextBox();
            label5 = new Label();
            buttonSubmitCode = new Button();
            panelCode.SuspendLayout();
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
            buttonCancel.Location = new Point(69, 443);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 35);
            buttonCancel.TabIndex = 23;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panelCode
            // 
            panelCode.BackColor = Color.White;
            panelCode.Controls.Add(pictureBox5);
            panelCode.Controls.Add(textBoxCode);
            panelCode.Location = new Point(2, 252);
            panelCode.Name = "panelCode";
            panelCode.Size = new Size(480, 45);
            panelCode.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.coding;
            pictureBox5.Location = new Point(5, 10);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // textBoxCode
            // 
            textBoxCode.BorderStyle = BorderStyle.None;
            textBoxCode.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCode.Location = new Point(35, 14);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.PlaceholderText = "Enter your code";
            textBoxCode.Size = new Size(434, 20);
            textBoxCode.TabIndex = 11;
            textBoxCode.Click += textBoxCode_Click;
            textBoxCode.KeyDown += textBoxCode_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell Nova Cond", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(69, 80);
            label5.Name = "label5";
            label5.Size = new Size(349, 41);
            label5.TabIndex = 20;
            label5.Text = "Enter the code that was sent";
            // 
            // buttonSubmitCode
            // 
            buttonSubmitCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSubmitCode.BackColor = Color.LightSkyBlue;
            buttonSubmitCode.Cursor = Cursors.Hand;
            buttonSubmitCode.FlatStyle = FlatStyle.Flat;
            buttonSubmitCode.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSubmitCode.ForeColor = Color.White;
            buttonSubmitCode.Location = new Point(237, 443);
            buttonSubmitCode.Name = "buttonSubmitCode";
            buttonSubmitCode.Size = new Size(148, 35);
            buttonSubmitCode.TabIndex = 21;
            buttonSubmitCode.Text = "Submit";
            buttonSubmitCode.UseVisualStyleBackColor = false;
            buttonSubmitCode.Click += buttonSubmitCode_Click;
            // 
            // ForgotPasswordCodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 561);
            Controls.Add(buttonCancel);
            Controls.Add(panelCode);
            Controls.Add(label5);
            Controls.Add(buttonSubmitCode);
            Name = "ForgotPasswordCodeForm";
            Text = "ForgotPasswordCodeForm";
            Load += ForgotPasswordCodeForm_Load;
            panelCode.ResumeLayout(false);
            panelCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Panel panelCode;
        private PictureBox pictureBox5;
        private TextBox textBoxCode;
        private Label label5;
        private Button buttonSubmitCode;
    }
}