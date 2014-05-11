using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace NoPeekCloud
{
    class Function
    {
        public static int ReturnPercent(int value, int max)
        {
            double v = value;
            double m = max;
            double result = (v / m) * 100;
            result = Math.Round(result, 0);

            if (result > 100 || result < 0) throw new OverflowException("Percent can not be over 100 or below 0");
            return Convert.ToInt32(result);
        }

    }

    class RemainingTime
    {
        List<int> stopWatchAvg = new List<int>();

        private int _total;
        private int _average;

        public RemainingTime(int Total, int Average)
        {
            this._total = Total;
            this._average = Average;
        }

        public string Calculate(long elapsed, int item)
        {
            long remainingTime = (elapsed / item) * (_total - item);
            stopWatchAvg.Add(Convert.ToInt32(remainingTime / 1000));
            if (stopWatchAvg.Count > _average) stopWatchAvg.RemoveAt(0);

            TimeSpan timeSpan = new TimeSpan(0, 0, Convert.ToInt32(stopWatchAvg.Average()));
            return string.Format("{0:0}:{1:00}:{2:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        }
    }

    class FileHandler
    {
        public static void DeleteFile(string file)
        {
            try
            {
                if (!File.Exists(file)) throw new FileNotFoundException(string.Format("Can not delete '{0}', file does not exist.", file));

                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }
            catch (Exception exp)
            {
                MsgManager.Show(exp.Message, "File delete error", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static void DeleteFolder(string folder)
        {
            try
            {
                if (!Directory.Exists(folder)) throw new FileNotFoundException(string.Format("Can not delete '{0}', folder does not exist.", folder));

                Directory.Delete(folder, false);
            }
            catch (Exception exp)
            {
                MsgManager.Show(exp.Message, "Folder delete error", System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
