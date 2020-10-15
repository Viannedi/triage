using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace cleartools
{
    public partial class clearTools : Form
    {

        public clearTools()
        {
            InitializeComponent();
            updateBar.LinkClicked += linkLabel1_LinkClicked;

        }

        public string extension;

        private void clearTools_Load(object sender, EventArgs e)
        {

            string version = "0.1";
            string responeText = new WebClient().DownloadString("https://phpupdate.herokuapp.com/test.txt");
            responeText = responeText.Replace("\n", "");
            if (responeText != version)
            {
                string test = responeText;
                updateBar.Text = "Доступно новое обновление";
            }
            else
            {
                updateBar.Text = $"v{version} B";
            }
        }
        void MonitorDesktop(string path)
        {
            FileSystemWatcher fileWatcher = new FileSystemWatcher();
            fileWatcher.Path = path;
            fileWatcher.Created += onDesktop;
            fileWatcher.EnableRaisingEvents = true;
        }
        void onDesktop(object sender, FileSystemEventArgs e)
        {
            FileInfo fi = new FileInfo(e.FullPath);
            string[] extensions = extension.Split(",");
            foreach(var k in extensions)
            {
                if (fi.Extension == k)
                {
                    string path;
                    switch (k)
                    {
                        case ".mp4":
                        case ".avi":
                            path = labelVideo.Text;
                            break;
                        case ".txt":
                            path = labelImg.Text;
                            break;
                        case ".rtf":
                            path = labelDoc.Text;
                            break;
                        case ".ink":
                        case ".exe":
                            path = labelExe.Text;
                            break;
                        default:
                            path = "0";
                            break;
                    }
                    File.Move(e.FullPath, @$"{path}\{e.Name}");


                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            MonitorDesktop(desktopPath);
            extension = "";
            if (imgBox.Checked)
            {
                extension += ".txt,";
            }
            if (docBox.Checked)
            {
                extension += ".rtf,";
            }
            if (videoBox.Checked)
            {
                extension += ".mp4,";
            }
            if (exeBox.Checked)
            {
                extension += ".exe,.lnk,";
            }
        }
        private void selectPath_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                switch (((Button)sender).Name)
                {
                    case "selectPath":
                        labelImg.Text = FBD.SelectedPath;
                        break;
                    case "videoPath":
                        labelVideo.Text = FBD.SelectedPath;
                        break;
                    case "docPath":
                        labelDoc.Text = FBD.SelectedPath;
                        break;
                    case "exePath":
                        labelExe.Text = FBD.SelectedPath;
                        break;
                    default:
                        break;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void docPath_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://metanit.com");
        }

        private void clearTools_Load_1(object sender, EventArgs e)
        {

        }
    }
}
