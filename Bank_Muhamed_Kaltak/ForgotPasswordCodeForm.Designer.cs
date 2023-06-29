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
            buttonCode = new Button();
            labelCode = new Label();
            textBoxCode = new TextBox();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // buttonCode
            // 
            buttonCode.Font = new Font("Verdana Pro Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCode.Location = new Point(281, 227);
            buttonCode.Name = "buttonCode";
            buttonCode.Size = new Size(78, 33);
            buttonCode.TabIndex = 33;
            buttonCode.Text = "Submit";
            buttonCode.UseVisualStyleBackColor = true;
            buttonCode.Click += buttonCode_Click;
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Verdana Pro", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCode.Location = new Point(179, 162);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(80, 16);
            labelCode.TabIndex = 32;
            labelCode.Text = "Enter Code";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(179, 180);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(180, 23);
            textBoxCode.TabIndex = 31;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Verdana Pro Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.Location = new Point(179, 227);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(78, 33);
            buttonCancel.TabIndex = 30;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ForgotPasswordCodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(buttonCode);
            Controls.Add(labelCode);
            Controls.Add(textBoxCode);
            Controls.Add(buttonCancel);
            Name = "ForgotPasswordCodeForm";
            Text = "ForgotPasswordCodeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCode;
        private Label labelCode;
        private TextBox textBoxCode;
        private Button buttonCancel;
    }
}