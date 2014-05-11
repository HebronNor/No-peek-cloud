using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace NoPeekCloud
{
    class ProcHandler
    {
        public static void Run7zip(FileDetail fd, FolderList fl)
        {
            if (System.IO.File.Exists(fd.CompressedName))
            {
                Debug.Print("Deleting existing compressed file: {0}", fd.CompressedName);
                FileHandler.DeleteFile(fd.CompressedName);
            }

            string password = Program.MainForm.config.PasswordText;
            if (!string.IsNullOrEmpty(password)) password = "-p" + password + " -mhe";

            CompressionLevel compLevel = (CompressionLevel)Program.MainForm.config.CompressionLevel;

            RunProcess(Program.MainForm.config.Executable7zip, string.Format(@"a -t7z -y ""{0}"" ""{1}"" {2} -{3}", fd.CompressedName, fd.OriginalName, password, compLevel));

            if (File.Exists(fd.CompressedName))
            {
                FileInfo cFi = new System.IO.FileInfo(fd.CompressedName);
                //fd.CompressedHash = Crypto.GetSHA512Hash(cFi.FullName);
                fd.CompressedTime = cFi.LastWriteTimeUtc;
                fd.CompressedSize = cFi.Length;
            }
        }

        public static void ExtractFiles(string file, string target)
        {
            string password = Program.MainForm.config.PasswordText;
            if (!string.IsNullOrEmpty(password)) password = "-p" + password;

            RunProcess(Program.MainForm.config.Executable7zip, string.Format(@"x -aou ""{0}"" -o""{1}"" {2}", file, target, password));
        }

        private static string RunProcess(string file, string argument)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            try
            {
                Debug.Print("Process: {0} {1}", file, argument.Replace("-p" + Program.MainForm.config.PasswordText, "-pXXXXXX"));
                string ProcessOutput;

                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;

                startInfo.FileName = file;
                startInfo.Arguments = argument;

                using (Process exeProcess = Process.Start(startInfo))
                {
                    System.IO.StreamReader myStreamReader = exeProcess.StandardOutput;
                    ProcessOutput = myStreamReader.ReadToEnd();

                    exeProcess.WaitForExit();
                }

                //Debug.Indent();
                //Debug.Print(ProcessOutput);
                //Debug.Unindent();

                return ProcessOutput;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Process error: " + exp.Message);
                return null;
            }
        }
    }
}
