using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace NoPeekCloud
{
    public enum LogColor
    {
        None, Green, Amber, Red, Blue
    }

    public class LogWriter
    {
        private ListView _listView;
        private string _logFile;

        public LogWriter(ListView ListView, string LogFile)
        {
            this._listView = ListView;
            this._logFile = LogFile;
        }

        public void FileLog(string folder, string file, string text, LogColor logColor = LogColor.None)
        {
            ListViewItem item = new ListViewItem(new[] { DateTime.Now.ToString("dd.MM.yy"), DateTime.Now.ToString("HH:mm:ss"), folder, file, text });

            switch (logColor)
            {
                case LogColor.Green:
                    item.ForeColor = Color.Green;
                    break;

                case LogColor.Amber:
                    item.ForeColor = Color.Orange;
                    break;

                case LogColor.Red:
                    item.ForeColor = Color.Red;
                    break;

                case LogColor.Blue:
                    item.ForeColor = Color.Blue;
                    break;
            }

            CtrlInvoke.SetLog(_listView, item);
            LogToFile(string.Format(@"[{0}\{1}] {2}", folder, file, text));
        }

        private void LogToFile(string text)
        {
            using (StreamWriter w = File.AppendText(_logFile))
            {
                w.WriteLine("{0} {1} {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString(), text);
            }
        }

    }
}
