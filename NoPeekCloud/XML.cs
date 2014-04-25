using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NoPeekCloud
{
    class XML
    {
        public static void SerializeList<T>(string fileName, List<T> list)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(List<T>), new XmlRootAttribute("NoPeekCloud"));
            System.IO.StringWriter sww = new System.IO.StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, list);
            sww.Flush();
            var xml = sww.ToString();

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);
            xdoc.Save(fileName);
        }

        public static void DeSerializeList<T>(string fileName, List<T> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute("NoPeekCloud"));
            using (var stream = System.IO.File.OpenRead(fileName))
            {
                var other = (List<T>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
        }

        public static void SerializeConfig(string fileName)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(Config), new XmlRootAttribute("NoPeekCloud"));
            System.IO.StringWriter sww = new System.IO.StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            xsSubmit.Serialize(writer, Program.MainForm.config);
            sww.Flush();
            var xml = sww.ToString();

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);
            xdoc.Save(fileName);
        }

        public static void DeSerializeConfig(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Config), new XmlRootAttribute("NoPeekCloud"));
            using (var stream = System.IO.File.OpenRead(fileName))
            {
                var other = (Config)(serializer.Deserialize(stream));
                Program.MainForm.config = other;
            }
        }
    }
}
