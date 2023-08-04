namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class AccountForm
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
            accountBindingSource = new BindingSource(components);
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonAddAccount = new Button();
            dataGridViewAccount = new DataGridView();
            buttonSearch = new Button();
            panelSearchAccount = new Panel();
            pictureBox2 = new PictureBox();
            textBoxSearchAccount = new TextBox();
            buttonExternalAccount = new Button();
            buttonDetail = new Button();
            accountBindingSource1 = new BindingSource(components);
            accountBindingSource2 = new BindingSource(components);
            Id = new DataGridViewTextBoxColumn();
            AccountName = new DataGridViewTextBoxColumn();
            Money = new DataGridViewTextBoxColumn();
            AccountCode = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).BeginInit();
            panelSearchAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(DataAccessLibrary.Entity.Account);
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.BackColor = Color.LightSkyBlue;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(773, 110);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(85, 35);
            buttonEdit.TabIndex = 20;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.BackColor = Color.LightSkyBlue;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(773, 151);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(85, 35);
            buttonDelete.TabIndex = 19;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddAccount.BackColor = Color.LightSkyBlue;
            buttonAddAccount.Cursor = Cursors.Hand;
            buttonAddAccount.FlatStyle = FlatStyle.Flat;
            buttonAddAccount.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddAccount.ForeColor = Color.White;
            buttonAddAccount.Location = new Point(773, 69);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(85, 35);
            buttonAddAccount.TabIndex = 18;
            buttonAddAccount.Text = "Add";
            buttonAddAccount.UseVisualStyleBackColor = false;
            buttonAddAccount.Click += buttonAddAccount_Click;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana Pro Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccount.Columns.AddRange(new DataGridViewColumn[] { Id, AccountName, Money, AccountCode });
            dataGridViewAccount.DataSource = accountBindingSource2;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAccount.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAccount.EnableHeadersVisualStyles = false;
            dataGridViewAccount.Location = new Point(30, 69);
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
            dataGridViewAccount.TabIndex = 17;
            dataGridViewAccount.CellClick += dataGridViewAccount_CellClick;
            dataGridViewAccount.CellDoubleClick += dataGridViewAccount_CellDoubleClick;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.BackColor = Color.LightSkyBlue;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(619, 26);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(148, 35);
            buttonSearch.TabIndex = 16;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // panelSearchAccount
            // 
            panelSearchAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSearchAccount.BackColor = SystemColors.Control;
            panelSearchAccount.Controls.Add(pictureBox2);
            panelSearchAccount.Controls.Add(textBoxSearchAccount);
            panelSearchAccount.Location = new Point(30, 26);
            panelSearchAccount.Name = "panelSearchAccount";
            panelSearchAccount.Size = new Size(583, 37);
            panelSearchAccount.TabIndex = 15;
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
            textBoxSearchAccount.PlaceholderText = "Search Account";
            textBoxSearchAccount.Size = new Size(544, 20);
            textBoxSearchAccount.TabIndex = 9;
            textBoxSearchAccount.KeyDown += textBoxSearchAccount_KeyDown;
            // 
            // buttonExternalAccount
            // 
            buttonExternalAccount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExternalAccount.BackColor = Color.LightSkyBlue;
            buttonExternalAccount.Cursor = Cursors.Hand;
            buttonExternalAccount.FlatStyle = FlatStyle.Flat;
            buttonExternalAccount.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExternalAccount.ForeColor = Color.White;
            buttonExternalAccount.Location = new Point(773, 402);
            buttonExternalAccount.Name = "buttonExternalAccount";
            buttonExternalAccount.Size = new Size(85, 48);
            buttonExternalAccount.TabIndex = 26;
            buttonExternalAccount.Text = "External account";
            buttonExternalAccount.UseVisualStyleBackColor = false;
            // 
            // buttonDetail
            // 
            buttonDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDetail.BackColor = Color.LightSkyBlue;
            buttonDetail.Cursor = Cursors.Hand;
            buttonDetail.FlatStyle = FlatStyle.Flat;
            buttonDetail.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDetail.ForeColor = Color.White;
            buttonDetail.Location = new Point(773, 192);
            buttonDetail.Name = "buttonDetail";
            buttonDetail.Size = new Size(85, 35);
            buttonDetail.TabIndex = 27;
            buttonDetail.Text = "Details";
            buttonDetail.UseVisualStyleBackColor = false;
            // 
            // accountBindingSource1
            // 
            accountBindingSource1.DataSource = typeof(DataAccessLibrary.Entity.Account);
            // 
            // accountBindingSource2
            // 
            accountBindingSource2.DataSource = typeof(DataAccessLibrary.Entity.Account);
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // AccountName
            // 
            AccountName.DataPropertyName = "AccountName";
            AccountName.HeaderText = "AccountName";
            AccountName.Name = "AccountName";
            AccountName.ReadOnly = true;
            // 
            // Money
            // 
            Money.DataPropertyName = "Money";
            Money.HeaderText = "Money";
            Money.Name = "Money";
            Money.ReadOnly = true;
            // 
            // AccountCode
            // 
            AccountCode.DataPropertyName = "AccountCode";
            AccountCode.HeaderText = "AccountCode";
            AccountCode.Name = "AccountCode";
            AccountCode.ReadOnly = true;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(buttonDetail);
            Controls.Add(buttonExternalAccount);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAddAccount);
            Controls.Add(dataGridViewAccount);
            Controls.Add(buttonSearch);
            Controls.Add(panelSearchAccount);
            Name = "AccountForm";
            Text = "AccountForm";
            Load += AccountForm_Load;
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).EndInit();
            panelSearchAccount.ResumeLayout(false);
            panelSearchAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource accountBindingSource;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonAddAccount;
        private DataGridView dataGridViewAccount;
        private Button buttonSearch;
        private Panel panelSearchAccount;
        private PictureBox pictureBox2;
        private TextBox textBoxSearchAccount;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private Button buttonExternalAccount;
        private Button buttonDetail;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn AccountName;
        private DataGridViewTextBoxColumn Money;
        private DataGridViewTextBoxColumn AccountCode;
        private BindingSource accountBindingSource2;
        private BindingSource accountBindingSource1;
    }
}