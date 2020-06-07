using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchiveOrgUploader.Properties;

namespace ArchiveOrgUploader
{
    public partial class FormKeys : Form
    {
        public FormKeys()
        {
            InitializeComponent();
        }

        private void linkKeys_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://archive.org/account/s3.php");
        }

        private void buttonSave_Click(object sender, EventArgs e) //saves the keys into the user's default settings
        {
            if ((textS3Access.Text != "") && (textS3Secret.Text != ""))
            {
                Settings.Default["S3AccessKey"] = textS3Access.Text;
                Settings.Default["S3SecretKey"] = textS3Secret.Text;
                Settings.Default.Save();
                //MessageBox.Show(Settings.Default["S3AccessKey"].ToString());
                //MessageBox.Show(Settings.Default["S3SecretKey"].ToString());
                MessageBox.Show("Keys sucessfully saved.");
                this.Close();
            }
            else
                MessageBox.Show("New key values can't be null.");
        }
    }
}
