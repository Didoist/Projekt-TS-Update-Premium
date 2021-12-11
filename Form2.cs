using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace animated_rain_loading
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            var client = new WebClient();
            try
            {
             
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\TS Luncher.exe");
                client.DownloadFile("https://github.com/Didoist/TS-Luncher/raw/main/TS%20Luncher.zip", @"TS Luncher.zip");
                string zipPath = @".\TS Luncher.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\TS Luncher.zip");
                Process.Start("TS Luncher.exe");



                Application.Exit(); 
            }
            catch
            {


                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
