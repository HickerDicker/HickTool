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
using System.Diagnostics;
#pragma warning disable SYSLIB0014
namespace HickTool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B361A0C05-B3CA-6287-EF93-AE022EEEE4F8%7D%26lang%3Den%26browser%3D3%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Dempty/chrome/install/ChromeStandaloneSetup64.exe", "C:\\HickTool\\Chrome.exe");
            MessageBox.Show("Done");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new WebClient(); 
            client.DownloadFile("https://download.mozilla.org/?product=firefox-stub&os=win&lang=en-US", "C:\\HickTool\\Firefox.exe");
            MessageBox.Show("Done");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://www.7-zip.org/a/7z2201-x64.exe", "C:\\HickTool\\7zip.exe");
            MessageBox.Show("Done");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.4.5/npp.8.4.5.Installer.x64.exe", "C:\\HickTool\\Notepad++.exe");
            MessageBox.Show("Done");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://cdn-fastly.obsproject.com/downloads/OBS-Studio-28.0.2-Full-Installer-x64.exe", "C:\\HickTool\\obs.exe");
            MessageBox.Show("Done");
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://github.com/Chuyu-Team/Dism-Multi-language/releases/download/v10.1.1002.1/Dism++10.1.1002.1.zip", "C:\\HickTool\\DISM++.zip");
            MessageBox.Show("Done");
           }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://startisback.sfo3.cdn.digitaloceanspaces.com/StartIsBackPlusPlus_setup.exe", "C:\\HickTool\\StartIsBack.exe");
            MessageBox.Show("Done");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://github.com/Open-Shell/Open-Shell-Menu/releases/download/v4.4.170/OpenShellSetup_4_4_170.exe", "C:\\HickTool\\OpenShell.exe");
            MessageBox.Show("Done");
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://download.teamviewer.com/download/TeamViewer_Setup_x64.exe", "C:\\HickTool\\TeamViewer.exe");
            MessageBox.Show("Done");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://mirrors.netix.net/vlc/vlc/3.0.17.4/win64/vlc-3.0.17.4-win64.exe", "C:\\HickTool\\VLC.exe");
            MessageBox.Show("Done");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://www.vmware.com/go/getworkstation-win", "C:\\HickTool\\vmware.exe");
            MessageBox.Show("Done");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            client.DownloadFile("https://hickos.hickdick.workers.dev/0:/NVCleanstall_1.13.0.exe", "C:\\HickTool\\NVCleanstall.exe");
            MessageBox.Show("Done");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Close();
        }
    }
}
