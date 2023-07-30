namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class MakeTransactionForm
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
            panelSelectFromAccount = new Panel();
            pictureBox2 = new PictureBox();
            labelAccountFromMoney = new Label();
            labelAccountFromCode = new Label();
            labelAccountFromName = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            panelSelectToAccount = new Panel();
            labelAccountToMoney = new Label();
            labelAccountToCode = new Label();
            labelAccountToName = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            textBoxTransactionAmount = new TextBox();
            buttonCancel = new Button();
            buttonCommitTransaction = new Button();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            textBoxTransactionName = new TextBox();
            panelSelectFromAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelSelectToAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panelSelectFromAccount
            // 
            panelSelectFromAccount.BackColor = SystemColors.Control;
            panelSelectFromAccount.Controls.Add(pictureBox2);
            panelSelectFromAccount.Controls.Add(labelAccountFromMoney);
            panelSelectFromAccount.Controls.Add(labelAccountFromCode);
            panelSelectFromAccount.Controls.Add(labelAccountFromName);
            panelSelectFromAccount.Cursor = Cursors.Hand;
            panelSelectFromAccount.Location = new Point(202, 88);
            panelSelectFromAccount.Name = "panelSelectFromAccount";
            panelSelectFromAccount.Size = new Size(480, 64);
            panelSelectFromAccount.TabIndex = 7;
            panelSelectFromAccount.Click += panelSelectFromAccount_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bank_account3;
            pictureBox2.Location = new Point(3, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // labelAccountFromMoney
            // 
            labelAccountFromMoney.AutoSize = true;
            labelAccountFromMoney.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccountFromMoney.Location = new Point(379, 21);
            labelAccountFromMoney.Name = "labelAccountFromMoney";
            labelAccountFromMoney.Size = new Size(64, 18);
            labelAccountFromMoney.TabIndex = 15;
            labelAccountFromMoney.Text = "1000000";
            // 
            // labelAccountFromCode
            // 
            labelAccountFromCode.AutoSize = true;
            labelAccountFromCode.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccountFromCode.Location = new Point(54, 36);
            labelAccountFromCode.Name = "labelAccountFromCode";
            labelAccountFromCode.Size = new Size(152, 18);
            labelAccountFromCode.TabIndex = 14;
            labelAccountFromCode.Text = "287731-3124wads-31";
            // 
            // labelAccountFromName
            // 
            labelAccountFromName.AutoSize = true;
            labelAccountFromName.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccountFromName.Location = new Point(54, 10);
            labelAccountFromName.Name = "labelAccountFromName";
            labelAccountFromName.Size = new Size(107, 18);
            labelAccountFromName.TabIndex = 11;
            labelAccountFromName.Text = "Account Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell Nova Cond", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSkyBlue;
            label5.Location = new Point(294, 28);
            label5.Name = "label5";
            label5.Size = new Size(304, 41);
            label5.TabIndex = 10;
            label5.Text = "Make a new transaction";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 67);
            label1.Name = "label1";
            label1.Size = new Size(44, 18);
            label1.TabIndex = 6;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(202, 168);
            label2.Name = "label2";
            label2.Size = new Size(23, 18);
            label2.TabIndex = 11;
            label2.Text = "To";
            // 
            // panelSelectToAccount
            // 
            panelSelectToAccount.BackColor = SystemColors.Control;
            panelSelectToAccount.Controls.Add(labelAccountToMoney);
            panelSelectToAccount.Controls.Add(labelAccountToCode);
            panelSelectToAccount.Controls.Add(labelAccountToName);
            panelSelectToAccount.Controls.Add(pictureBox1);
            panelSelectToAccount.Cursor = Cursors.Hand;
            panelSelectToAccount.Location = new Point(202, 189);
            panelSelectToAccount.Name = "panelSelectToAccount";
            panelSelectToAccount.Size = new Size(480, 64);
            panelSelectToAccount.TabIndex = 12;
            panelSelectToAccount.Click += panelSelectToAccount_Click;
            // 
            // labelAccountToMoney
            // 
            labelAccountToMoney.AutoSize = true;
            labelAccountToMoney.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccountToMoney.Location = new Point(379, 21);
            labelAccountToMoney.Name = "labelAccountToMoney";
            labelAccountToMoney.Size = new Size(64, 18);
            labelAccountToMoney.TabIndex = 15;
            labelAccountToMoney.Text = "1000000";
            // 
            // labelAccountToCode
            // 
            labelAccountToCode.AutoSize = true;
            labelAccountToCode.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccountToCode.Location = new Point(54, 36);
            labelAccountToCode.Name = "labelAccountToCode";
            labelAccountToCode.Size = new Size(152, 18);
            labelAccountToCode.TabIndex = 14;
            labelAccountToCode.Text = "287731-3124wads-31";
            // 
            // labelAccountToName
            // 
            labelAccountToName.AutoSize = true;
            labelAccountToName.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccountToName.Location = new Point(54, 10);
            labelAccountToName.Name = "labelAccountToName";
            labelAccountToName.Size = new Size(107, 18);
            labelAccountToName.TabIndex = 11;
            labelAccountToName.Text = "Account Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bank_account2;
            pictureBox1.Location = new Point(3, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(textBoxTransactionAmount);
            panel2.Location = new Point(202, 331);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 45);
            panel2.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.money;
            pictureBox3.Location = new Point(6, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // textBoxTransactionAmount
            // 
            textBoxTransactionAmount.BorderStyle = BorderStyle.None;
            textBoxTransactionAmount.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTransactionAmount.Location = new Point(36, 16);
            textBoxTransactionAmount.Name = "textBoxTransactionAmount";
            textBoxTransactionAmount.PlaceholderText = "Enter amount";
            textBoxTransactionAmount.Size = new Size(434, 20);
            textBoxTransactionAmount.TabIndex = 9;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightSkyBlue;
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(272, 397);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(163, 35);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonCommitTransaction
            // 
            buttonCommitTransaction.BackColor = Color.LightSkyBlue;
            buttonCommitTransaction.Cursor = Cursors.Hand;
            buttonCommitTransaction.FlatStyle = FlatStyle.Flat;
            buttonCommitTransaction.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCommitTransaction.ForeColor = Color.White;
            buttonCommitTransaction.Location = new Point(441, 397);
            buttonCommitTransaction.Name = "buttonCommitTransaction";
            buttonCommitTransaction.Size = new Size(163, 35);
            buttonCommitTransaction.TabIndex = 14;
            buttonCommitTransaction.Text = "Send Transaction";
            buttonCommitTransaction.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(textBoxTransactionName);
            panel3.Location = new Point(202, 280);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 45);
            panel3.TabIndex = 14;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.transaction_name;
            pictureBox4.Location = new Point(6, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // textBoxTransactionName
            // 
            textBoxTransactionName.BorderStyle = BorderStyle.None;
            textBoxTransactionName.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTransactionName.Location = new Point(36, 16);
            textBoxTransactionName.Name = "textBoxTransactionName";
            textBoxTransactionName.PlaceholderText = "Enter Transaction Name (optional)";
            textBoxTransactionName.Size = new Size(434, 20);
            textBoxTransactionName.TabIndex = 9;
            // 
            // MakeTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(panelSelectFromAccount);
            Controls.Add(panel3);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCommitTransaction);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panelSelectToAccount);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "MakeTransactionForm";
            Text = "MakeTransactionForm";
            Load += MakeTransactionForm_Load;
            panelSelectFromAccount.ResumeLayout(false);
            panelSelectFromAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelSelectToAccount.ResumeLayout(false);
            panelSelectToAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSelectFromAccount;
        private Label label5;
        private Label label1;
        private Label labelAccountFromMoney;
        private Label labelAccountFromCode;
        private Label labelAccountFromName;
        private Label label2;
        private Panel panelSelectToAccount;
        private Label labelAccountToMoney;
        private Label labelAccountToCode;
        private Label labelAccountToName;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private TextBox textBoxTransactionAmount;
        private Button buttonCancel;
        private Button buttonCommitTransaction;
        private Panel panel3;
        private PictureBox pictureBox4;
        private TextBox textBoxTransactionName;
        private PictureBox pictureBox2;
    }
}