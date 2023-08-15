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
            labelSenderAccountMoney = new Label();
            labelSenderAccountCode = new Label();
            labelSenderAccountName = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            panelSelectToAccount = new Panel();
            labelReceiverAccountMoney = new Label();
            labelReceiverAccountCode = new Label();
            labelReceiverAccountName = new Label();
            pictureBox1 = new PictureBox();
            panelAmount = new Panel();
            pictureBox3 = new PictureBox();
            textBoxTransactionAmount = new TextBox();
            buttonCommitTransaction = new Button();
            panelTransactionName = new Panel();
            pictureBox4 = new PictureBox();
            textBoxTransactionName = new TextBox();
            panelSelectFromAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelSelectToAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelTransactionName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panelSelectFromAccount
            // 
            panelSelectFromAccount.Anchor = AnchorStyles.None;
            panelSelectFromAccount.BackColor = SystemColors.Control;
            panelSelectFromAccount.Controls.Add(pictureBox2);
            panelSelectFromAccount.Controls.Add(labelSenderAccountMoney);
            panelSelectFromAccount.Controls.Add(labelSenderAccountCode);
            panelSelectFromAccount.Controls.Add(labelSenderAccountName);
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
            pictureBox2.Click += pictureBox2_Click;
            // 
            // labelSenderAccountMoney
            // 
            labelSenderAccountMoney.AutoSize = true;
            labelSenderAccountMoney.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenderAccountMoney.Location = new Point(369, 20);
            labelSenderAccountMoney.Name = "labelSenderAccountMoney";
            labelSenderAccountMoney.Size = new Size(101, 18);
            labelSenderAccountMoney.TabIndex = 15;
            labelSenderAccountMoney.Tag = "Select Sender";
            labelSenderAccountMoney.Text = "Select sender";
            labelSenderAccountMoney.Click += labelSenderAccountMoney_Click;
            // 
            // labelSenderAccountCode
            // 
            labelSenderAccountCode.AutoSize = true;
            labelSenderAccountCode.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenderAccountCode.Location = new Point(54, 36);
            labelSenderAccountCode.Name = "labelSenderAccountCode";
            labelSenderAccountCode.Size = new Size(101, 18);
            labelSenderAccountCode.TabIndex = 14;
            labelSenderAccountCode.Tag = "Select Sender";
            labelSenderAccountCode.Text = "Select sender";
            labelSenderAccountCode.Click += labelSenderAccountCode_Click;
            // 
            // labelSenderAccountName
            // 
            labelSenderAccountName.AutoSize = true;
            labelSenderAccountName.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenderAccountName.Location = new Point(54, 10);
            labelSenderAccountName.Name = "labelSenderAccountName";
            labelSenderAccountName.Size = new Size(101, 18);
            labelSenderAccountName.TabIndex = 11;
            labelSenderAccountName.Tag = "Select Sender";
            labelSenderAccountName.Text = "Select sender";
            labelSenderAccountName.Click += labelSenderAccountName_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
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
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 67);
            label1.Name = "label1";
            label1.Size = new Size(57, 18);
            label1.TabIndex = 6;
            label1.Text = "Sender";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(202, 168);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 11;
            label2.Text = "Receiver";
            // 
            // panelSelectToAccount
            // 
            panelSelectToAccount.Anchor = AnchorStyles.None;
            panelSelectToAccount.BackColor = SystemColors.Control;
            panelSelectToAccount.Controls.Add(labelReceiverAccountMoney);
            panelSelectToAccount.Controls.Add(labelReceiverAccountCode);
            panelSelectToAccount.Controls.Add(labelReceiverAccountName);
            panelSelectToAccount.Controls.Add(pictureBox1);
            panelSelectToAccount.Cursor = Cursors.Hand;
            panelSelectToAccount.Location = new Point(202, 189);
            panelSelectToAccount.Name = "panelSelectToAccount";
            panelSelectToAccount.Size = new Size(480, 64);
            panelSelectToAccount.TabIndex = 12;
            panelSelectToAccount.Tag = "Select Receiver";
            panelSelectToAccount.Click += panelSelectToAccount_Click;
            // 
            // labelReceiverAccountMoney
            // 
            labelReceiverAccountMoney.AutoSize = true;
            labelReceiverAccountMoney.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelReceiverAccountMoney.Location = new Point(369, 20);
            labelReceiverAccountMoney.Name = "labelReceiverAccountMoney";
            labelReceiverAccountMoney.Size = new Size(109, 18);
            labelReceiverAccountMoney.TabIndex = 15;
            labelReceiverAccountMoney.Tag = "Select Receiver";
            labelReceiverAccountMoney.Text = "Select receiver";
            labelReceiverAccountMoney.Click += labelReceiverAccountMoney_Click;
            // 
            // labelReceiverAccountCode
            // 
            labelReceiverAccountCode.AutoSize = true;
            labelReceiverAccountCode.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelReceiverAccountCode.Location = new Point(54, 36);
            labelReceiverAccountCode.Name = "labelReceiverAccountCode";
            labelReceiverAccountCode.Size = new Size(109, 18);
            labelReceiverAccountCode.TabIndex = 14;
            labelReceiverAccountCode.Tag = "Select Receiver";
            labelReceiverAccountCode.Text = "Select receiver";
            labelReceiverAccountCode.Click += labelReceiverAccountCode_Click;
            // 
            // labelReceiverAccountName
            // 
            labelReceiverAccountName.AutoSize = true;
            labelReceiverAccountName.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelReceiverAccountName.Location = new Point(54, 10);
            labelReceiverAccountName.Name = "labelReceiverAccountName";
            labelReceiverAccountName.Size = new Size(109, 18);
            labelReceiverAccountName.TabIndex = 11;
            labelReceiverAccountName.Tag = "Select Receiver";
            labelReceiverAccountName.Text = "Select receiver";
            labelReceiverAccountName.Click += labelReceiverAccountName_Click;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelAmount
            // 
            panelAmount.Anchor = AnchorStyles.None;
            panelAmount.BackColor = Color.White;
            panelAmount.Controls.Add(pictureBox3);
            panelAmount.Controls.Add(textBoxTransactionAmount);
            panelAmount.Location = new Point(202, 331);
            panelAmount.Name = "panelAmount";
            panelAmount.Size = new Size(480, 45);
            panelAmount.TabIndex = 13;
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
            textBoxTransactionAmount.Click += textBoxTransactionAmount_Click;
            textBoxTransactionAmount.KeyDown += textBoxTransactionAmount_KeyDown;
            // 
            // buttonCommitTransaction
            // 
            buttonCommitTransaction.Anchor = AnchorStyles.None;
            buttonCommitTransaction.BackColor = Color.LightSkyBlue;
            buttonCommitTransaction.Cursor = Cursors.Hand;
            buttonCommitTransaction.FlatStyle = FlatStyle.Flat;
            buttonCommitTransaction.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCommitTransaction.ForeColor = Color.White;
            buttonCommitTransaction.Location = new Point(345, 415);
            buttonCommitTransaction.Name = "buttonCommitTransaction";
            buttonCommitTransaction.Size = new Size(163, 35);
            buttonCommitTransaction.TabIndex = 14;
            buttonCommitTransaction.Text = "Send Transaction";
            buttonCommitTransaction.UseVisualStyleBackColor = false;
            buttonCommitTransaction.Click += buttonCommitTransaction_Click;
            // 
            // panelTransactionName
            // 
            panelTransactionName.Anchor = AnchorStyles.None;
            panelTransactionName.BackColor = Color.White;
            panelTransactionName.Controls.Add(pictureBox4);
            panelTransactionName.Controls.Add(textBoxTransactionName);
            panelTransactionName.Location = new Point(202, 280);
            panelTransactionName.Name = "panelTransactionName";
            panelTransactionName.Size = new Size(480, 45);
            panelTransactionName.TabIndex = 14;
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
            textBoxTransactionName.Click += textBoxTransactionName_Click;
            textBoxTransactionName.KeyDown += textBoxTransactionName_KeyDown;
            // 
            // MakeTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(panelSelectFromAccount);
            Controls.Add(panelTransactionName);
            Controls.Add(buttonCommitTransaction);
            Controls.Add(panelAmount);
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
            panelAmount.ResumeLayout(false);
            panelAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelTransactionName.ResumeLayout(false);
            panelTransactionName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSelectFromAccount;
        private Label label5;
        private Label label1;
        private Label labelSenderAccountMoney;
        private Label labelSenderAccountCode;
        private Label labelSenderAccountName;
        private Label label2;
        private Panel panelSelectToAccount;
        private Label labelReceiverAccountMoney;
        private Label labelReceiverAccountCode;
        private Label labelReceiverAccountName;
        private PictureBox pictureBox1;
        private Panel panelAmount;
        private PictureBox pictureBox3;
        private TextBox textBoxTransactionAmount;
        private Button buttonCommitTransaction;
        private Panel panelTransactionName;
        private PictureBox pictureBox4;
        private TextBox textBoxTransactionName;
        private PictureBox pictureBox2;
    }
}