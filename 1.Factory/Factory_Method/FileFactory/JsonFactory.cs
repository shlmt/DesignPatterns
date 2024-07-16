using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class JsonFactory:FileFactory
    {
        public static JsonFactory Jsn_Instance { get; private set; }
        static JsonFactory() => Jsn_Instance = new JsonFactory();

        public override FileWriter Factory() => new JsonWriter();

    }
}
