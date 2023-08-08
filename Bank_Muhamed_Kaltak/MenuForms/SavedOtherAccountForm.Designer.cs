namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class SavedOtherAccountForm
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
            accountBindingSource1 = new BindingSource(components);
            pictureBox2 = new PictureBox();
            textBoxSearchOtherAccount = new TextBox();
            buttonSearch = new Button();
            panelSearchAccount = new Panel();
            accountBindingSource2 = new BindingSource(components);
            accountCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            buttonDelete = new Button();
            buttonAddOtherAccount = new Button();
            dataGridViewOtherAccount = new DataGridView();
            moneyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)accountBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelSearchAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOtherAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            SuspendLayout();
            // 
            // accountBindingSource1
            // 
            accountBindingSource1.DataSource = typeof(DataAccessLibrary.Entity.Account);
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
            // textBoxSearchOtherAccount
            // 
            textBoxSearchOtherAccount.BackColor = SystemColors.Control;
            textBoxSearchOtherAccount.BorderStyle = BorderStyle.None;
            textBoxSearchOtherAccount.Font = new Font("Verdana Pro Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchOtherAccount.Location = new Point(36, 8);
            textBoxSearchOtherAccount.Name = "textBoxSearchOtherAccount";
            textBoxSearchOtherAccount.PlaceholderText = "Search Account";
            textBoxSearchOtherAccount.Size = new Size(544, 20);
            textBoxSearchOtherAccount.TabIndex = 9;
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
            buttonSearch.TabIndex = 29;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // panelSearchAccount
            // 
            panelSearchAccount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSearchAccount.BackColor = SystemColors.Control;
            panelSearchAccount.Controls.Add(pictureBox2);
            panelSearchAccount.Controls.Add(textBoxSearchOtherAccount);
            panelSearchAccount.Location = new Point(30, 17);
            panelSearchAccount.Name = "panelSearchAccount";
            panelSearchAccount.Size = new Size(583, 37);
            panelSearchAccount.TabIndex = 28;
            // 
            // accountBindingSource2
            // 
            accountBindingSource2.DataSource = typeof(DataAccessLibrary.Entity.Account);
            // 
            // accountCodeDataGridViewTextBoxColumn
            // 
            accountCodeDataGridViewTextBoxColumn.DataPropertyName = "AccountCode";
            accountCodeDataGridViewTextBoxColumn.HeaderText = "AccountCode";
            accountCodeDataGridViewTextBoxColumn.Name = "accountCodeDataGridViewTextBoxColumn";
            accountCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.BackColor = Color.LightSkyBlue;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(773, 101);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(85, 35);
            buttonDelete.TabIndex = 32;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonAddOtherAccount
            // 
            buttonAddOtherAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddOtherAccount.BackColor = Color.LightSkyBlue;
            buttonAddOtherAccount.Cursor = Cursors.Hand;
            buttonAddOtherAccount.FlatStyle = FlatStyle.Flat;
            buttonAddOtherAccount.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddOtherAccount.ForeColor = Color.White;
            buttonAddOtherAccount.Location = new Point(773, 60);
            buttonAddOtherAccount.Name = "buttonAddOtherAccount";
            buttonAddOtherAccount.Size = new Size(85, 35);
            buttonAddOtherAccount.TabIndex = 31;
            buttonAddOtherAccount.Text = "Add";
            buttonAddOtherAccount.UseVisualStyleBackColor = false;
            buttonAddOtherAccount.Click += buttonAddOtherAccount_Click;
            // 
            // dataGridViewOtherAccount
            // 
            dataGridViewOtherAccount.AllowUserToAddRows = false;
            dataGridViewOtherAccount.AllowUserToDeleteRows = false;
            dataGridViewOtherAccount.AllowUserToResizeColumns = false;
            dataGridViewOtherAccount.AllowUserToResizeRows = false;
            dataGridViewOtherAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOtherAccount.AutoGenerateColumns = false;
            dataGridViewOtherAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOtherAccount.BackgroundColor = Color.White;
            dataGridViewOtherAccount.BorderStyle = BorderStyle.None;
            dataGridViewOtherAccount.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewOtherAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana Pro Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOtherAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOtherAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOtherAccount.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, accountNameDataGridViewTextBoxColumn, moneyDataGridViewTextBoxColumn, accountCodeDataGridViewTextBoxColumn });
            dataGridViewOtherAccount.DataSource = accountBindingSource2;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewOtherAccount.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOtherAccount.EnableHeadersVisualStyles = false;
            dataGridViewOtherAccount.Location = new Point(30, 60);
            dataGridViewOtherAccount.Name = "dataGridViewOtherAccount";
            dataGridViewOtherAccount.ReadOnly = true;
            dataGridViewOtherAccount.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewOtherAccount.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana Pro Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewOtherAccount.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewOtherAccount.RowTemplate.Height = 25;
            dataGridViewOtherAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOtherAccount.Size = new Size(737, 386);
            dataGridViewOtherAccount.TabIndex = 30;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(DataAccessLibrary.Entity.Account);
            // 
            // SavedOtherAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(buttonSearch);
            Controls.Add(panelSearchAccount);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAddOtherAccount);
            Controls.Add(dataGridViewOtherAccount);
            Name = "SavedOtherAccountForm";
            Text = "SavedNonClientAccountForm";
            ((System.ComponentModel.ISupportInitialize)accountBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelSearchAccount.ResumeLayout(false);
            panelSearchAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOtherAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource accountBindingSource1;
        private PictureBox pictureBox2;
        private TextBox textBoxSearchOtherAccount;
        private Button buttonSearch;
        private Panel panelSearchAccount;
        private BindingSource accountBindingSource2;
        private DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private Button buttonDelete;
        private Button buttonAddOtherAccount;
        private DataGridView dataGridViewOtherAccount;
        private DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private BindingSource accountBindingSource;
    }
}