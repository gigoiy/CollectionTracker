using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBay.ApiClient.Auth.OAuth2;
using eBay.ApiClient.Auth.OAuth2.Model;


namespace ProjectAlexKadyn
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CredentialUtil.Load(@"..\..\..\ebay-config.yaml");
            Application.Run(new frmHome());
        }
    }
}
