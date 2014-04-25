using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace NoPeekCloud
{
    class FolderWatch
    {
        public static void Init()
        {
            FileSystemWatcher[] watcher = new FileSystemWatcher[FolderList.list.Count];

            int x = 0;
            foreach (FolderList fl in FolderList.list)
            {
                watcher[x] = new FileSystemWatcher();
                watcher[x].Path = fl.Source;

                watcher[x].NotifyFilter = NotifyFilters.LastAccess |
                             NotifyFilters.LastWrite |
                             NotifyFilters.FileName |
                             NotifyFilters.DirectoryName;

                watcher[x].IncludeSubdirectories = true;

                watcher[x].Changed += new FileSystemEventHandler(OnChanged);
                watcher[x].Created += new FileSystemEventHandler(OnChanged);
                watcher[x].Deleted += new FileSystemEventHandler(OnChanged);
                watcher[x].Renamed += new RenamedEventHandler(OnRenamed);

                watcher[x].EnableRaisingEvents = true;

                x++;
            }
        }

        static void OnChanged(object sender, FileSystemEventArgs e)
        {
            Debug.Print("Change detected: {0} on {1}", e.ChangeType, e.FullPath);

            if (Program.MainForm.config.ChangeDelay > 0)
            {
                Program.MainForm.changeTimer = Convert.ToInt32(TimeSpan.FromMinutes(Program.MainForm.config.ChangeDelay).TotalSeconds);
            }
        }

        static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Debug.Print("Rename detected: {0} to {1}", e.OldFullPath, e.FullPath);

            if (Program.MainForm.config.ChangeDelay > 0)
            {
                //Program.MainForm.filesRenamed.Add(e.OldFullPath, e.FullPath);
                Program.MainForm.changeTimer = Convert.ToInt32(TimeSpan.FromMinutes(Program.MainForm.config.ChangeDelay).TotalSeconds);
            }
        }
    }
}
