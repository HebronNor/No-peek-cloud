using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExceptionReporting;

namespace NoPeekCloud
{
    class MsgManager
    {
        public static void Show(string text, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, icon);
        }

        public static void LaunchExceptionReporter(Exception e)
        {
            ExceptionReporter reporter = new ExceptionReporter();

            reporter.Config.AppAssembly = System.Reflection.Assembly.GetCallingAssembly();
            reporter.Config.AppName = AppInfo.AssemblyInfo.Name;
            reporter.Config.AppVersion = AppInfo.AssemblyInfo.VersionString;
            reporter.Config.TitleText = "NoPeekCloud Exception Report";
            reporter.Config.EmailReportAddress = "hebron@tilhol.net";
            //reporter.Config.FilesToAttach = new[] { LogHandler.LogFileName(LogFile.Exception), LogHandler.LogFileName(LogFile.Debug) };
            reporter.Config.ShowConfigTab = false;

            reporter.Show(e);
        }

    }
}
