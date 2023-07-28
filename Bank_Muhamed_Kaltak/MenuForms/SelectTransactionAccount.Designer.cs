namespace Bank_Muhamed_Kaltak.MenuForms
{
    partial class SelectTransactionAccount
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            buttonExternalAccount = new Button();
            dataGridViewAccount = new DataGridView();
            buttonSearch = new Button();
            panelSearchAccount = new Panel();
            pictureBox2 = new PictureBox();
            textBoxSearchAccount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).BeginInit();
            panelSearchAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonExternalAccount
            // 
            buttonExternalAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExternalAccount.BackColor = Color.LightSkyBlue;
            buttonExternalAccount.Cursor = Cursors.Hand;
            buttonExternalAccount.FlatStyle = FlatStyle.Flat;
            buttonExternalAccount.Font = new Font("Verdana Pro Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExternalAccount.ForeColor = Color.White;
            buttonExternalAccount.Location = new Point(791, 398);
            buttonExternalAccount.Name = "buttonExternalAccount";
            buttonExternalAccount.Size = new Size(85, 48);
            buttonExternalAccount.TabIndex = 25;
            buttonExternalAccount.Text = "External account";
            buttonExternalAccount.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new Font("Verdana Pro Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewAccount.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewAccount.EnableHeadersVisualStyles = false;
            dataGridViewAccount.Location = new Point(30, 60);
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
            textBoxSearchAccount.PlaceholderText = "Search Account";
            textBoxSearchAccount.Size = new Size(544, 20);
            textBoxSearchAccount.TabIndex = 9;
            // 
            // SelectTransactionAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(888, 462);
            Controls.Add(buttonExternalAccount);
            Controls.Add(dataGridViewAccount);
            Controls.Add(buttonSearch);
            Controls.Add(panelSearchAccount);
            Name = "SelectTransactionAccount";
            Text = "SelectTransactionAccount";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).EndInit();
            panelSearchAccount.ResumeLayout(false);
            panelSearchAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonExternalAccount;
        private DataGridView dataGridViewAccount;
        private Button buttonSearch;
        private Panel panelSearchAccount;
        private PictureBox pictureBox2;
        private TextBox textBoxSearchAccount;
    }
}