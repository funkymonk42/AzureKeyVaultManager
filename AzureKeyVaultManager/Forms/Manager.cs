using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using AzureKeyVaultManager.Code;
using AzureKeyVaultManager.Forms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureKeyVaultManager
{
    public partial class Manager : Form
    {
        public static SecretClient secretClient
        { get; set; }

        public static BindingList<AkvSecret> secretKeys
        { get; set; }

        public static Azure.Pageable<SecretProperties>? allSecrets
        { get; set; }

        public static string keyvaultUrl
        { get; set; }


        public Manager()
        {
            InitializeComponent();

            cmbFileMode.SelectedIndex = 0;
            if (cmbVaultUrl.Items.Count > 0)
            {
                cmbVaultUrl.SelectedIndex = 0;
            }
            else
            {
                try
                {
                    List<VaultUrl> vaultUrls = Helper.GetVaultUrls();
                    if (vaultUrls != null && vaultUrls.Count > 0)
                    {
                        foreach (var vaultUrl in vaultUrls)
                        {
                            cmbVaultUrl.Items.Add(vaultUrl.AzureKeyVaultUrl);
                        }
                        cmbVaultUrl.SelectedIndex = 0;
                    }
                    else
                    {
                        Helper.Msgbox("No vaults found. Please add a vault.", "Oops");
                    }
                }
                catch (Exception ex)
                {
                }
            }
            GetAzureKeyVaultSecrets(true);
        }


        public void GetAzureKeyVaultSecrets(bool getFromAzure = false)
        {
            try
            {
                string kvUrl = cmbVaultUrl.Text;
                if (string.IsNullOrEmpty(kvUrl) == true)
                {
                    Helper.Msgbox("Please select a secret.", "Oops");
                    cmbVaultUrl.Focus();
                }
                else
                {
                    if (secretKeys == null || getFromAzure == true)
                    {

                        var kvUri = $"https://{kvUrl}.vault.azure.net/";
                        secretClient = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());

                        // get all secrets from the vault
                        allSecrets = null;
                        allSecrets = secretClient.GetPropertiesOfSecrets();

                        secretKeys = new BindingList<AkvSecret>();
                        var kvSecretKeys = new List<KeyVaultSecret>();

                        foreach (var secret in allSecrets)
                        {
                            AkvSecret keyvaultSecret = new AkvSecret()
                            {
                                kvName = secret.Name
                            };
                            secretKeys.Add(keyvaultSecret);

                            KeyVaultSecret kvSecret = secretClient.GetSecret(secret.Name);
                            kvSecretKeys.Add(kvSecret);
                        }
                    }

                    dgvSecrets.DataSource = secretKeys;
                    dgvSecrets.Columns[nameof(AkvSecret.kvValue)].Visible = false;
                    btnRefreshList.Text = $"🔄 Refresh ({secretKeys.Count})";
                }
            }
            catch (Exception ex)
            {
                Helper.Msgbox(ex.Message, "Oops");
            }
        }


        public void CallDelete(bool hardDelete = false)
        {
            var dt = dgvSecrets.DataSource as BindingList<AkvSecret>;

            if (dt != null)
            {
                var rowNumber = -1;
                var rowsUpdated = 0;
                List<int> rowsToRemove = new List<int>();

                foreach (var row in dt)
                {
                    rowNumber++;

                    if (row.kvSelected == true)
                    {
                        try
                        {
                            var deleted = Helper.DoDelete(secretClient, row.kvName, hardDelete);
                            if (deleted == true)
                            {
                                rowsToRemove.Add(rowNumber);
                                rowsUpdated++;
                            }
                        }
                        catch (Exception ex)
                        {
                            Helper.Msgbox(ex.Message, "Oops");
                        }
                    }
                }

                if (rowsUpdated > 0)
                {
                    try
                    {
                        var deleteType = hardDelete == true ? "HARD" : "SOFT";
                        Helper.Msgbox($"{rowsUpdated} secret(s) were {deleteType} deleted.", "Success");

                        rowsToRemove.Reverse();
                        foreach (var row in rowsToRemove)
                        {
                            secretKeys.RemoveAt(row);
                        }
                        dgvSecrets.Refresh();
                        btnRefreshList.Text = $"🔄 Refresh ({dt.Count})";
                    }
                    catch (Exception ex)
                    {
                        Helper.Msgbox(ex.Message, "Oops");
                        GetAzureKeyVaultSecrets(true);
                    }
                }
                else
                {
                    Helper.Msgbox("No secrets were selected.", "Oops");
                }
            }
        }


        private void dgvSecrets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var senderColumn = senderGrid.Columns[e.ColumnIndex];
            var colData = senderColumn.DataPropertyName;
            var rowIndex = e.RowIndex;

            BindingList<AkvSecret> dt = dgvSecrets.DataSource as BindingList<AkvSecret>;

            if (rowIndex >= 0)
            {
                AkvSecret row = dt[rowIndex];
                DataGridViewRow gridRow = senderGrid.Rows[rowIndex];

                if (senderColumn is DataGridViewButtonColumn)
                {
                    if (string.IsNullOrEmpty(row.kvName) == false)
                    {
                        SecretEditor se = new SecretEditor(secretClient, row.kvName);
                        se.ShowDialog();
                    }
                }
            }
        }


        private void btnDeleteSecrets_Click(object sender, EventArgs e)
        {
            CallDelete(false);
        }


        private void btnDeletePurgeSecrets_Click(object sender, EventArgs e)
        {
            CallDelete(true);
        }


        private void btnRestoreSecrets_Click(object sender, EventArgs e)
        {
            Helper.Msgbox("Not implemented yet.", "Oops");
        }


        private void btnBackupSecrets_Click(object sender, EventArgs e)
        {
            Helper.Msgbox("Not implemented yet.", "Oops");
        }


        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            Helper.SetSelect(dgvSecrets, nameof(kvSelected), true);
        }


        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            Helper.SetSelect(dgvSecrets, nameof(kvSelected), false);
        }


        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            GetAzureKeyVaultSecrets(true);
        }


        private void cmbVaultUrl_Leave(object sender, EventArgs e)
        {
            if (keyvaultUrl != cmbVaultUrl.Text)
            {
                GetAzureKeyVaultSecrets(true);
            }
        }


        private void cmbVaultUrl_Enter(object sender, EventArgs e)
        {
            keyvaultUrl = cmbVaultUrl.Text;
        }
    }
}
