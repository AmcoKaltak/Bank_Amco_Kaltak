namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class ModifyAccountForm
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
            labelDetail = new Label();
            panelAccountModify = new Panel();
            pictureBox2 = new PictureBox();
            textBoxAccount = new TextBox();
            buttonCancel = new Button();
            buttonSaveChanges = new Button();
            panelAccountModify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelDetail
            // 
            labelDetail.AutoSize = true;
            labelDetail.Font = new Font("Rockwell Nova Cond", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelDetail.ForeColor = Color.LightSkyBlue;
            labelDetail.Location = new Point(284, 40);
            labelDetail.Name = "labelDetail";
            labelDetail.Size = new Size(277, 54);
            labelDetail.TabIndex = 6;
            labelDetail.Text = "Modify Account";
            // 
            // panelAccountModify
            // 
            panelAccountModify.BackColor = SystemColors.Control;
            panelAccountModify.Controls.Add(pictureBox2);
            panelAccountModify.Controls.Add(textBoxAccount);
            panelAccountModify.Location = new Point(186, 177);
            panelAccountModify.Name = "panelAccountModify";
            panelAccountModify.Size = new Size(480, 45);
            panelAccountModify.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.passbook;
            pictureBox2.Location = new Point(6, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBoxAccount
            // 
            textBoxAccount.BackColor = SystemColors.Control;
            textBoxAccount.BorderStyle = BorderStyle.None;
            textBoxAccount.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAccount.Location = new Point(36, 16);
            textBoxAccount.Name = "textBoxAccount";
            textBoxAccount.PlaceholderText = "Modify Account";
            textBoxAccount.Size = new Size(434, 20);
            textBoxAccount.TabIndex = 9;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightSkyBlue;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(222, 298);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(148, 35);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.BackColor = Color.LightSkyBlue;
            buttonSaveChanges.Cursor = Cursors.Hand;
            buttonSaveChanges.FlatStyle = FlatStyle.Flat;
            buttonSaveChanges.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveChanges.ForeColor = Color.White;
            buttonSaveChanges.Location = new Point(444, 298);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(148, 35);
            buttonSaveChanges.TabIndex = 14;
            buttonSaveChanges.Text = "Save";
            buttonSaveChanges.UseVisualStyleBackColor = false;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // ModifyAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSaveChanges);
            Controls.Add(panelAccountModify);
            Controls.Add(labelDetail);
            Name = "ModifyAccountForm";
            Text = "ModifyAccountForm";
            Load += ModifyAccountForm_Load;
            panelAccountModify.ResumeLayout(false);
            panelAccountModify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDetail;
        private Panel panelAccountModify;
        private PictureBox pictureBox2;
        private TextBox textBoxAccount;
        private Button buttonCancel;
        private Button buttonSaveChanges;
    }
}