namespace NoPeekCloud
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.btnStopExtract = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstRunLog = new System.Windows.Forms.ListView();
            this.clmRunDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRunTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRunText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSyncNumberOfFiles = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSyncStopWatch = new System.Windows.Forms.TextBox();
            this.txtLastRun = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRemainingTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtFileTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProgressFile = new System.Windows.Forms.TextBox();
            this.txtFileCurrent = new System.Windows.Forms.TextBox();
            this.txtProgressFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSyncStop = new System.Windows.Forms.Button();
            this.btnSyncStart = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btn7zip = new System.Windows.Forms.Button();
            this.btnUpdateFolder = new System.Windows.Forms.Button();
            this.btnConfigSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numChangeDelay = new System.Windows.Forms.NumericUpDown();
            this.chkForceCreation = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCompressionMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numScanInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFolderTarget = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFolderSource = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemoveFolder = new System.Windows.Forms.Button();
            this.lstFolders = new System.Windows.Forms.ListView();
            this.clmSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.lstLog = new System.Windows.Forms.ListView();
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSynchronize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslForceWarning = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslUnprocessedChanges = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabStatus);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.btnStopExtract);
            this.tabStatus.Controls.Add(this.btnExtract);
            this.tabStatus.Controls.Add(this.groupBox5);
            this.tabStatus.Controls.Add(this.groupBox4);
            this.tabStatus.Controls.Add(this.groupBox2);
            this.tabStatus.Controls.Add(this.btnSyncStop);
            this.tabStatus.Controls.Add(this.btnSyncStart);
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(733, 371);
            this.tabStatus.TabIndex = 0;
            this.tabStatus.Text = "Status";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // btnStopExtract
            // 
            this.btnStopExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopExtract.Enabled = false;
            this.btnStopExtract.Image = global::NoPeekCloud.Properties.Resources.Folder_Delete_icon;
            this.btnStopExtract.Location = new System.Drawing.Point(143, 325);
            this.btnStopExtract.Name = "btnStopExtract";
            this.btnStopExtract.Size = new System.Drawing.Size(40, 40);
            this.btnStopExtract.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnStopExtract, "Cancel file extraction");
            this.btnStopExtract.UseVisualStyleBackColor = true;
            this.btnStopExtract.Click += new System.EventHandler(this.btnStopExtract_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExtract.Image = global::NoPeekCloud.Properties.Resources.unarchive_icon;
            this.btnExtract.Location = new System.Drawing.Point(97, 325);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(40, 40);
            this.btnExtract.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnExtract, "Extract files");
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lstRunLog);
            this.groupBox5.Location = new System.Drawing.Point(190, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(537, 219);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Run log";
            // 
            // lstRunLog
            // 
            this.lstRunLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRunLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmRunDate,
            this.clmRunTime,
            this.clmRunText});
            this.lstRunLog.FullRowSelect = true;
            this.lstRunLog.GridLines = true;
            this.lstRunLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstRunLog.Location = new System.Drawing.Point(6, 19);
            this.lstRunLog.MultiSelect = false;
            this.lstRunLog.Name = "lstRunLog";
            this.lstRunLog.Size = new System.Drawing.Size(525, 194);
            this.lstRunLog.TabIndex = 4;
            this.lstRunLog.UseCompatibleStateImageBehavior = false;
            this.lstRunLog.View = System.Windows.Forms.View.Details;
            this.lstRunLog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstRunLog_MouseUp);
            // 
            // clmRunDate
            // 
            this.clmRunDate.Text = "Date";
            // 
            // clmRunTime
            // 
            this.clmRunTime.Text = "Time";
            // 
            // clmRunText
            // 
            this.clmRunText.Text = "Text";
            this.clmRunText.Width = 350;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtSyncNumberOfFiles);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtSyncStopWatch);
            this.groupBox4.Controls.Add(this.txtLastRun);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(6, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 144);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Last sync";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Files synced";
            // 
            // txtSyncNumberOfFiles
            // 
            this.txtSyncNumberOfFiles.Location = new System.Drawing.Point(9, 110);
            this.txtSyncNumberOfFiles.Name = "txtSyncNumberOfFiles";
            this.txtSyncNumberOfFiles.ReadOnly = true;
            this.txtSyncNumberOfFiles.Size = new System.Drawing.Size(159, 20);
            this.txtSyncNumberOfFiles.TabIndex = 21;
            this.txtSyncNumberOfFiles.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Time elapsed";
            // 
            // txtSyncStopWatch
            // 
            this.txtSyncStopWatch.Location = new System.Drawing.Point(9, 71);
            this.txtSyncStopWatch.Name = "txtSyncStopWatch";
            this.txtSyncStopWatch.ReadOnly = true;
            this.txtSyncStopWatch.Size = new System.Drawing.Size(159, 20);
            this.txtSyncStopWatch.TabIndex = 19;
            this.txtSyncStopWatch.TabStop = false;
            // 
            // txtLastRun
            // 
            this.txtLastRun.Location = new System.Drawing.Point(9, 32);
            this.txtLastRun.Name = "txtLastRun";
            this.txtLastRun.ReadOnly = true;
            this.txtLastRun.Size = new System.Drawing.Size(159, 20);
            this.txtLastRun.TabIndex = 18;
            this.txtLastRun.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtRemainingTime);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.txtFileTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtProgressFile);
            this.groupBox2.Controls.Add(this.txtFileCurrent);
            this.groupBox2.Controls.Add(this.txtProgressFolder);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 134);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Progress";
            // 
            // txtRemainingTime
            // 
            this.txtRemainingTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemainingTime.Location = new System.Drawing.Point(660, 71);
            this.txtRemainingTime.Name = "txtRemainingTime";
            this.txtRemainingTime.ReadOnly = true;
            this.txtRemainingTime.Size = new System.Drawing.Size(55, 20);
            this.txtRemainingTime.TabIndex = 18;
            this.txtRemainingTime.TabStop = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(597, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Remaining";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(9, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(706, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // txtFileTotal
            // 
            this.txtFileTotal.Location = new System.Drawing.Point(87, 71);
            this.txtFileTotal.Name = "txtFileTotal";
            this.txtFileTotal.ReadOnly = true;
            this.txtFileTotal.Size = new System.Drawing.Size(50, 20);
            this.txtFileTotal.TabIndex = 18;
            this.txtFileTotal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "of";
            // 
            // txtProgressFile
            // 
            this.txtProgressFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProgressFile.Location = new System.Drawing.Point(184, 71);
            this.txtProgressFile.Name = "txtProgressFile";
            this.txtProgressFile.ReadOnly = true;
            this.txtProgressFile.Size = new System.Drawing.Size(407, 20);
            this.txtProgressFile.TabIndex = 15;
            this.txtProgressFile.TabStop = false;
            // 
            // txtFileCurrent
            // 
            this.txtFileCurrent.Location = new System.Drawing.Point(9, 71);
            this.txtFileCurrent.Name = "txtFileCurrent";
            this.txtFileCurrent.ReadOnly = true;
            this.txtFileCurrent.Size = new System.Drawing.Size(50, 20);
            this.txtFileCurrent.TabIndex = 17;
            this.txtFileCurrent.TabStop = false;
            // 
            // txtProgressFolder
            // 
            this.txtProgressFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProgressFolder.Location = new System.Drawing.Point(9, 32);
            this.txtProgressFolder.Name = "txtProgressFolder";
            this.txtProgressFolder.ReadOnly = true;
            this.txtProgressFolder.Size = new System.Drawing.Size(706, 20);
            this.txtProgressFolder.TabIndex = 14;
            this.txtProgressFolder.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "File";
            // 
            // btnSyncStop
            // 
            this.btnSyncStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSyncStop.Enabled = false;
            this.btnSyncStop.Image = global::NoPeekCloud.Properties.Resources.stop_alt_icon;
            this.btnSyncStop.Location = new System.Drawing.Point(52, 325);
            this.btnSyncStop.Name = "btnSyncStop";
            this.btnSyncStop.Size = new System.Drawing.Size(40, 40);
            this.btnSyncStop.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnSyncStop, "Stop sync");
            this.btnSyncStop.UseVisualStyleBackColor = true;
            this.btnSyncStop.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSyncStart
            // 
            this.btnSyncStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSyncStart.Image = global::NoPeekCloud.Properties.Resources.play_icon;
            this.btnSyncStart.Location = new System.Drawing.Point(6, 325);
            this.btnSyncStart.Name = "btnSyncStart";
            this.btnSyncStart.Size = new System.Drawing.Size(40, 40);
            this.btnSyncStart.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSyncStart, "Start sync");
            this.btnSyncStart.UseVisualStyleBackColor = true;
            this.btnSyncStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.btn7zip);
            this.tabSettings.Controls.Add(this.btnUpdateFolder);
            this.tabSettings.Controls.Add(this.btnConfigSave);
            this.tabSettings.Controls.Add(this.groupBox3);
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Controls.Add(this.btnRemoveFolder);
            this.tabSettings.Controls.Add(this.lstFolders);
            this.tabSettings.Controls.Add(this.btnAddFolder);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(733, 371);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btn7zip
            // 
            this.btn7zip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn7zip.Image = global::NoPeekCloud.Properties.Resources._7zip_icon;
            this.btn7zip.Location = new System.Drawing.Point(504, 325);
            this.btn7zip.Name = "btn7zip";
            this.btn7zip.Size = new System.Drawing.Size(40, 40);
            this.btn7zip.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn7zip, "Select 7-Zip location");
            this.btn7zip.UseVisualStyleBackColor = true;
            this.btn7zip.Click += new System.EventHandler(this.btn7zip_Click);
            // 
            // btnUpdateFolder
            // 
            this.btnUpdateFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateFolder.Enabled = false;
            this.btnUpdateFolder.Image = global::NoPeekCloud.Properties.Resources.folder_edit_icon;
            this.btnUpdateFolder.Location = new System.Drawing.Point(595, 325);
            this.btnUpdateFolder.Name = "btnUpdateFolder";
            this.btnUpdateFolder.Size = new System.Drawing.Size(40, 40);
            this.btnUpdateFolder.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnUpdateFolder, "Edit folder");
            this.btnUpdateFolder.UseVisualStyleBackColor = true;
            this.btnUpdateFolder.Click += new System.EventHandler(this.btnUpdateFolder_Click);
            // 
            // btnConfigSave
            // 
            this.btnConfigSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigSave.Image = global::NoPeekCloud.Properties.Resources.Floppy_Large_icon;
            this.btnConfigSave.Location = new System.Drawing.Point(687, 325);
            this.btnConfigSave.Name = "btnConfigSave";
            this.btnConfigSave.Size = new System.Drawing.Size(40, 40);
            this.btnConfigSave.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnConfigSave, "Save settings");
            this.btnConfigSave.UseVisualStyleBackColor = true;
            this.btnConfigSave.Click += new System.EventHandler(this.btnConfigSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.numChangeDelay);
            this.groupBox3.Controls.Add(this.chkForceCreation);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbCompressionMode);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPassword2);
            this.groupBox3.Controls.Add(this.txtPassword1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numScanInterval);
            this.groupBox3.Location = new System.Drawing.Point(495, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 176);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Change delay in minutes (0=disable)";
            // 
            // numChangeDelay
            // 
            this.numChangeDelay.Location = new System.Drawing.Point(185, 45);
            this.numChangeDelay.Name = "numChangeDelay";
            this.numChangeDelay.Size = new System.Drawing.Size(41, 20);
            this.numChangeDelay.TabIndex = 1;
            // 
            // chkForceCreation
            // 
            this.chkForceCreation.AutoSize = true;
            this.chkForceCreation.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkForceCreation.Location = new System.Drawing.Point(211, 152);
            this.chkForceCreation.Name = "chkForceCreation";
            this.chkForceCreation.Size = new System.Drawing.Size(15, 14);
            this.chkForceCreation.TabIndex = 5;
            this.chkForceCreation.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Force creation of compressed files";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Compression mode";
            // 
            // cmbCompressionMode
            // 
            this.cmbCompressionMode.FormattingEnabled = true;
            this.cmbCompressionMode.Items.AddRange(new object[] {
            "None",
            "Low",
            "Fast",
            "Normal",
            "Maximum",
            "Ultra"});
            this.cmbCompressionMode.Location = new System.Drawing.Point(108, 123);
            this.cmbCompressionMode.Name = "cmbCompressionMode";
            this.cmbCompressionMode.Size = new System.Drawing.Size(118, 21);
            this.cmbCompressionMode.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Retype";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(65, 97);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(161, 20);
            this.txtPassword2.TabIndex = 3;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(65, 71);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(161, 20);
            this.txtPassword1.TabIndex = 2;
            this.txtPassword1.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Scan interval in hours (0=disable)";
            // 
            // numScanInterval
            // 
            this.numScanInterval.Location = new System.Drawing.Point(185, 19);
            this.numScanInterval.Name = "numScanInterval";
            this.numScanInterval.Size = new System.Drawing.Size(41, 20);
            this.numScanInterval.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFolderTarget);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtFolderSource);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(495, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folders";
            // 
            // txtFolderTarget
            // 
            this.txtFolderTarget.Location = new System.Drawing.Point(9, 71);
            this.txtFolderTarget.Name = "txtFolderTarget";
            this.txtFolderTarget.Size = new System.Drawing.Size(217, 20);
            this.txtFolderTarget.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Target";
            // 
            // txtFolderSource
            // 
            this.txtFolderSource.Location = new System.Drawing.Point(9, 32);
            this.txtFolderSource.Name = "txtFolderSource";
            this.txtFolderSource.Size = new System.Drawing.Size(217, 20);
            this.txtFolderSource.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Source";
            // 
            // btnRemoveFolder
            // 
            this.btnRemoveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFolder.Enabled = false;
            this.btnRemoveFolder.Image = global::NoPeekCloud.Properties.Resources.folder_remove_icon;
            this.btnRemoveFolder.Location = new System.Drawing.Point(641, 325);
            this.btnRemoveFolder.Name = "btnRemoveFolder";
            this.btnRemoveFolder.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveFolder.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnRemoveFolder, "Remove folder");
            this.btnRemoveFolder.UseVisualStyleBackColor = true;
            this.btnRemoveFolder.Click += new System.EventHandler(this.btnRemoveFolder_Click);
            // 
            // lstFolders
            // 
            this.lstFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSource,
            this.clmTarget});
            this.lstFolders.FullRowSelect = true;
            this.lstFolders.GridLines = true;
            this.lstFolders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstFolders.HideSelection = false;
            this.lstFolders.Location = new System.Drawing.Point(6, 6);
            this.lstFolders.MultiSelect = false;
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(483, 359);
            this.lstFolders.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstFolders.TabIndex = 0;
            this.lstFolders.UseCompatibleStateImageBehavior = false;
            this.lstFolders.View = System.Windows.Forms.View.Details;
            this.lstFolders.SelectedIndexChanged += new System.EventHandler(this.lstFolders_SelectedIndexChanged);
            // 
            // clmSource
            // 
            this.clmSource.Text = "Source";
            this.clmSource.Width = 225;
            // 
            // clmTarget
            // 
            this.clmTarget.Text = "Target";
            this.clmTarget.Width = 225;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFolder.Image = global::NoPeekCloud.Properties.Resources.folder_add_icon;
            this.btnAddFolder.Location = new System.Drawing.Point(549, 325);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(40, 40);
            this.btnAddFolder.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAddFolder, "Add folder");
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.lstLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(733, 371);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDate,
            this.clmTime,
            this.clmFolder,
            this.clmFile,
            this.clmInfo});
            this.lstLog.FullRowSelect = true;
            this.lstLog.GridLines = true;
            this.lstLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstLog.Location = new System.Drawing.Point(6, 6);
            this.lstLog.MultiSelect = false;
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(721, 359);
            this.lstLog.TabIndex = 0;
            this.lstLog.UseCompatibleStateImageBehavior = false;
            this.lstLog.View = System.Windows.Forms.View.Details;
            this.lstLog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstLog_MouseUp);
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            // 
            // clmTime
            // 
            this.clmTime.Text = "Time";
            // 
            // clmFolder
            // 
            this.clmFolder.Text = "Folder";
            this.clmFolder.Width = 250;
            // 
            // clmFile
            // 
            this.clmFile.Text = "File";
            this.clmFile.Width = 100;
            // 
            // clmInfo
            // 
            this.clmInfo.Text = "Information";
            this.clmInfo.Width = 225;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NoPeekCloud";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRestore,
            this.toolStripSeparator2,
            this.mnuSynchronize,
            this.toolStripSeparator1,
            this.mnuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 82);
            // 
            // mnuRestore
            // 
            this.mnuRestore.Image = global::NoPeekCloud.Properties.Resources.open_window;
            this.mnuRestore.Name = "mnuRestore";
            this.mnuRestore.Size = new System.Drawing.Size(138, 22);
            this.mnuRestore.Text = "Restore";
            this.mnuRestore.Click += new System.EventHandler(this.mnuRestore_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // mnuSynchronize
            // 
            this.mnuSynchronize.Image = global::NoPeekCloud.Properties.Resources.Sync_icon;
            this.mnuSynchronize.Name = "mnuSynchronize";
            this.mnuSynchronize.Size = new System.Drawing.Size(138, 22);
            this.mnuSynchronize.Text = "Synchronize";
            this.mnuSynchronize.Click += new System.EventHandler(this.mnuSynchronize_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::NoPeekCloud.Properties.Resources.exit;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(138, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslForceWarning,
            this.tslUnprocessedChanges,
            this.toolStripProgressBar1,
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(765, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslForceWarning
            // 
            this.tslForceWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslForceWarning.ForeColor = System.Drawing.Color.Red;
            this.tslForceWarning.Name = "tslForceWarning";
            this.tslForceWarning.Size = new System.Drawing.Size(122, 17);
            this.tslForceWarning.Text = "Forcing file creation!";
            this.tslForceWarning.Visible = false;
            // 
            // tslUnprocessedChanges
            // 
            this.tslUnprocessedChanges.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslUnprocessedChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tslUnprocessedChanges.Name = "tslUnprocessedChanges";
            this.tslUnprocessedChanges.Size = new System.Drawing.Size(131, 17);
            this.tslUnprocessedChanges.Text = "Unprocessed changes!";
            this.tslUnprocessedChanges.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(39, 17);
            this.tslStatus.Text = "Status";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "No Peek Cloud";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.Button btnSyncStart;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.ColumnHeader clmTime;
        private System.Windows.Forms.ColumnHeader clmFolder;
        private System.Windows.Forms.ColumnHeader clmFile;
        private System.Windows.Forms.ColumnHeader clmInfo;
        private System.Windows.Forms.ListView lstFolders;
        private System.Windows.Forms.ColumnHeader clmSource;
        private System.Windows.Forms.ColumnHeader clmTarget;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSynchronize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSyncStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProgressFile;
        private System.Windows.Forms.TextBox txtProgressFolder;
        private System.Windows.Forms.TextBox txtFileTotal;
        private System.Windows.Forms.TextBox txtFileCurrent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLastRun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSyncStopWatch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateFolder;
        private System.Windows.Forms.TextBox txtFolderTarget;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFolderSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRemainingTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ToolStripStatusLabel tslUnprocessedChanges;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.NumericUpDown numScanInterval;
        public System.Windows.Forms.TextBox txtPassword1;
        public System.Windows.Forms.TextBox txtPassword2;
        public System.Windows.Forms.ComboBox cmbCompressionMode;
        public System.Windows.Forms.CheckBox chkForceCreation;
        public System.Windows.Forms.NumericUpDown numChangeDelay;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripStatusLabel tslForceWarning;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSyncNumberOfFiles;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lstRunLog;
        private System.Windows.Forms.ColumnHeader clmRunDate;
        private System.Windows.Forms.ColumnHeader clmRunTime;
        private System.Windows.Forms.ColumnHeader clmRunText;
        private System.Windows.Forms.ToolStripMenuItem mnuRestore;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnStopExtract;
        private System.Windows.Forms.Button btn7zip;
        private System.Windows.Forms.ColumnHeader clmDate;
        public System.Windows.Forms.ListView lstLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

