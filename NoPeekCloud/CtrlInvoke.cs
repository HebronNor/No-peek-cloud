using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoPeekCloud
{
    class CtrlInvoke
    {
        private delegate void SetTextCallback(TextBox textBox, string text);
        public static void SetText(TextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Program.MainForm.Invoke(d, new object[] { textBox, text });
            }
            else
            {
                textBox.Text = text;
            }
        }

        private delegate void SetProgressCallback(ProgressBar bar, int value);
        public static void SetProgress(ProgressBar bar, int value)
        {
            if (bar.InvokeRequired)
            {
                SetProgressCallback d = new SetProgressCallback(SetProgress);
                Program.MainForm.Invoke(d, new object[] { bar, value });
            }
            else
            {
                bar.Value = value;
            }
        }

        private delegate void SetLogCallback(ListView listView, ListViewItem item);
        public static void SetLog(ListView listView, ListViewItem item)
        {
            if (listView.InvokeRequired)
            {
                SetLogCallback d = new SetLogCallback(SetLog);
                Program.MainForm.Invoke(d, new object[] { listView, item });
            }
            else
            {
                listView.Items.Add(item);
                item.EnsureVisible();
            }
        }

        private delegate void SetStatusCallback(ToolStrip statusBar, ToolStripStatusLabel label, string text);
        public static void SetStatus(ToolStrip statusBar, ToolStripStatusLabel label, string text)
        {
            if (statusBar.InvokeRequired)
            {
                SetStatusCallback d = new SetStatusCallback(SetStatus);
                Program.MainForm.Invoke(d, new object[] { statusBar, label, text });
            }
            else
            {
                label.Text = text;
            }
        }

        private delegate void ButtonEnableCallback(Button button, bool enable);
        public static void ButtonEnable(Button button, bool enable)
        {
            if (button.InvokeRequired)
            {
                ButtonEnableCallback d = new ButtonEnableCallback(ButtonEnable);
                Program.MainForm.Invoke(d, new object[] { button, enable });
            }
            else
            {
                button.Enabled = enable;
            }
        }
    }
}
