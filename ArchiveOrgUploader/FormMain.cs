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
using System.Collections;

namespace ArchiveOrgUploader
{
    public partial class FormMain : Form
    {
        public FormMain() => InitializeComponent();

        readonly List<Batch> _batch = new List<Batch>();
        
        int _dpi, _bitd, _year, _i=1;
        string _files, _languages;
        string _scanner, _title, _edition, _system, _publisher, _serial, _region;

        private void listBatches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddBatch_Click(object sender, EventArgs e)
        {
            valueSaver();
            _batch.Add(new Batch {FilePath=_files, DPI=_dpi, BitDepth = _bitd, 
                Scanner = _scanner, Raw = _raw, ICM = _icm, Q13 = _q13, 
                Title = _title, Edition = _edition, System = _system,
                Publisher = _publisher, Year = _year, Serial = _serial, 
                Region = _region,Languages = _languages, Cover = _coverPackage, 
                Media = _media, Manual = _manual, Extras = _extras});
            listBatches.Items.Add("#" + _i + " " + _batch);
            _i++;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericDPI.Value = 800;
            numericBitDepth.Value = 40;
            comboScanner.Text = null;
            checkRAW.Checked = false;
            checkICM.Checked = false;
            checkQ13.Checked = false;
            textTitle.Text = null;
            textEdition.Text = null;
            comboSystem.Text = null;
            textPublisher.Text = null;
            numericGameYear.Value = 2000;
            textSerial.Text = null;
            comboRegion.Text = null;
            listLanguages.SelectedItems.Clear();
            checkCover.Checked = false;
            checkMedia.Checked = false;
            checkManual.Checked = false;
            checkExtras.Checked = false;
        }

        bool _raw, _icm, _q13, _coverPackage, _media, _manual, _extras;

        private void valueSaver()
        {
            _files = null;
            _languages = null;
            foreach (string item in listFiles.Items)
                _files += item + " ";
            _dpi = (int)numericDPI.Value;
            _bitd = (int)numericBitDepth.Value;
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
            _batch.Add(new Batch());
        }

        private void buttonFileSelect_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                Multiselect = true
            };
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
                    + "\nbit depth: " + _bitd
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
            var _formKeys = new FormKeys();
            _formKeys.Show();

        }
    }
}
