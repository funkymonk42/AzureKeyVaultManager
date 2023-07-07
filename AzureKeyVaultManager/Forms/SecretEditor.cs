using Azure.Security.KeyVault.Secrets;
using AzureKeyVaultManager.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace AzureKeyVaultManager.Forms
{
    public partial class SecretEditor : Form
    {
        public static string secretValueOriginal
        { get; set; }

        public static SecretClient secretClient
        { get; set; }


        public SecretEditor(SecretClient secretClientIn, string secretName)
        {
            InitializeComponent();
            secretClient = secretClientIn;
            KeyVaultSecret secret = secretClient.GetSecret(secretName);
            txtSecretName.Text = secret.Name;
            txtSecretValue.Text = secret.Value;
            secretValueOriginal = secret.Value;

            var updatedOn = secret.Properties.UpdatedOn.Value.ToLocalTime();
            DateTime updated = updatedOn.DateTime;
            txtSecretCount.Text = updated.ToString();

        }


        private void btnEnableSecretValue_Click(object sender, EventArgs e)
        {
            txtSecretValue.ReadOnly = false;
            txtSecretValue.Focus();
            txtSecretValue.SelectionStart = txtSecretValue.Text.Length;
        }


        private void txtSecretValue_TextChanged(object sender, EventArgs e)
        {
            if (secretValueOriginal != null && txtSecretValue.Text != secretValueOriginal)
            {
                btnSave.Visible = true;
            }
            else
            {
                btnSave.Visible = false;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (secretValueOriginal != null && txtSecretValue.Text != secretValueOriginal)
            {
                try
                {
                    secretClient.SetSecret(txtSecretName.Text, txtSecretValue.Text);
                    secretValueOriginal = null;
                    this.Dispose();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Helper.Msgbox(ex.Message, "Oops");
                }
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if CTRL-S is pressed
            if (keyData == (Keys.Control | Keys.S))
            {
                // Trigger the button click
                btnSave.PerformClick();
                return true; // Indicate that the key was processed
            }
            else if (keyData == (Keys.Control | Keys.E))
            {
                // Trigger the button click
                btnEnableSecretValue.PerformClick();
                return true; // Indicate that the key was processed
            }
            else if (keyData == (Keys.Control | Keys.C) || keyData == Keys.Escape)
            {
                // Trigger the button click
                btnClose.PerformClick();
                return true; // Indicate that the key was processed
            }

            // Call the base implementation
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
