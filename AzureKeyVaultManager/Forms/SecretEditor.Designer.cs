namespace AzureKeyVaultManager.Forms
{
    partial class SecretEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretEditor));
            txtSecretName = new TextBox();
            txtSecretValue = new TextBox();
            txtSecretCount = new TextBox();
            btnEnableSecretValue = new Button();
            btnClose = new Button();
            btnSave = new Button();
            lblSecretName = new Label();
            lblSecretValue = new Label();
            lblLastUpdated = new Label();
            SuspendLayout();
            // 
            // txtSecretName
            // 
            txtSecretName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSecretName.Location = new Point(149, 12);
            txtSecretName.Name = "txtSecretName";
            txtSecretName.ReadOnly = true;
            txtSecretName.Size = new Size(555, 23);
            txtSecretName.TabIndex = 0;
            // 
            // txtSecretValue
            // 
            txtSecretValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSecretValue.Location = new Point(149, 41);
            txtSecretValue.Multiline = true;
            txtSecretValue.Name = "txtSecretValue";
            txtSecretValue.ReadOnly = true;
            txtSecretValue.Size = new Size(555, 140);
            txtSecretValue.TabIndex = 1;
            txtSecretValue.TextChanged += txtSecretValue_TextChanged;
            // 
            // txtSecretCount
            // 
            txtSecretCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSecretCount.Location = new Point(149, 188);
            txtSecretCount.Name = "txtSecretCount";
            txtSecretCount.ReadOnly = true;
            txtSecretCount.Size = new Size(348, 23);
            txtSecretCount.TabIndex = 2;
            // 
            // btnEnableSecretValue
            // 
            btnEnableSecretValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnableSecretValue.Location = new Point(503, 187);
            btnEnableSecretValue.Name = "btnEnableSecretValue";
            btnEnableSecretValue.Size = new Size(201, 23);
            btnEnableSecretValue.TabIndex = 3;
            btnEnableSecretValue.Text = "Edit Secret Value (Ctrl-E)";
            btnEnableSecretValue.UseVisualStyleBackColor = true;
            btnEnableSecretValue.Click += btnEnableSecretValue_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Location = new Point(503, 225);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(201, 41);
            btnClose.TabIndex = 4;
            btnClose.Text = "Cancel && Close (Ctrl-C)";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.PaleGreen;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(149, 225);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(348, 41);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Updated Value (Ctrl-S)";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblSecretName
            // 
            lblSecretName.AutoSize = true;
            lblSecretName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecretName.Location = new Point(12, 13);
            lblSecretName.Name = "lblSecretName";
            lblSecretName.Size = new Size(95, 19);
            lblSecretName.TabIndex = 6;
            lblSecretName.Text = "Secret Name";
            // 
            // lblSecretValue
            // 
            lblSecretValue.AutoSize = true;
            lblSecretValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecretValue.Location = new Point(12, 42);
            lblSecretValue.Name = "lblSecretValue";
            lblSecretValue.Size = new Size(91, 19);
            lblSecretValue.TabIndex = 7;
            lblSecretValue.Text = "Secret Value";
            // 
            // lblLastUpdated
            // 
            lblLastUpdated.AutoSize = true;
            lblLastUpdated.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastUpdated.Location = new Point(16, 189);
            lblLastUpdated.Name = "lblLastUpdated";
            lblLastUpdated.Size = new Size(97, 19);
            lblLastUpdated.TabIndex = 8;
            lblLastUpdated.Text = "Last Updated";
            // 
            // SecretEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 278);
            Controls.Add(lblLastUpdated);
            Controls.Add(lblSecretValue);
            Controls.Add(lblSecretName);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(btnEnableSecretValue);
            Controls.Add(txtSecretCount);
            Controls.Add(txtSecretValue);
            Controls.Add(txtSecretName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SecretEditor";
            Text = "Edit Azure Key Vault Secret";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSecretName;
        private TextBox txtSecretValue;
        private TextBox txtSecretCount;
        private Button btnEnableSecretValue;
        private Button btnClose;
        private Button btnSave;
        private Label lblSecretName;
        private Label lblSecretValue;
        private Label lblLastUpdated;
    }
}