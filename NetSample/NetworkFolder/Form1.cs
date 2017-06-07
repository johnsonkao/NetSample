using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Diagnostics;
namespace NetworkFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            GetFolferNetUse();
        }
        private void GetFolferNetUse()
        {
            Process process = new Process();
            ProcessStartInfo info = new ProcessStartInfo(@"c:\batch\copyNetFile.bat");
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.Arguments="rec_web.txt";
            process.StartInfo = info;
            process.Start();
            
        }
        private void GetFolfer()
        {
            try
            {
                string username = txtAccount.Text;
                string password = txtPassword.Text;
                string domain = txtDomain.Text;
                string path = txtPath.Text;
 
                NetworkCredential theNetworkCredential = new NetworkCredential(username, password, domain);
                CredentialCache theNetcache = new CredentialCache();
                theNetcache.Add(new Uri(path), "Basic", theNetworkCredential);
                //then do whatever, such as getting a list of folders:
                string[] theFolders = System.IO.Directory.GetDirectories(path);
                lstFolder.DataSource = theFolders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
