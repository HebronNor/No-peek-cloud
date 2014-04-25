using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NoPeekCloud
{
    [Serializable]
    public class FileDetail
    {
        [XmlIgnore]
        public static string FileName { set; get; }

        public string OriginalName { set; get; }
        public string OriginalPath { set; get; }
        public string OriginalHash { set; get; }
        public DateTime OriginalTime { set; get; }
        public double OriginalSize { set; get; }

        //public string CompressedName { set; get; }
        public string CompressedHash { set; get; }
        public DateTime CompressedTime { set; get; }
        public double CompressedSize { set; get; }

        [XmlArray]
        public static List<FileDetail> list = new List<FileDetail>();

        public static int ObjectExists(string fileName)
        {
            return list.Count(f => f.OriginalName == fileName);
        }

        public static FileDetail ReturnObject(string fileName)
        {
            return list.First(f => f.OriginalName == fileName);
        }

        [XmlIgnore]
        public string RelativePath
        {
            get
            {
                return this.OriginalName.Replace(this.OriginalPath, string.Empty);
            }
        }

        [XmlIgnore]
        public string TargetPath
        {
            get
            {
                return FolderList.list.First(f => f.Source == this.OriginalPath).Target;
            }
        }

        [XmlIgnore]
        public string CompressedName
        {
            get { return string.Format(@"{0}{1}.{2}", this.TargetPath, this.RelativePath, frmMain.FILE_TYPE); }
        }

        public override bool Equals(object other)
        {
            if (other is FileDetail)
            {
                return ((FileDetail)other).OriginalName == OriginalName;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return OriginalName.GetHashCode();
        }
    }
}
