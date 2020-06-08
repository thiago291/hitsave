namespace ArchiveOrgUploader
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFileSelect = new System.Windows.Forms.Button();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericBitDepth = new System.Windows.Forms.NumericUpDown();
            this.numericDPI = new System.Windows.Forms.NumericUpDown();
            this.comboScanner = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkQ13 = new System.Windows.Forms.CheckBox();
            this.checkRAW = new System.Windows.Forms.CheckBox();
            this.checkICM = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericGameYear = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listLanguages = new System.Windows.Forms.ListBox();
            this.comboRegion = new System.Windows.Forms.ComboBox();
            this.textSerial = new System.Windows.Forms.TextBox();
            this.comboSystem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPublisher = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkExtras = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkManual = new System.Windows.Forms.CheckBox();
            this.checkCover = new System.Windows.Forms.CheckBox();
            this.checkMedia = new System.Windows.Forms.CheckBox();
            this.textEdition = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChangeKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDefaultValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAddBatch = new System.Windows.Forms.Button();
            this.listBatches = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBitDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDPI)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGameYear)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFileSelect);
            this.groupBox1.Controls.Add(this.listFiles);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1: Select Files";
            // 
            // buttonFileSelect
            // 
            this.buttonFileSelect.Location = new System.Drawing.Point(6, 185);
            this.buttonFileSelect.Name = "buttonFileSelect";
            this.buttonFileSelect.Size = new System.Drawing.Size(372, 23);
            this.buttonFileSelect.TabIndex = 0;
            this.buttonFileSelect.Text = "Select Files";
            this.buttonFileSelect.UseVisualStyleBackColor = true;
            this.buttonFileSelect.Click += new System.EventHandler(this.buttonFileSelect_Click);
            // 
            // listFiles
            // 
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(6, 19);
            this.listFiles.Name = "listFiles";
            this.listFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listFiles.Size = new System.Drawing.Size(372, 160);
            this.listFiles.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericBitDepth);
            this.groupBox2.Controls.Add(this.numericDPI);
            this.groupBox2.Controls.Add(this.comboScanner);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkQ13);
            this.groupBox2.Controls.Add(this.checkRAW);
            this.groupBox2.Controls.Add(this.checkICM);
            this.groupBox2.Location = new System.Drawing.Point(6, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 173);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2: Scan Information";
            // 
            // numericBitDepth
            // 
            this.numericBitDepth.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericBitDepth.Location = new System.Drawing.Point(190, 53);
            this.numericBitDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericBitDepth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericBitDepth.Name = "numericBitDepth";
            this.numericBitDepth.Size = new System.Drawing.Size(176, 20);
            this.numericBitDepth.TabIndex = 13;
            this.numericBitDepth.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // numericDPI
            // 
            this.numericDPI.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericDPI.Location = new System.Drawing.Point(190, 27);
            this.numericDPI.Maximum = new decimal(new int[] {
            6400,
            0,
            0,
            0});
            this.numericDPI.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericDPI.Name = "numericDPI";
            this.numericDPI.Size = new System.Drawing.Size(176, 20);
            this.numericDPI.TabIndex = 12;
            this.numericDPI.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // comboScanner
            // 
            this.comboScanner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboScanner.FormattingEnabled = true;
            this.comboScanner.Items.AddRange(new object[] {
            "Epson V600",
            "Epson V800",
            "Canon CanoScan 9000f MKII"});
            this.comboScanner.Location = new System.Drawing.Point(190, 79);
            this.comboScanner.Name = "comboScanner";
            this.comboScanner.Size = new System.Drawing.Size(176, 21);
            this.comboScanner.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Scanner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Q13";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ICM Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RAW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bit Depth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DPI";
            // 
            // checkQ13
            // 
            this.checkQ13.AutoSize = true;
            this.checkQ13.Location = new System.Drawing.Point(190, 149);
            this.checkQ13.Name = "checkQ13";
            this.checkQ13.Size = new System.Drawing.Size(15, 14);
            this.checkQ13.TabIndex = 2;
            this.checkQ13.UseVisualStyleBackColor = true;
            // 
            // checkRAW
            // 
            this.checkRAW.AutoSize = true;
            this.checkRAW.Location = new System.Drawing.Point(190, 106);
            this.checkRAW.Name = "checkRAW";
            this.checkRAW.Size = new System.Drawing.Size(15, 14);
            this.checkRAW.TabIndex = 1;
            this.checkRAW.UseVisualStyleBackColor = true;
            // 
            // checkICM
            // 
            this.checkICM.AutoSize = true;
            this.checkICM.Location = new System.Drawing.Point(190, 126);
            this.checkICM.Name = "checkICM";
            this.checkICM.Size = new System.Drawing.Size(15, 14);
            this.checkICM.TabIndex = 0;
            this.checkICM.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericGameYear);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.listLanguages);
            this.groupBox3.Controls.Add(this.comboRegion);
            this.groupBox3.Controls.Add(this.textSerial);
            this.groupBox3.Controls.Add(this.comboSystem);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textPublisher);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.textEdition);
            this.groupBox3.Controls.Add(this.textTitle);
            this.groupBox3.Location = new System.Drawing.Point(402, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 407);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3: Game and Artwork Information";
            // 
            // numericGameYear
            // 
            this.numericGameYear.Location = new System.Drawing.Point(65, 124);
            this.numericGameYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericGameYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numericGameYear.Name = "numericGameYear";
            this.numericGameYear.Size = new System.Drawing.Size(299, 20);
            this.numericGameYear.TabIndex = 22;
            this.numericGameYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Languages";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Publisher";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Serial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Region";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Edition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "System";
            // 
            // listLanguages
            // 
            this.listLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLanguages.FormattingEnabled = true;
            this.listLanguages.ItemHeight = 16;
            this.listLanguages.Items.AddRange(new object[] {
            "English",
            "Japanese",
            "Spanish",
            "Italian",
            "African",
            "Arabic",
            "Brazilian Portuguese",
            "Bulgarian",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish"});
            this.listLanguages.Location = new System.Drawing.Point(75, 203);
            this.listLanguages.Name = "listLanguages";
            this.listLanguages.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listLanguages.Size = new System.Drawing.Size(289, 116);
            this.listLanguages.TabIndex = 14;
            // 
            // comboRegion
            // 
            this.comboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRegion.FormattingEnabled = true;
            this.comboRegion.Items.AddRange(new object[] {
            "NTSC-J",
            "NTSC-U",
            "PAL"});
            this.comboRegion.Location = new System.Drawing.Point(65, 176);
            this.comboRegion.Name = "comboRegion";
            this.comboRegion.Size = new System.Drawing.Size(299, 21);
            this.comboRegion.TabIndex = 12;
            // 
            // textSerial
            // 
            this.textSerial.Location = new System.Drawing.Point(65, 150);
            this.textSerial.Name = "textSerial";
            this.textSerial.Size = new System.Drawing.Size(299, 20);
            this.textSerial.TabIndex = 13;
            // 
            // comboSystem
            // 
            this.comboSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSystem.FormattingEnabled = true;
            this.comboSystem.Items.AddRange(new object[] {
            "Atari 2600",
            "Atari 5200",
            "Atari 8200",
            "Sony PlayStation 1",
            "Sony PlayStation 2",
            "Sony PlayStation 3",
            "Sony PlayStation 4",
            "Sony PlayStation Portable",
            "Sony PlayStation Vita",
            "Microsoft Xbox",
            "Microsoft Xbox 360",
            "Microsoft Xbox One"});
            this.comboSystem.Location = new System.Drawing.Point(65, 71);
            this.comboSystem.Name = "comboSystem";
            this.comboSystem.Size = new System.Drawing.Size(299, 21);
            this.comboSystem.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Title";
            // 
            // textPublisher
            // 
            this.textPublisher.Location = new System.Drawing.Point(65, 98);
            this.textPublisher.Name = "textPublisher";
            this.textPublisher.Size = new System.Drawing.Size(299, 20);
            this.textPublisher.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkExtras);
            this.groupBox4.Controls.Add(this.checkBox8);
            this.groupBox4.Controls.Add(this.checkManual);
            this.groupBox4.Controls.Add(this.checkCover);
            this.groupBox4.Controls.Add(this.checkMedia);
            this.groupBox4.Location = new System.Drawing.Point(6, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 73);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scanned Items";
            // 
            // checkExtras
            // 
            this.checkExtras.AutoSize = true;
            this.checkExtras.Location = new System.Drawing.Point(184, 47);
            this.checkExtras.Name = "checkExtras";
            this.checkExtras.Size = new System.Drawing.Size(55, 17);
            this.checkExtras.TabIndex = 6;
            this.checkExtras.Text = "Extras";
            this.checkExtras.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(232, 391);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(80, 17);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkManual
            // 
            this.checkManual.AutoSize = true;
            this.checkManual.Location = new System.Drawing.Point(184, 24);
            this.checkManual.Name = "checkManual";
            this.checkManual.Size = new System.Drawing.Size(61, 17);
            this.checkManual.TabIndex = 5;
            this.checkManual.Text = "Manual";
            this.checkManual.UseVisualStyleBackColor = true;
            // 
            // checkCover
            // 
            this.checkCover.AutoSize = true;
            this.checkCover.Location = new System.Drawing.Point(6, 24);
            this.checkCover.Name = "checkCover";
            this.checkCover.Size = new System.Drawing.Size(116, 17);
            this.checkCover.TabIndex = 4;
            this.checkCover.Text = "Cover / Packaging";
            this.checkCover.UseVisualStyleBackColor = true;
            // 
            // checkMedia
            // 
            this.checkMedia.AutoSize = true;
            this.checkMedia.Location = new System.Drawing.Point(6, 47);
            this.checkMedia.Name = "checkMedia";
            this.checkMedia.Size = new System.Drawing.Size(109, 17);
            this.checkMedia.TabIndex = 3;
            this.checkMedia.Text = "Media (Disc/Cart)";
            this.checkMedia.UseVisualStyleBackColor = true;
            // 
            // textEdition
            // 
            this.textEdition.Location = new System.Drawing.Point(65, 45);
            this.textEdition.Name = "textEdition";
            this.textEdition.Size = new System.Drawing.Size(299, 20);
            this.textEdition.TabIndex = 0;
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(65, 19);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(299, 20);
            this.textTitle.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Controls.Add(this.buttonUpload);
            this.groupBox5.Location = new System.Drawing.Point(12, 647);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(760, 102);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step 4: Upload";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 67);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(748, 29);
            this.progressBar1.TabIndex = 5;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Location = new System.Drawing.Point(6, 19);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(748, 42);
            this.buttonUpload.TabIndex = 4;
            this.buttonUpload.Text = "Upload all batches";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.Multiselect = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.valuesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChangeKeysToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "Keys";
            // 
            // addChangeKeysToolStripMenuItem
            // 
            this.addChangeKeysToolStripMenuItem.Name = "addChangeKeysToolStripMenuItem";
            this.addChangeKeysToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addChangeKeysToolStripMenuItem.Text = "Add/Change keys...";
            this.addChangeKeysToolStripMenuItem.Click += new System.EventHandler(this.addChangeKeysToolStripMenuItem_Click);
            // 
            // valuesToolStripMenuItem
            // 
            this.valuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDefaultValuesToolStripMenuItem});
            this.valuesToolStripMenuItem.Name = "valuesToolStripMenuItem";
            this.valuesToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.valuesToolStripMenuItem.Text = "Values";
            // 
            // addDefaultValuesToolStripMenuItem
            // 
            this.addDefaultValuesToolStripMenuItem.Name = "addDefaultValuesToolStripMenuItem";
            this.addDefaultValuesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addDefaultValuesToolStripMenuItem.Text = "Add default values";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(412, 440);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(360, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 440);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(360, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset Values to Default";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonAddBatch
            // 
            this.buttonAddBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBatch.Location = new System.Drawing.Point(12, 498);
            this.buttonAddBatch.Name = "buttonAddBatch";
            this.buttonAddBatch.Size = new System.Drawing.Size(760, 42);
            this.buttonAddBatch.TabIndex = 6;
            this.buttonAddBatch.Text = "Add new batch";
            this.buttonAddBatch.UseVisualStyleBackColor = true;
            this.buttonAddBatch.Click += new System.EventHandler(this.buttonAddBatch_Click);
            // 
            // listBatches
            // 
            this.listBatches.FormattingEnabled = true;
            this.listBatches.Location = new System.Drawing.Point(208, 546);
            this.listBatches.Name = "listBatches";
            this.listBatches.Size = new System.Drawing.Size(372, 95);
            this.listBatches.TabIndex = 4;
            this.listBatches.SelectedIndexChanged += new System.EventHandler(this.listBatches_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.listBatches);
            this.Controls.Add(this.buttonAddBatch);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VGSC Uploader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBitDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDPI)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGameYear)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkQ13;
        private System.Windows.Forms.CheckBox checkRAW;
        private System.Windows.Forms.CheckBox checkICM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkExtras;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkManual;
        private System.Windows.Forms.CheckBox checkCover;
        private System.Windows.Forms.CheckBox checkMedia;
        private System.Windows.Forms.TextBox textEdition;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Button buttonFileSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboScanner;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listLanguages;
        private System.Windows.Forms.ComboBox comboRegion;
        private System.Windows.Forms.TextBox textSerial;
        private System.Windows.Forms.ComboBox comboSystem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPublisher;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown numericBitDepth;
        private System.Windows.Forms.NumericUpDown numericDPI;
        private System.Windows.Forms.NumericUpDown numericGameYear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addChangeKeysToolStripMenuItem;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAddBatch;
        private System.Windows.Forms.ListBox listBatches;
        private System.Windows.Forms.ToolStripMenuItem valuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDefaultValuesToolStripMenuItem;
    }
}

