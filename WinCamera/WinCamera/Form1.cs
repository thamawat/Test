using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCamera
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string externalIP = new WebClient().DownloadString("http://ipv4bot.whatismyipaddress.com");
                ip_txb.Text = externalIP;
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
