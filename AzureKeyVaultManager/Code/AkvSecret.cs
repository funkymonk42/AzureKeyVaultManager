using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureKeyVaultManager.Code
{
    public class AkvSecret
    {
        public bool kvSelected
        { get; set; }

        public string kvName
        { get; set; }

        public string kvValue
        { get; set; }

        public string kvEdit
        { get; set; } = "Edit Secret";

    }
}
