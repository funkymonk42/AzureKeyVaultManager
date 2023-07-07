namespace AzureKeyVaultManager
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            dgvSecrets = new DataGridView();
            kvSelected = new DataGridViewCheckBoxColumn();
            kvName = new DataGridViewTextBoxColumn();
            kvValue = new DataGridViewTextBoxColumn();
            kvEdit = new DataGridViewButtonColumn();
            btnBackupSecrets = new Button();
            btnRestoreSecrets = new Button();
            btnDeletePurgeSecrets = new Button();
            btnDeleteSecrets = new Button();
            cmbFileMode = new ComboBox();
            lblTitle = new Label();
            lblMode = new Label();
            lblVaultUrl = new Label();
            cmbVaultUrl = new ComboBox();
            btnSelectAll = new Button();
            btnSelectNone = new Button();
            btnRefreshList = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSecrets).BeginInit();
            SuspendLayout();
            // 
            // dgvSecrets
            // 
            dgvSecrets.AllowUserToAddRows = false;
            dgvSecrets.AllowUserToDeleteRows = false;
            dgvSecrets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSecrets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSecrets.Columns.AddRange(new DataGridViewColumn[] { kvSelected, kvName, kvValue, kvEdit });
            dgvSecrets.Location = new Point(12, 46);
            dgvSecrets.Name = "dgvSecrets";
            dgvSecrets.RowTemplate.Height = 25;
            dgvSecrets.Size = new Size(810, 462);
            dgvSecrets.TabIndex = 0;
            dgvSecrets.CellContentClick += dgvSecrets_CellContentClick;
            // 
            // kvSelected
            // 
            kvSelected.DataPropertyName = "kvSelected";
            kvSelected.HeaderText = "Selected";
            kvSelected.Name = "kvSelected";
            // 
            // kvName
            // 
            kvName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            kvName.DataPropertyName = "kvName";
            kvName.HeaderText = "Secret Name";
            kvName.Name = "kvName";
            kvName.Resizable = DataGridViewTriState.True;
            // 
            // kvValue
            // 
            kvValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            kvValue.DataPropertyName = "kvValue";
            kvValue.HeaderText = "Secret Value";
            kvValue.Name = "kvValue";
            kvValue.Visible = false;
            // 
            // kvEdit
            // 
            kvEdit.DataPropertyName = "kvEdit";
            kvEdit.HeaderText = "Edit";
            kvEdit.Name = "kvEdit";
            kvEdit.Text = "Edit";
            // 
            // btnBackupSecrets
            // 
            btnBackupSecrets.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBackupSecrets.Location = new Point(624, 544);
            btnBackupSecrets.Name = "btnBackupSecrets";
            btnBackupSecrets.Size = new Size(198, 39);
            btnBackupSecrets.TabIndex = 1;
            btnBackupSecrets.Text = "Backup Secrets to File";
            btnBackupSecrets.UseVisualStyleBackColor = true;
            btnBackupSecrets.Click += btnBackupSecrets_Click;
            // 
            // btnRestoreSecrets
            // 
            btnRestoreSecrets.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRestoreSecrets.Location = new Point(420, 544);
            btnRestoreSecrets.Name = "btnRestoreSecrets";
            btnRestoreSecrets.Size = new Size(198, 39);
            btnRestoreSecrets.TabIndex = 2;
            btnRestoreSecrets.Text = "Restore Secrets From File";
            btnRestoreSecrets.UseVisualStyleBackColor = true;
            btnRestoreSecrets.Click += btnRestoreSecrets_Click;
            // 
            // btnDeletePurgeSecrets
            // 
            btnDeletePurgeSecrets.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletePurgeSecrets.BackColor = Color.Orange;
            btnDeletePurgeSecrets.Location = new Point(216, 544);
            btnDeletePurgeSecrets.Name = "btnDeletePurgeSecrets";
            btnDeletePurgeSecrets.Size = new Size(198, 39);
            btnDeletePurgeSecrets.TabIndex = 3;
            btnDeletePurgeSecrets.Text = "Delete && Purge Secrets";
            btnDeletePurgeSecrets.UseVisualStyleBackColor = false;
            btnDeletePurgeSecrets.Click += btnDeletePurgeSecrets_Click;
            // 
            // btnDeleteSecrets
            // 
            btnDeleteSecrets.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeleteSecrets.BackColor = Color.LightGreen;
            btnDeleteSecrets.Location = new Point(12, 544);
            btnDeleteSecrets.Name = "btnDeleteSecrets";
            btnDeleteSecrets.Size = new Size(198, 39);
            btnDeleteSecrets.TabIndex = 4;
            btnDeleteSecrets.Text = "Delete Secrets (soft)";
            btnDeleteSecrets.UseVisualStyleBackColor = false;
            btnDeleteSecrets.Click += btnDeleteSecrets_Click;
            // 
            // cmbFileMode
            // 
            cmbFileMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFileMode.FormattingEnabled = true;
            cmbFileMode.Items.AddRange(new object[] { "Json", "Binary" });
            cmbFileMode.Location = new Point(721, 12);
            cmbFileMode.Name = "cmbFileMode";
            cmbFileMode.Size = new Size(101, 23);
            cmbFileMode.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(404, 15);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "AKV Manager to help you view, delete, backup and restore your secrets";
            // 
            // lblMode
            // 
            lblMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblMode.Location = new Point(656, 15);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(57, 15);
            lblMode.TabIndex = 7;
            lblMode.Text = "File Mode";
            // 
            // lblVaultUrl
            // 
            lblVaultUrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVaultUrl.AutoSize = true;
            lblVaultUrl.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblVaultUrl.Location = new Point(431, 15);
            lblVaultUrl.Name = "lblVaultUrl";
            lblVaultUrl.Size = new Size(54, 15);
            lblVaultUrl.TabIndex = 9;
            lblVaultUrl.Text = "Vault Url";
            // 
            // cmbVaultUrl
            // 
            cmbVaultUrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbVaultUrl.CausesValidation = false;
            cmbVaultUrl.FormattingEnabled = true;
            cmbVaultUrl.Location = new Point(496, 12);
            cmbVaultUrl.Name = "cmbVaultUrl";
            cmbVaultUrl.Size = new Size(154, 23);
            cmbVaultUrl.TabIndex = 8;
            cmbVaultUrl.Enter += cmbVaultUrl_Enter;
            cmbVaultUrl.Leave += cmbVaultUrl_Leave;
            // 
            // btnSelectAll
            // 
            btnSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSelectAll.Location = new Point(12, 514);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(67, 24);
            btnSelectAll.TabIndex = 10;
            btnSelectAll.Text = "☑️ All";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // btnSelectNone
            // 
            btnSelectNone.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSelectNone.Location = new Point(85, 514);
            btnSelectNone.Name = "btnSelectNone";
            btnSelectNone.Size = new Size(70, 24);
            btnSelectNone.TabIndex = 11;
            btnSelectNone.Text = "⬜️ None";
            btnSelectNone.UseVisualStyleBackColor = true;
            btnSelectNone.Click += btnSelectNone_Click;
            // 
            // btnRefreshList
            // 
            btnRefreshList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefreshList.Location = new Point(216, 514);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new Size(200, 24);
            btnRefreshList.TabIndex = 12;
            btnRefreshList.Text = "🔄 Refresh";
            btnRefreshList.UseVisualStyleBackColor = true;
            btnRefreshList.Click += btnRefreshList_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 595);
            Controls.Add(btnRefreshList);
            Controls.Add(btnSelectNone);
            Controls.Add(btnSelectAll);
            Controls.Add(lblVaultUrl);
            Controls.Add(cmbVaultUrl);
            Controls.Add(lblMode);
            Controls.Add(lblTitle);
            Controls.Add(cmbFileMode);
            Controls.Add(btnDeleteSecrets);
            Controls.Add(btnDeletePurgeSecrets);
            Controls.Add(btnRestoreSecrets);
            Controls.Add(btnBackupSecrets);
            Controls.Add(dgvSecrets);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Manager";
            Text = "Azure Key Vault Manager";
            ((System.ComponentModel.ISupportInitialize)dgvSecrets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSecrets;
        private Button btnBackupSecrets;
        private Button btnRestoreSecrets;
        private Button btnDeletePurgeSecrets;
        private Button btnDeleteSecrets;
        private ComboBox cmbFileMode;
        private Label lblTitle;
        private Label lblMode;
        private Label lblVaultUrl;
        private ComboBox cmbVaultUrl;
        private Button btnSelectAll;
        private Button btnSelectNone;
        private Button btnRefreshList;
        private DataGridViewCheckBoxColumn kvSelected;
        private DataGridViewTextBoxColumn kvName;
        private DataGridViewTextBoxColumn kvValue;
        private DataGridViewButtonColumn kvEdit;
    }
}