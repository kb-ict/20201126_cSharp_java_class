using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWrite();
            XmlRead();
        }

        static void XmlWrite()
        {
            XmlDocument xml = new XmlDocument();

            XmlNode root = xml.CreateElement("네이버");

            XmlNode company = xml.CreateElement("회사");
            company.InnerText = "NHN";
            root.AppendChild(company);

            XmlNode bloger = xml.CreateElement("블로거");

            XmlAttribute name = xml.CreateAttribute("이름");
            name.Value = "스티브";
            XmlAttribute id = xml.CreateAttribute("아이디");
            id.Value = "adudu123";

            bloger.Attributes.Append(name);
            bloger.Attributes.Append(id);

            XmlNode s = xml.CreateElement("특징");
            s.InnerText = "귀차니즘";
            bloger.AppendChild(s);

            root.AppendChild(bloger);
            xml.AppendChild(root);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                + @"\naver.xml";

            xml.Save(path);
        }

        static void XmlRead()
        {
            XmlDocument xml = new XmlDocument();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                + @"\naver.xml";

            xml.Load(path);

            XmlNode root = xml.SelectNodes("네이버")[0];

            Console.WriteLine($"회사 : {root.SelectNodes("회사")[0].InnerText}");

            foreach (XmlNode it in root.SelectNodes("블로거"))
            {
                string name = it.Attributes["이름"].Value;
                string id = it.Attributes["아이디"].Value;
                string s = it.SelectNodes("특징")[0].InnerText;

                Console.WriteLine($"< 블로거 정보 >\n이름 : {name}\n아이디 : {id}\n특징 : {s}");
            }
        }
    }
}
