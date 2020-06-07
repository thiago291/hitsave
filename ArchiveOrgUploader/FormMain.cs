using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchiveOrgUploader.Properties;
using System.Text.Json;

namespace ArchiveOrgUploader
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        List<FileInfo> _fileInfo = new List<FileInfo>();
        
        int _dpi, _bitdepth, _year;
        string _files, _languages;
        string _scanner, _title, _edition, _system, _publisher, _serial, _region;
        bool _raw, _icm, _q13, _coverPackage, _media, _manual, _extras;

        private void valueSaver()
        {
            _files = null;
            _languages = null;
            foreach (string item in listFiles.Items)
                _files += item + " ";
            _dpi = (int)numericDPI.Value;
            _bitdepth = (int)numericBitDepth.Value;
            _scanner = comboScanner.Text;
            _raw = checkRAW.Checked;
            _icm = checkICM.Checked;
            _q13 = checkQ13.Checked;
            _title = textTitle.Text;
            _edition = textEdition.Text;
            _system = comboSystem.Text;
            _publisher = textPublisher.Text;
            _year = (int)numericGameYear.Value;
            _serial = textSerial.Text;
            _region = comboRegion.Text;
            foreach (string lang in listLanguages.SelectedItems)
                _languages += lang + " ";
            _coverPackage = checkCover.Checked;
            _media = checkMedia.Checked;
            _manual = checkManual.Checked;
            _extras = checkExtras.Checked;
            _fileInfo.Add(new FileInfo());
        }

        private void buttonFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listFiles.Items.Clear();
                foreach (string file in openFileDialog1.FileNames)
                {
                    listFiles.Items.Add(file);
                }
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            if ((Settings.Default["S3AccessKey"].ToString() == "")
                || (Settings.Default["S3SecretKey"].ToString() == ""))
                MessageBox.Show("Please put your Archive.org access keys under 'Keys > Add/Change keys...'");
            else
            {
                valueSaver();
                MessageBox.Show("files:" + _files
                    + "\ns3access: " + Settings.Default["S3AccessKey"].ToString()
                    + "\ns3secret: " + Settings.Default["S3SecretKey"].ToString()
                    + "\ndpi: " + _dpi
                    + "\nbit depth: " + _bitdepth
                    + "\nscanner: " + _scanner
                    + "\nraw: " + _raw
                    + "\nicm: " + _icm
                    + "\nq13: " + _q13
                    + "\nedition: " + _edition
                    + "\nsystem: " + _system
                    + "\npublisher: " + _publisher
                    + "\nyear: " + _year
                    + "\nserial: " + _serial
                    + "\nregion: " + _region
                    + "\nlanguages: " + _languages
                    + "\ncover package: " + _coverPackage
                    + "\nmedia: " + _media
                    + "\nmanual: " + _manual
                    + "\nExtras: " + _extras);
            }
        }

        private void addChangeKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKeys _formKeys = new FormKeys();
            _formKeys.Show();

        }
    }
}
