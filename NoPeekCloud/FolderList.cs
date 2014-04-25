using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NoPeekCloud
{
    [Serializable]
    public class FolderList
    {
        [XmlIgnore]
        public static string FileName { set; get; }

        public string Source { set; get; }
        public string Target { set; get; }

        [XmlArray]
        public static List<FolderList> list = new List<FolderList>();

        [XmlIgnore]
        public List<System.IO.FileInfo> SourceFiles = new List<System.IO.FileInfo>();

        [XmlIgnore]
        public List<string> CompressedFiles = new List<string>();
    }
}
