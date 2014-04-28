using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;

namespace NoPeekCloud
{
    public partial class frmMain : Form
    {
        public static string currentFolder = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);

        public Config config = new Config();
        public LogWriter logWriter;

        BackgroundWorker SyncWorker = new BackgroundWorker();
        BackgroundWorker ExtractWorker = new BackgroundWorker();

        bool minimixeWindow = false;
        bool startAndExit = false;
        bool startSyncNow = false;

        public int changeTimer = -1;

        public Dictionary<string, string> filesRenamed = new Dictionary<string, string>();

        public const string FILE_TYPE = "7z";

        public frmMain(string[] args)
        {
            InitializeComponent();

            TextWriterTraceListener debugLog = new TextWriterTraceListener(currentFolder + string.Format("\\Debug_{0}.log", DateTime.Now.ToString("yy-MM-dd_HH-mm-ss")));

            Debug.Listeners.Add(debugLog);
            Debug.AutoFlush = true;

            logWriter = new LogWriter(lstLog, currentFolder + "\\NoPeekCloud.log");

            SyncWorker.WorkerReportsProgress = true;
            SyncWorker.WorkerSupportsCancellation = true;

            SyncWorker.DoWork += SyncWorker_DoWork;
            SyncWorker.ProgressChanged += Worker_ProgressChanged;
            SyncWorker.RunWorkerCompleted += SyncWorker_RunWorkerCompleted;

            ExtractWorker.WorkerReportsProgress = true;
            ExtractWorker.WorkerSupportsCancellation = true;

            ExtractWorker.DoWork += ExtractWorker_DoWork;
            ExtractWorker.ProgressChanged += Worker_ProgressChanged;
            ExtractWorker.RunWorkerCompleted += ExtractWorker_RunWorkerCompleted;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;

            foreach (string arg in args)
            {
                if (string.Equals(arg, "/Min", StringComparison.CurrentCultureIgnoreCase))
                {
                    minimixeWindow = true;
                }

                if (string.Equals(arg, "/Sync", StringComparison.CurrentCultureIgnoreCase))
                {
                    startSyncNow = true;
                }

                if (string.Equals(arg, "/SyncAndExit", StringComparison.CurrentCultureIgnoreCase))
                {
                    startAndExit = true;
                    startSyncNow = true;
                }
            }
        }

        void ExtractWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CtrlInvoke.ButtonEnable(btnStopExtract, false);
            CtrlInvoke.ButtonEnable(btnExtract, true);
            CtrlInvoke.ButtonEnable(btnSyncStart, true);

            CtrlInvoke.SetProgress(progressBar1, 0);

            if (!e.Cancelled) tslStatus.Text = "Extraction complete!";
            else tslStatus.Text = "Extraction stopped!";

            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is TextBox) ctrl.Text = string.Empty;
            }
        }

        void ExtractWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CtrlInvoke.ButtonEnable(btnStopExtract, true);
            CtrlInvoke.ButtonEnable(btnExtract, false);
            CtrlInvoke.ButtonEnable(btnSyncStart, false);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string argument = (string)e.Argument;
            string[] arguments = argument.Split(';');

            string source = arguments[0];
            string target = arguments[1];

            DirectoryInfo d = new DirectoryInfo(source);
            FileInfo[] fi = d.GetFiles(string.Format("*.{0}", frmMain.FILE_TYPE), System.IO.SearchOption.AllDirectories);

            RemainingTime rt = new RemainingTime(fi.Length, 250);

            CtrlInvoke.SetText(txtFileTotal, fi.Length.ToString());
            CtrlInvoke.SetStatus(statusStrip1, tslStatus, "Extracting...");

            int x = 0;
            foreach (FileInfo item in fi)
            {
                CtrlInvoke.SetText(txtFileCurrent, x.ToString());
                CtrlInvoke.SetText(txtProgressFolder, item.DirectoryName);
                CtrlInvoke.SetText(txtProgressFile, item.Name);

                string folder = item.DirectoryName.Replace(source, target);
                ProcHandler.ExtractFiles(item.FullName, folder);

                x++;
                ExtractWorker.ReportProgress(Function.ReturnPercent(x, fi.Length));

                CtrlInvoke.SetText(txtRemainingTime, rt.Calculate(stopWatch.ElapsedMilliseconds, x));
                if (ExtractWorker.CancellationPending) break;
            }

            stopWatch.Stop();
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Exception exp = (Exception)e.Exception;
            MsgManager.LaunchExceptionReporter(exp);
        }

        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exp = (Exception)e.ExceptionObject;
            MsgManager.LaunchExceptionReporter(exp);
        }

        void SyncWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CtrlInvoke.ButtonEnable(btnSyncStop, false);
            CtrlInvoke.ButtonEnable(btnSyncStart, true);
            CtrlInvoke.ButtonEnable(btnExtract, true);

            CtrlInvoke.SetProgress(progressBar1, 0);

            if (!e.Cancelled) tslStatus.Text = "Sync complete!";
            else tslStatus.Text = "Synchronize stopped!";

            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is TextBox) ctrl.Text = string.Empty;
            }

            if (startAndExit) this.Close();
            if (this.WindowState == FormWindowState.Minimized) notifyIcon1.ShowBalloonTip(5000, "NoPeekCloud", "Synchronize complete!", ToolTipIcon.Info);
        }

        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CtrlInvoke.SetProgress(progressBar1, e.ProgressPercentage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!SyncWorker.IsBusy)
            {
                SyncWorker.RunWorkerAsync("Manual sync");
            }
        }

        //private void HandleRename()
        //{
        //    foreach (var item in filesRenamed)
        //    {
        //        FileDetail fd = FileDetail.ReturnObject(item.Key);
        //        string oCompressed = fd.CompressedName;

        //        fd.OriginalName = item.Value;
        //        System.IO.File.Move(oCompressed, fd.CompressedName);

        //        Debug.Print("Renamed file {0} to {1}", oCompressed, fd.CompressedName);
        //        Log(System.IO.Path.GetDirectoryName(oCompressed), System.IO.Path.GetFileName(oCompressed), string.Format("File renamed to: {0}", fd.CompressedName), LogColor.Amber);
        //    }

        //    filesRenamed.Clear();
        //}

        void SyncWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CtrlInvoke.ButtonEnable(btnSyncStop, true);
            CtrlInvoke.ButtonEnable(btnSyncStart, false);
            CtrlInvoke.ButtonEnable(btnExtract, false);

            if (this.WindowState == FormWindowState.Minimized) notifyIcon1.ShowBalloonTip(5000, "NoPeekCloud", "Synchronizing...", ToolTipIcon.Info);

            ListViewItem runLogItem = new ListViewItem ( new[] { DateTime.Now.ToString("dd.MM.yy"), DateTime.Now.ToString("HH:mm:ss"), (string)e.Argument } );
            CtrlInvoke.SetLog(lstRunLog, runLogItem);

            List<FileDetail> tempFileDetail = new List<FileDetail>();
            CtrlInvoke.SetText(txtLastRun, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());

            Stopwatch stopWatch = new Stopwatch();
            if (string.IsNullOrEmpty(config.PasswordText)) MsgManager.Show("Password is empty, files will not be encrypted.", "Empty password", MessageBoxIcon.Warning);

            changeTimer = -1;
            int totalCount = 0;

            try
            {
                stopWatch.Start();
                CtrlInvoke.SetStatus(statusStrip1, tslStatus, "Renaming files...");
                //HandleRename();

                CtrlInvoke.SetStatus(statusStrip1, tslStatus, "Finding files...");

                int x = 0;

                foreach (FolderList fl in FolderList.list)
                {
                    System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(fl.Source);

                    Regex re = new Regex(@"(\.tmp|^~|^thumbs\.db$|^desktop\.ini$)", RegexOptions.IgnoreCase);
                    fl.SourceFiles.AddRange(d.EnumerateFiles("*.*", System.IO.SearchOption.AllDirectories).Where(f => !re.IsMatch(System.IO.Path.GetFileName(f.FullName))).ToList());

                    System.IO.DirectoryInfo dt = new System.IO.DirectoryInfo(fl.Target);
                    fl.CompressedFiles.AddRange(dt.GetFiles("*.*", System.IO.SearchOption.AllDirectories).Select(path => path.FullName).ToList());

                    totalCount += fl.SourceFiles.Count;
                }

                RemainingTime rt = new RemainingTime(totalCount, 250);

                CtrlInvoke.SetText(txtFileTotal, totalCount.ToString());
                CtrlInvoke.SetStatus(statusStrip1, tslStatus, "Synchronizing...");

                foreach (FolderList fl in FolderList.list)
                {
                    Debug.Print("Working on folder: {0}", fl.Source);
                    Debug.Indent();

                    foreach (var file in fl.SourceFiles)
                    {
                        Debug.Print("Found file: {0}", file.FullName);
                        Debug.Indent();

                        CtrlInvoke.SetText(txtFileCurrent, x.ToString());
                        CtrlInvoke.SetText(txtProgressFolder, file.DirectoryName);
                        CtrlInvoke.SetText(txtProgressFile, file.Name);

                        FileDetail fd = new FileDetail();
                        fd.OriginalName = file.FullName;
                        fd.OriginalPath = fl.Source;
                        fd.OriginalHash = Crypto.GetSHA512Hash(file.FullName);
                        fd.OriginalTime = file.LastWriteTimeUtc;
                        fd.OriginalSize = file.Length;

                        //fd.CompressedName = fd.CompressedNamePath;
                        if (System.IO.File.Exists(fd.CompressedName))
                        {
                            System.IO.FileInfo cFi = new System.IO.FileInfo(fd.CompressedName);
                            //fd.CompressedHash = Crypto.GetSHA512Hash(cFi.FullName);
                            fd.CompressedTime = cFi.LastWriteTimeUtc;
                            fd.CompressedSize = cFi.Length;
                        }

                        fl.CompressedFiles.Remove(fd.CompressedName);

                        if (FileDetail.ObjectExists(file.FullName) > 0)
                        {
                            Debug.Print("File exists, checking details...");
                            FileDetail fd2 = FileDetail.ReturnObject(file.FullName);

                            if (fd.OriginalHash == fd2.OriginalHash && fd.OriginalSize == fd2.OriginalSize && fd.OriginalTime == fd2.OriginalTime)
                            {
                                Debug.Print("Files are equal, check if compressed file is correct...");
                                //if (fd.CompressedHash == fd2.CompressedHash && fd.CompressedSize == fd2.CompressedSize && fd.CompressedTime == fd2.CompressedTime && !config.ForceCompressedCreation)
                                if (fd.CompressedSize == fd2.CompressedSize && fd.CompressedTime == fd2.CompressedTime && !config.ForceCompressedCreation)
                                {
                                    Debug.Print("Compressed file checks out, do nothing...");
                                }
                                else
                                {
                                    if (!config.ForceCompressedCreation)
                                    {
                                        Debug.Print("Compressed file does not match, recreate!");
                                        //if (fd.CompressedHash != fd2.CompressedHash) Debug.Print("Hash is different: {0} <> {1}", fd.CompressedHash, fd2.CompressedHash);
                                        if (fd.CompressedSize != fd2.CompressedSize) Debug.Print("Size is different: {0} <> {1}", fd.CompressedSize, fd2.CompressedSize);
                                        if (fd.CompressedTime != fd2.CompressedTime) Debug.Print("Time is different: {0} <> {1}", fd.CompressedTime, fd2.CompressedTime);

                                        logWriter.FileLog(file.DirectoryName, file.Name, "Compressed file does not match, recreate!", LogColor.Blue);
                                    }
                                    else
                                    {
                                        Debug.Print("Forcing creation of compressed file!");
                                        logWriter.FileLog(file.DirectoryName, file.Name, "Forcing creation of compressed file!", LogColor.Blue);
                                    }
                                    ProcHandler.Run7zip(fd, fl);
                                }
                            }
                            else
                            {
                                Debug.Print("Files differ, do something!");
                                if (fd.OriginalHash != fd2.OriginalHash) Debug.Print("Hash is different: {0} <> {1}", fd.OriginalHash, fd2.OriginalHash);
                                if (fd.OriginalSize != fd2.OriginalSize) Debug.Print("Size is different: {0} <> {1}", fd.OriginalSize, fd2.OriginalSize);
                                if (fd.OriginalTime != fd2.OriginalTime) Debug.Print("Time is different: {0} <> {1}", fd.OriginalTime, fd2.OriginalTime);

                                logWriter.FileLog(file.DirectoryName, file.Name, "Files differ, do something!", LogColor.Amber);
                                ProcHandler.Run7zip(fd, fl);
                            }

                        }
                        else
                        {
                            Debug.Print("File not seen before, encrypt and add to list.");
                            logWriter.FileLog(file.DirectoryName, file.Name, "File not seen before, encrypt and add.", LogColor.Green);

                            //FileDetail.list.Add(fd);
                            ProcHandler.Run7zip(fd, fl);
                        }

                        tempFileDetail.Add(fd);

                        x++;
                        SyncWorker.ReportProgress(Function.ReturnPercent(x, totalCount));

                        if (SyncWorker.CancellationPending)
                        {
                            Debug.Unindent();
                            break;
                        }

                        Debug.Unindent();
                        CtrlInvoke.SetText(txtRemainingTime, rt.Calculate(stopWatch.ElapsedMilliseconds, x));
                    }

                    if (!SyncWorker.CancellationPending)
                    {
                        foreach (string deleteFile in fl.CompressedFiles)
                        {
                            Debug.Print("Compressed file {0} not in use, delete.", deleteFile);
                            logWriter.FileLog(System.IO.Path.GetDirectoryName(deleteFile), System.IO.Path.GetFileName(deleteFile), "Compressed file not in use, delete.", LogColor.Red);

                            System.IO.File.Delete(deleteFile);
                        }

                        foreach (var directory in System.IO.Directory.GetDirectories(fl.Target, "*", SearchOption.AllDirectories))
                        {
                            if (System.IO.Directory.GetFiles(directory).Length == 0 && System.IO.Directory.GetDirectories(directory).Length == 0)
                            {
                                Debug.Print("Deleting empty folder {0}.", directory);
                                logWriter.FileLog(directory, string.Empty, "Deleting empty folder", LogColor.Red);
                                System.IO.Directory.Delete(directory, false);
                            }
                        }

                    }

                    else
                    {
                        Debug.Unindent();
                        break;
                    }

                    Debug.Unindent();
                }

                if (!SyncWorker.CancellationPending)
                {
                    List<FileDetail> deleteResult = FileDetail.list.Except(tempFileDetail).ToList();
                    foreach (FileDetail fd in deleteResult)
                    {
                        Debug.Print("FileDetail entry {0} points to no file that does not exist. Delete.", fd.OriginalName);
                        logWriter.FileLog(System.IO.Path.GetDirectoryName(fd.OriginalName), System.IO.Path.GetFileName(fd.OriginalName), "FileDetail entry not in use, delete.", LogColor.Red);
                    }
                }

            }
            catch (Exception exp)
            {
                MsgManager.LaunchExceptionReporter(exp);
            }
            finally
            {
                try
                {
                    if (System.IO.File.Exists(FileDetail.FileName))
                    {
                        System.IO.File.Copy(FileDetail.FileName, currentFolder + "\\FileDetails.bak", true);
                    }

                    if (!SyncWorker.CancellationPending)
                    {
                        XML.SerializeList<FileDetail>(FileDetail.FileName, tempFileDetail);
                        FileDetail.list = tempFileDetail;
                    }
                }
                catch (Exception exp2)
                {
                    MsgManager.LaunchExceptionReporter(exp2);
                }
                finally
                {
                    stopWatch.Stop();
                    CtrlInvoke.SetText(txtSyncStopWatch, stopWatch.Elapsed.ToString());
                    CtrlInvoke.SetText(txtSyncNumberOfFiles, totalCount.ToString());

                    foreach (FolderList fl in FolderList.list)
                    {
                        fl.SourceFiles.Clear();
                        fl.CompressedFiles.Clear();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string source = null;
            string target = null;

            folderBrowserDialog1.Description = "Select source folder...";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                source = folderBrowserDialog1.SelectedPath;

                folderBrowserDialog1.Description = "Select target folder...";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) target = folderBrowserDialog1.SelectedPath;
            }

            if (source != null && target != null)
            {
                foreach (FolderList fl in FolderList.list)
                {
                    if (Regex.IsMatch(fl.Source + @"\\", Regex.Escape(source + @"\\")))
                    {
                        MsgManager.Show(string.Format("Source folder is already added would conflict with another folder. {0} > {1}", source, fl.Source), "Add folder", MessageBoxIcon.Error);
                        source = null;
                        break;
                    }

                    if (Regex.IsMatch(fl.Target + @"\\", Regex.Escape(target + @"\\")))
                    {
                        MsgManager.Show(string.Format("Target folder is already added would conflict with another folder. {0} > {1}", target, fl.Target), "Add folder", MessageBoxIcon.Error);
                        target = null;
                        break;
                    }
                }
            }

            if (source != null && target != null)
            {
                FolderList fl = new FolderList();
                fl.Source = source;
                fl.Target = target;
                FolderList.list.Add(fl);

                PopulateFolderList();
            }
        }

        private void PopulateFolderList()
        {
            lstFolders.Items.Clear();

            foreach (FolderList fl in FolderList.list)
            {
                ListViewItem item = new ListViewItem(new[] { fl.Source, fl.Target });
                lstFolders.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.Print("Application started");

            if (minimixeWindow) this.WindowState = FormWindowState.Minimized;

            FileDetail.FileName = currentFolder + "\\FileDetails.xml";
            if (System.IO.File.Exists(FileDetail.FileName))
            {
                XML.DeSerializeList<FileDetail>(FileDetail.FileName, FileDetail.list);
                tslStatus.Text = string.Format("FileDetails loaded {0} files.", FileDetail.list.Count);
            }
            else
                tslStatus.Text = "FileDetails not found!";

            FolderList.FileName = currentFolder + "\\FolderList.xml";
            if (System.IO.File.Exists(FolderList.FileName))
            {
                XML.DeSerializeList<FolderList>(FolderList.FileName, FolderList.list);
                PopulateFolderList();
            }

            Config.FileName = currentFolder + "\\Config.xml";
            if (System.IO.File.Exists(Config.FileName))
            {
                XML.DeSerializeConfig(Config.FileName);
                config.Load();
            }

            if (!File.Exists(config.Executable7zip)) MsgManager.Show("No 7-Zip folder defined, select it in the settings tab!", "7-Zip folder", MessageBoxIcon.Warning);

            FolderWatch.Init();

            if (startSyncNow && !SyncWorker.IsBusy) SyncWorker.RunWorkerAsync("Command-line argument");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuSynchronize_Click(object sender, EventArgs e)
        {
            if (!SyncWorker.IsBusy)
            {
                SyncWorker.RunWorkerAsync("Manual sync from system tray.");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SyncWorker.IsBusy)
            {
                SyncWorker.CancelAsync();
            }
        }

        private void btnRemoveFolder_Click(object sender, EventArgs e)
        {
            if (lstFolders.SelectedItems.Count > 0)
            {
                FolderList fl = FolderList.list.First(f => f.Source == lstFolders.SelectedItems[0].Text);
                FolderList.list.Remove(fl);

                PopulateFolderList();
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.ShowInTaskbar = false;
            else this.ShowInTaskbar = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!SyncWorker.IsBusy)
            {
                Debug.Print("Sync timer elapsed, running auto-sync!");
                SyncWorker.RunWorkerAsync("Scan interval elapsed!");

                //notifyIcon1.ShowBalloonTip(5000, "Scan interval elapsed!", "Synchronizing...", ToolTipIcon.Info);
            }
        }

        private void btnConfigSave_Click(object sender, EventArgs e)
        {
            XML.SerializeList<FolderList>(FolderList.FileName, FolderList.list);
            config.Save();
            tslStatus.Text = "Settings saved!";
        }

        private void lstLog_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListView sourceList = sender as ListView;
                ContextMenu cm = new ContextMenu();

                ListViewItem item = sourceList.GetItemAt(e.X, e.Y);

                MenuItem clearLog = cm.MenuItems.Add("Clear list");
                clearLog.Click += (Sender, eventArgs) => { sourceList.Items.Clear(); };

                cm.Show(sourceList, e.Location);
            }
        }

        private void lstFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFolders.SelectedItems.Count > 0)
            {
                FolderList fl = FolderList.list.First(f => f.Source == lstFolders.SelectedItems[0].Text);

                txtFolderSource.Text = fl.Source;
                txtFolderTarget.Text = fl.Target;
                btnUpdateFolder.Enabled = true;
                btnRemoveFolder.Enabled = true;
            }
            else
            {
                txtFolderSource.Text = string.Empty;
                txtFolderTarget.Text = string.Empty;
                btnUpdateFolder.Enabled = false;
                btnRemoveFolder.Enabled = false;
            }
        }

        private void btnUpdateFolder_Click(object sender, EventArgs e)
        {
            if (lstFolders.SelectedItems.Count > 0)
            {
                if (System.IO.Directory.Exists(txtFolderSource.Text) && System.IO.Directory.Exists(txtFolderTarget.Text))
                {
                    FolderList fl = FolderList.list.First(f => f.Source == lstFolders.SelectedItems[0].Text);

                    fl.Source = txtFolderSource.Text;
                    fl.Target = txtFolderTarget.Text;

                    PopulateFolderList();
                }
                else
                    MsgManager.Show("Source and target folder must exist.", "Update folder", MessageBoxIcon.Error);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (changeTimer == 0 && !SyncWorker.IsBusy)
            {
                Debug.Print("Change timer elapsed, running sync!");
                SyncWorker.RunWorkerAsync("Change timer elapsed!");

                //notifyIcon1.ShowBalloonTip(5000, "Change detected!", "Synchronizing...", ToolTipIcon.Info);
            }

            if (changeTimer >= 0)
            {
                toolStripProgressBar1.Visible = true;
                Program.MainForm.tslUnprocessedChanges.Visible = true;

                toolStripProgressBar1.Maximum = Convert.ToInt32(TimeSpan.FromMinutes(config.ChangeDelay).TotalSeconds);
                toolStripProgressBar1.Value = changeTimer;

                changeTimer--;
            }
            else
            {
                toolStripProgressBar1.Visible = false;
                Program.MainForm.tslUnprocessedChanges.Visible = false;
            }
        }

        private void mnuRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            string password = FormFunc.ShowDialog("Enter password", "Extract files", true);

            if (password == config.PasswordText)
            {
                string source = null;
                string target = null;

                folderBrowserDialog1.Description = "Select source folder...";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    source = folderBrowserDialog1.SelectedPath;

                    folderBrowserDialog1.Description = "Select target folder...";
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) target = folderBrowserDialog1.SelectedPath;
                }

                if (source != null && target != null)
                {
                    //ProcHandler.ExtractFiles(source, target);
                    ExtractWorker.RunWorkerAsync(source + ";" + target);
                }
            }
            else
                MsgManager.Show("Wrong password!", "Extract files", MessageBoxIcon.Error);
        }

        private void btnStopExtract_Click(object sender, EventArgs e)
        {
            if (ExtractWorker.IsBusy)
            {
                ExtractWorker.CancelAsync();
            }
        }

        private void btn7zip_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select 7-Zip folder...";
            folderBrowserDialog1.SelectedPath = config.Path7zip;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string exe7zip = folderBrowserDialog1.SelectedPath + @"\7z.exe";

                if (File.Exists(exe7zip))
                {
                    config.Path7zip = folderBrowserDialog1.SelectedPath;
                    CtrlInvoke.SetStatus(statusStrip1, tslStatus, "Found: " + exe7zip);
                }
                else
                    MsgManager.Show("7z.exe not found in folder.", "7-Zip folder", MessageBoxIcon.Error);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Debug.Print("Application exited");
                }
                else
                {
                    e.Cancel = true;
                    this.Activate();
                }
            }
        }

        private void lstRunLog_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListView sourceList = sender as ListView;
                ContextMenu cm = new ContextMenu();

                ListViewItem item = sourceList.GetItemAt(e.X, e.Y);

                MenuItem clearLog = cm.MenuItems.Add("Clear list");
                clearLog.Click += (Sender, eventArgs) => { lstRunLog.Items.Clear(); };

                cm.Show(sourceList, e.Location);
            }
        }

    }

}
