using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class XmlFactory:FileFactory
    {
        public static XmlFactory Xml_Instance { get; private set; }
        static XmlFactory() => Xml_Instance = new XmlFactory();

        public override FileWriter Factory() => new XmlWriter();

    }
}
