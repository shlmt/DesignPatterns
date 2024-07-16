using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class TxtFactory:FileFactory
    {
        public static TxtFactory Txt_Instance { get;private set; }
        static TxtFactory() => Txt_Instance = new TxtFactory();

        public override FileWriter Factory() => new TxtWriter();
    }
}
