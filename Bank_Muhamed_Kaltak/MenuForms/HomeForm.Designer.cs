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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            accountBindingSource = new BindingSource(components);
            accountBindingSource1 = new BindingSource(components);
            dataGridViewAccount = new DataGridView();
            accountNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            moneyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountBindingSource2 = new BindingSource(components);
            dataGridViewTransaction = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionsBindingSource = new BindingSource(components);
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(DataAccessLibrary.Entity.Account);
            // 
            // accountBindingSource1
            // 
            accountBindingSource1.DataSource = typeof(DataAccessLibrary.Entity.Account);
            // 
            // dataGridViewAccount
            // 
            dataGridViewAccount.AllowUserToAddRows = false;
            dataGridViewAccount.AllowUserToDeleteRows = false;
            dataGridViewAccount.AllowUserToResizeColumns = false;
            dataGridViewAccount.AllowUserToResizeRows = false;
            dataGridViewAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAccount.AutoGenerateColumns = false;
            dataGridViewAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAccount.BackgroundColor = Color.White;
            dataGridViewAccount.BorderStyle = BorderStyle.None;
            dataGridViewAccount.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new Font("Verdana Pro Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccount.Columns.AddRange(new DataGridViewColumn[] { accountNameDataGridViewTextBoxColumn, moneyDataGridViewTextBoxColumn, accountCodeDataGridViewTextBoxColumn });
            dataGridViewAccount.DataSource = accountBindingSource2;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewAccount.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewAccount.EnableHeadersVisualStyles = false;
            dataGridViewAccount.Location = new Point(7, 49);
            dataGridViewAccount.Name = "dataGridViewAccount";
            dataGridViewAccount.ReadOnly = true;
            dataGridViewAccount.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewAccount.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Verdana Pro Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewAccount.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewAccount.RowTemplate.Height = 25;
            dataGridViewAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAccount.Size = new Size(869, 178);
            dataGridViewAccount.TabIndex = 22;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            accountNameDataGridViewTextBoxColumn.HeaderText = "Name";
            accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountCodeDataGridViewTextBoxColumn
            // 
            accountCodeDataGridViewTextBoxColumn.DataPropertyName = "AccountCode";
            accountCodeDataGridViewTextBoxColumn.HeaderText = "AccountCode";
            accountCodeDataGridViewTextBoxColumn.Name = "accountCodeDataGridViewTextBoxColumn";
            accountCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountBindingSource2
            // 
            accountBindingSource2.DataSource = typeof(DataAccessLibrary.Entity.Account);
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle10.Font = new Font("Verdana Pro Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransaction.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, transactionDateDataGridViewTextBoxColumn });
            dataGridViewTransaction.DataSource = transactionsBindingSource;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridViewTransaction.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTransaction.EnableHeadersVisualStyles = false;
            dataGridViewTransaction.Location = new Point(7, 272);
            dataGridViewTransaction.Name = "dataGridViewTransaction";
            dataGridViewTransaction.ReadOnly = true;
            dataGridViewTransaction.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewTransaction.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Verdana Pro Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewTransaction.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTransaction.RowTemplate.Height = 25;
            dataGridViewTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTransaction.Size = new Size(869, 178);
            dataGridViewTransaction.TabIndex = 23;
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
            // transactionsBindingSource
            // 
            transactionsBindingSource.DataMember = "Transactions";
            transactionsBindingSource.DataSource = accountBindingSource;
            // 
            // label2
            // 
            label2.Font = new Font("Rockwell Nova Cond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSkyBlue;
            label2.Location = new Point(7, 5);
            label2.Name = "label2";
            label2.Size = new Size(96, 41);
            label2.TabIndex = 24;
            label2.Text = "Accounts";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Rockwell Nova Cond", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSkyBlue;
            label1.Location = new Point(7, 228);
            label1.Name = "label1";
            label1.Size = new Size(131, 41);
            label1.TabIndex = 25;
            label1.Text = "Transactions";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridViewTransaction);
            Controls.Add(dataGridViewAccount);
            Name = "HomeForm";
            Text = "Home";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource accountBindingSource;
        private BindingSource accountBindingSource1;
        private DataGridView dataGridViewAccount;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private BindingSource accountBindingSource2;
        private DataGridView dataGridViewTransaction;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private BindingSource transactionsBindingSource;
        public Label label2;
        public Label label1;
    }
}