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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            buttonReceived = new Button();
            buttonDelete = new Button();
            buttonSent = new Button();
            dataGridViewTransaction = new DataGridView();
            buttonSearch = new Button();
            panelSearchAccount = new Panel();
            pictureBox2 = new PictureBox();
            textBoxSearchTransaction = new TextBox();
            transactionBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaction).BeginInit();
            panelSearchAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
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
            // dataGridViewTransaction
            // 
            dataGridViewTransaction.AllowUserToAddRows = false;
            dataGridViewTransaction.AllowUserToDeleteRows = false;
            dataGridViewTransaction.AllowUserToResizeColumns = false;
            dataGridViewTransaction.AllowUserToResizeRows = false;
            dataGridViewTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransaction.AutoGenerateColumns = false;
            dataGridViewTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTransaction.BackgroundColor = Color.White;
            dataGridViewTransaction.BorderStyle = BorderStyle.None;
            dataGridViewTransaction.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTransaction.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana Pro Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransaction.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, transactionDateDataGridViewTextBoxColumn });
            dataGridViewTransaction.DataSource = transactionBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTransaction.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTransaction.EnableHeadersVisualStyles = false;
            dataGridViewTransaction.Location = new Point(30, 60);
            dataGridViewTransaction.Name = "dataGridViewTransaction";
            dataGridViewTransaction.ReadOnly = true;
            dataGridViewTransaction.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewTransaction.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana Pro Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewTransaction.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTransaction.RowTemplate.Height = 25;
            dataGridViewTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTransaction.Size = new Size(737, 386);
            dataGridViewTransaction.TabIndex = 23;
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
            panelSearchAccount.Controls.Add(textBoxSearchTransaction);
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
            // textBoxSearchTransaction
            // 
            textBoxSearchTransaction.BackColor = SystemColors.Control;
            textBoxSearchTransaction.BorderStyle = BorderStyle.None;
            textBoxSearchTransaction.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchTransaction.Location = new Point(36, 8);
            textBoxSearchTransaction.Name = "textBoxSearchTransaction";
            textBoxSearchTransaction.PlaceholderText = "Search Transaction";
            textBoxSearchTransaction.Size = new Size(544, 20);
            textBoxSearchTransaction.TabIndex = 9;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(DataAccessLibrary.Entity.Transaction);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(buttonReceived);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSent);
            Controls.Add(dataGridViewTransaction);
            Controls.Add(buttonSearch);
            Controls.Add(panelSearchAccount);
            Name = "TransactionForm";
            Text = "TransactionForm";
            Load += TransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaction).EndInit();
            panelSearchAccount.ResumeLayout(false);
            panelSearchAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonReceived;
        private Button buttonDelete;
        private Button buttonSent;
        private DataGridView dataGridViewTransaction;
        private Button buttonSearch;
        private Panel panelSearchAccount;
        private PictureBox pictureBox2;
        private TextBox textBoxSearchTransaction;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private BindingSource transactionBindingSource;
    }
}