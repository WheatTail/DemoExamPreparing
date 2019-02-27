using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace DemoExamPreparing
{
    public class SettingsFields
    {
        public string XMLFile = Environment.CurrentDirectory + "\\settings.xml";
        public string Server = @"192.168.1.3";
        public string Port = @"3306";
        public string Database = @"maindatabase";
        public string UID = @"WT";
        public string Password = @"TestPassword";
    }

    public class SettingsMangaer
    {
        public SettingsFields Fields;

        public SettingsMangaer()
        {
            Fields = new SettingsFields();
        }

        public void WriteSettingsToXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SettingsFields));
            TextWriter writer = new StreamWriter(Fields.XMLFile);
            serializer.Serialize(writer, Fields);
            writer.Close();
        }

        public void ReadSettingsFromXML()
        {
            if (File.Exists(Fields.XMLFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SettingsFields));
                TextReader reader = new StreamReader(Fields.XMLFile);
                Fields = serializer.Deserialize(reader) as SettingsFields;
                reader.Close();
            }
            else
            {
                MessageBox.Show("Кто-то потырил файл с настройками, настучите ему по лапам", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
