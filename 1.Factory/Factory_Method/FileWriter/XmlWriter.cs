using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Personal;
namespace Factory_Method
{
    internal class XmlWriter : FileWriter
    {
        public void write(string path, Person o)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            xs.Serialize(fs, o);
            fs.Close();
        }
    }
}
