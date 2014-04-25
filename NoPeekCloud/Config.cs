using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace NoPeekCloud
{
    enum CompressionLevel
    {
        mx0, mx1, mx3, mx5, mx7, mx9
    }

    [Serializable]
    public class Config
    {
        [XmlIgnore]
        public static string FileName { set; get; }

        public string Path7zip { set; get; }
        public int ScanInterval { set; get; }
        public int ChangeDelay { set; get; }
        public string Password { set; get; }
        public int CompressionLevel { set; get; }
        public bool ForceCompressedCreation { set; get; }

        [XmlIgnore]
        public string Executable7zip
        {
            get { return Path7zip + @"\7z.exe"; }
        }

        [XmlIgnore]
        public string PasswordText
        {
            set
            {
                Password = Crypto.EncryptString(value, Crypto.LOCK_KEY);
            }
            get
            {
                if (!string.IsNullOrEmpty(Password)) return Crypto.DecryptString(Password, Crypto.LOCK_KEY);
                else return null;
            }
        }

        public void Load()
        {
            Program.MainForm.numScanInterval.Value = this.ScanInterval;
            if (this.ScanInterval > 0)
            {
                Program.MainForm.timer1.Enabled = true;
                Program.MainForm.timer1.Interval = Convert.ToInt32(TimeSpan.FromHours(this.ScanInterval).TotalMilliseconds);
            }
            else
                Program.MainForm.timer1.Enabled = false;

            Program.MainForm.numChangeDelay.Value = this.ChangeDelay;

            if (this.Password != null)
            {
                Program.MainForm.txtPassword1.Text = this.PasswordText;
                Program.MainForm.txtPassword2.Text = this.PasswordText;
            }

            Program.MainForm.cmbCompressionMode.SelectedIndex = this.CompressionLevel;

            Program.MainForm.chkForceCreation.Checked = this.ForceCompressedCreation;
            Program.MainForm.tslForceWarning.Visible = this.ForceCompressedCreation;
        }

        public void Save()
        {
            this.ScanInterval = Convert.ToInt32(Program.MainForm.numScanInterval.Value);
            this.ChangeDelay = Convert.ToInt32(Program.MainForm.numChangeDelay.Value);

            if (Program.MainForm.txtPassword1.Text == Program.MainForm.txtPassword2.Text)
                this.PasswordText = Program.MainForm.txtPassword1.Text;
            else
                MessageBox.Show("Passwords do not match.");

            this.CompressionLevel = Program.MainForm.cmbCompressionMode.SelectedIndex;
            this.ForceCompressedCreation = Program.MainForm.chkForceCreation.Checked;

            XML.SerializeConfig(FileName);
            this.Load();
        }
    }
}
