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

namespace HickTool
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://github.com/audacity/audacity/releases/download/Audacity-3.2.0/audacity-win-3.2.0-64bit.exe", "C:\\HickTool\\Audacity.exe");
            MessageBox.Show("Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user", "C:\\HickTool\\VisualStudioCode.exe");
            MessageBox.Show("Done");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://c2rsetup.officeapps.live.com/c2r/downloadVS.aspx?sku=community&channel=Release&version=VS2022&source=VSLandingPage&includeRecommended=true&cid=2030", "C:\\HickTool\\VisualStudio2022.exe");
            MessageBox.Show("Done");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://downloads.ntlite.com/files/NTLite_setup_x64.exe", "C:\\HickTool\\NTlite_setup_x64.exe");
            MessageBox.Show("Done");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://github.com/mltframework/shotcut/releases/download/v22.09.23/shotcut-win64-220923.exe", "C:\\HickTool\\Shotcut.exe");
            MessageBox.Show("Done");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://download.vb-audio.com/Download_CABLE/VoicemeeterProSetup.exe", "C:\\HickTool\\VoiceMeeterBanana.exe");
            MessageBox.Show("Done");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://download.vb-audio.com/Download_CABLE/VBCABLE_Driver_Pack43.zip", "C:\\HickTool\\VBCABLE.exe");
            MessageBox.Show("Done");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://cdn.akamai.steamstatic.com/client/installer/SteamSetup.exe", "C:\\HickTool\\Steam.exe");
            MessageBox.Show("Done");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://discord.com/api/downloads/distributions/app/installers/latest?channel=stable&platform=win&arch=x86", "C:\\HickTool\\Discord.exe");
            MessageBox.Show("Done");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://www.python.org/ftp/python/3.10.7/python-3.10.7-amd64.exe", "C:\\HickTool\\Python.exe");
            MessageBox.Show("Done");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://www.jetbrains.com/pycharm/download/download-thanks.html?platform=windows&code=PCC", "C:\\HickTool\\PyCharm.exe");
            MessageBox.Show("Done");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://javadl.oracle.com/webapps/download/AutoDL?BundleId=246808_424b9da4b48848379167015dcc250d8d", "C:\\HickTool\\Java.exe");
            MessageBox.Show("Done");
        }
    }
}
