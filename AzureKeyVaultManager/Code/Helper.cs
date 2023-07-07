using Azure.Core.Pipeline;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Reflection;

namespace AzureKeyVaultManager.Code
{
    public class Helper
    {
        public static void SetSelect(DataGridView dataGridView, string column, bool select)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                try
                {
                    DataGridViewCell currentCell = row.Cells[column];
                    currentCell.Value = select;
                }
                catch (Exception ex)
                {
                    Msgbox(ex.Message, "Oops");
                }
            }
        }


        public static void Msgbox(string message, string caption = "Information", string errorCode = "")
        {
            var captionWithCode = (string.IsNullOrEmpty(errorCode) == false) ? $"{caption}: Error Code: {errorCode}" : caption;
            MessageBox.Show(message, captionWithCode);
        }


        public static bool DoDelete(SecretClient secretClient, string secretName, bool hardDelete)
        {
            try
            {
                DeleteSecretOperation operation = secretClient.StartDeleteSecret(secretName);
                operation.WaitForCompletion();
                if (hardDelete == true)
                {
                    // purge the secret
                    secretClient.PurgeDeletedSecret(secretName);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public static List<VaultUrl> GetVaultUrls()
        {
            var vaultUrls = ReadVaultUrls();
            if (vaultUrls == null)
            {
                vaultUrls = new List<VaultUrl>();
            }

            return vaultUrls;

        }


        public static List<VaultUrl> ReadVaultUrls()
        {
            var vaultUrls = new List<VaultUrl>();
            try
            {
                var fullPath = GetCultUrlJsonPath();
                if (string.IsNullOrEmpty(fullPath) == true)
                {
                    return vaultUrls;
                }
                else
                {
                    var vaultUrlsJson = File.ReadAllText(fullPath);

                    vaultUrls = JsonConvert.DeserializeObject<List<VaultUrl>>(vaultUrlsJson);
                    vaultUrls = vaultUrls.OrderBy(x => x.AzureKeyVaultUrl).ToList();

                    return vaultUrls;
                }
            }
            catch (Exception ex)
            {
                Msgbox(ex.Message, "Oops");
                return vaultUrls;
            }
        }


        public static bool WriteVaultUrls(List<VaultUrl> vaultUrls)
        {
            try
            {
                var vaultUrlJson = JsonConvert.SerializeObject(vaultUrls, Formatting.Indented);

                string exeRootDir = AppDomain.CurrentDomain.BaseDirectory;
                if (exeRootDir.Contains("bin\\Debug\\") == true)
                {
                    exeRootDir = Path.GetFullPath(Path.Combine(exeRootDir, @"..\..\..\"));
                }

                string relativePath = "App_Data\vaultUrls.json";
                string fullPath = Path.Combine(exeRootDir, relativePath);

                File.WriteAllText("vaultUrls.json", vaultUrlJson);
                return true;
            }
            catch (Exception ex)
            {
                Msgbox(ex.Message, "Oops");
                return false;
            }
        }


        public static string GetCultUrlJsonPath()
        {
            try
            {
                string exeRootDir = AppDomain.CurrentDomain.BaseDirectory;
                if (exeRootDir.Contains("bin\\Debug\\") == true)
                {
                    exeRootDir = Path.GetFullPath(Path.Combine(exeRootDir, @"..\..\..\"));
                }

                string relativePath = "App_Data\\vaultUrls.json";
                string fullPath = Path.Combine(exeRootDir, relativePath);

                return fullPath;
            }
            catch (Exception ex)
            {
                Msgbox(ex.Message, "Oops");
                return string.Empty;
            }
        }
    }
}
