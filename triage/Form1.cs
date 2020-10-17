using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triage
{
    public partial class Form1 : Form
    {
        // list ex
        public string extension;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string version = "0.1.1";
            string responeText = new WebClient().DownloadString("https://phpupdate.herokuapp.com/version.txt");
            responeText = responeText.Replace("\n", "");
            if (responeText != version)
            {
                string test = responeText;
                updateBtn.Visible = true;
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
            foreach (var k in extensions)
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
                        case ".png":
                        case ".jpg":
                        case ".jpeg":
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
                    try
                    {
                        File.Move(e.FullPath, @$"{path}\{e.Name}");

                    }
                    catch(DirectoryNotFoundException)
                    {
                        this.Invoke((Action)(() => path = infoMenu.Text = "Directory not found"));
                    }

                }
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            
            MonitorDesktop(desktopPath);

            extension = "";
            if (imgBox.Checked)
            {
                extension += ".png,.jpg,.jpeg";
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "http://phpupdate.herokuapp.com/triage(x64)-setup.exe");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
