using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace NoPeekCloud
{
    class AppInfo
    {
        public class AssemblyInfo
        {
            private static string nameValue = Assembly.GetExecutingAssembly().GetName().Name.ToString();
            private static Version versionValue = Assembly.Load(nameValue).GetName().Version;
            private static int assemblyCount = Process.GetProcessesByName(nameValue).Count();

            public static string Name
            {
                get { return nameValue; }
            }

            public static string Executable
            {
                get { return nameValue + ".exe"; }
            }

            public static string VersionString
            {
                get { return string.Format(@"{0}.{1}.{2} (r{3})", versionValue.Major, versionValue.Minor, versionValue.Build, versionValue.Revision); }
            }

            public static string Version
            {
                get { return versionValue.ToString(); }
            }

            public static bool AlreadyRunning
            {
                get { return (assemblyCount > 1); }
            }
        }
    }
}
