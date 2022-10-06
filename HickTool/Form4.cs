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

#pragma warning disable SYSLIB0014

namespace HickTool
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi", "C:\\HickTool\\EpicGamesLauncherInstaller.msi");
            MessageBox.Show("Done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://github.com/paintdotnet/release/releases/download/v4.3.12/paint.net.4.3.12.install.x64.zip", "C:\\HickTool\\paint.net.4.3.12.install.x64.zip");
            MessageBox.Show("Done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://ubi.li/4vxt9", "C:\\HickTool\\UbisoftConnectInstaller.exe");
            MessageBox.Show("Done");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var client = new WebClient(); client.DownloadFile("https://www.win-rar.com/fileadmin/winrar-versions/winrar/winrar-x64-611.exe", "C:\\HickTool\\winrar-x64-611.exe");
            MessageBox.Show("Done");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://dl.google.com/android/repository/platform-tools-latest-windows.zip", "C:\\HickTool\\PlatformTools.zip");
            MessageBox.Show("Done");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://download.msi.com/uti_exe/vga/MSIAfterburnerSetup.zip?__token__=exp=1665234102~acl=/*~hmac=0008fc2c4eb875999ac2bc12c93565542fde51c3af167b21f0dc20b434ca25ab", "C:\\HickTool\\MSIAfterburnerSetup.zip");
            MessageBox.Show("Done");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://www.voicemod.net/downloadVoicemod.php?l=1", "C:\\HickTool\\VoiceMod.exe");
            MessageBox.Show("Done");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://clownfish-translator.com/voicechanger/download/download64f.php?v=170", "C:\\HickTool\\Clownfish.exe");
            MessageBox.Show("Done");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://www.fosshub.com/HWiNFO.html?dwl=hwi_730.exe", "C:\\HickTool\\HWinfo.exe");
            MessageBox.Show("Done");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://download.cpuid.com/hwmonitor-pro/hwmonitor-pro_1.47.exe", "C:\\HickTool\\HWmonitor.exe");
            MessageBox.Show("Done");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://net.geo.opera.com/opera/stable/windows?utm_tryagain=yes&utm_source=bing&utm_medium=ose&utm_campaign=(none)&http_referrer=https%3A%2F%2Fwww.bing.com%2F&utm_site=opera_com&&utm_lastpage=opera.com/", "C:\\HickTool\\Opera.exe");
            MessageBox.Show("Done");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://net.geo.opera.com/opera_gx/stable/windows?utm_tryagain=yes&utm_source=bing&utm_medium=ose&utm_campaign=(none)&http_referrer=https%3A%2F%2Fwww.bing.com%2F&utm_site=opera_com&&utm_lastpage=opera.com/", "C:\\HickTool\\OperaGX.exe");
            MessageBox.Show("Done");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}