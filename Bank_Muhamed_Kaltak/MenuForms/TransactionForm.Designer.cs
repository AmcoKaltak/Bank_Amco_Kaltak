namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class TransactionForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            buttonReceived = new Button();
            buttonDelete = new Button();
            buttonSent = new Button();
            dataGridViewAccount = new DataGridView();
            buttonSearch = new Button();
            panelSearchAccount = new Panel();
            pictureBox2 = new PictureBox();
            textBoxSearchAccount = new TextBox();
            buttonMakeTransaction = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).BeginInit();
            panelSearchAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonReceived
            // 
            buttonReceived.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReceived.BackColor = Color.LightSkyBlue;
            buttonReceived.Cursor = Cursors.Hand;
            buttonReceived.FlatStyle = FlatStyle.Flat;
            buttonReceived.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReceived.ForeColor = Color.White;
            buttonReceived.Location = new Point(773, 101);
            buttonReceived.Name = "buttonReceived";
            buttonReceived.Size = new Size(92, 35);
            buttonReceived.TabIndex = 26;
            buttonReceived.Text = "Received";
            buttonReceived.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.BackColor = Color.LightSkyBlue;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(773, 142);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(92, 35);
            buttonDelete.TabIndex = 25;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonSent
            // 
            buttonSent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSent.BackColor = Color.LightSkyBlue;
            buttonSent.Cursor = Cursors.Hand;
            buttonSent.FlatStyle = FlatStyle.Flat;
            buttonSent.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSent.ForeColor = Color.White;
            buttonSent.Location = new Point(773, 60);
            buttonSent.Name = "buttonSent";
            buttonSent.Size = new Size(92, 35);
            buttonSent.TabIndex = 24;
            buttonSent.Text = "Sent";
            buttonSent.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAccount
            // 
            dataGridViewAccount.AllowUserToAddRows = false;
            dataGridViewAccount.AllowUserToDeleteRows = false;
            dataGridViewAccount.AllowUserToResizeColumns = false;
            dataGridViewAccount.AllowUserToResizeRows = false;
            dataGridViewAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAccount.BackgroundColor = Color.White;
            dataGridViewAccount.BorderStyle = BorderStyle.None;
            dataGridViewAccount.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana Pro Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAccount.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAccount.EnableHeadersVisualStyles = false;
            dataGridViewAccount.Location = new Point(30, 60);
            dataGridViewAccount.Name = "dataGridViewAccount";
            dataGridViewAccount.ReadOnly = true;
            dataGridViewAccount.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewAccount.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana Pro Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewAccount.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAccount.RowTemplate.Height = 25;
            dataGridViewAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAccount.Size = new Size(737, 386);
            dataGridViewAccount.TabIndex = 23;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.LightSkyBlue;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(619, 17);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(148, 35);
            buttonSearch.TabIndex = 22;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // panelSearchAccount
            // 
            panelSearchAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSearchAccount.BackColor = SystemColors.Control;
            panelSearchAccount.Controls.Add(pictureBox2);
            panelSearchAccount.Controls.Add(textBoxSearchAccount);
            panelSearchAccount.Location = new Point(30, 17);
            panelSearchAccount.Name = "panelSearchAccount";
            panelSearchAccount.Size = new Size(583, 37);
            panelSearchAccount.TabIndex = 21;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.passbook;
            pictureBox2.Location = new Point(6, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBoxSearchAccount
            // 
            textBoxSearchAccount.BackColor = SystemColors.Control;
            textBoxSearchAccount.BorderStyle = BorderStyle.None;
            textBoxSearchAccount.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchAccount.Location = new Point(36, 8);
            textBoxSearchAccount.Name = "textBoxSearchAccount";
            textBoxSearchAccount.PlaceholderText = "Search Transaction";
            textBoxSearchAccount.Size = new Size(544, 20);
            textBoxSearchAccount.TabIndex = 9;
            // 
            // buttonMakeTransaction
            // 
            buttonMakeTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMakeTransaction.BackColor = Color.LightSkyBlue;
            buttonMakeTransaction.Cursor = Cursors.Hand;
            buttonMakeTransaction.FlatStyle = FlatStyle.Flat;
            buttonMakeTransaction.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMakeTransaction.ForeColor = Color.White;
            buttonMakeTransaction.Location = new Point(771, 241);
            buttonMakeTransaction.Name = "buttonMakeTransaction";
            buttonMakeTransaction.Size = new Size(114, 49);
            buttonMakeTransaction.TabIndex = 27;
            buttonMakeTransaction.Text = "Make a new Transaction";
            buttonMakeTransaction.UseVisualStyleBackColor = false;
            buttonMakeTransaction.Click += buttonMakeTransaction_Click;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(buttonMakeTransaction);
            Controls.Add(buttonReceived);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSent);
            Controls.Add(dataGridViewAccount);
            Controls.Add(buttonSearch);
            Controls.Add(panelSearchAccount);
            Name = "TransactionForm";
            Text = "TransactionForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).EndInit();
            panelSearchAccount.ResumeLayout(false);
            panelSearchAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonReceived;
        private Button buttonDelete;
        private Button buttonSent;
        private DataGridView dataGridViewAccount;
        private Button buttonSearch;
        private Panel panelSearchAccount;
        private PictureBox pictureBox2;
        private TextBox textBoxSearchAccount;
        private Button buttonMakeTransaction;
    }
}