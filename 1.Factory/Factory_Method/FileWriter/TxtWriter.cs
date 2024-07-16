using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal;

namespace Factory_Method
{
    internal class TxtWriter : FileWriter
    {
        public void write(string path, Person o)
        {
            File.WriteAllText(path, o.ToString());
        }
    }
}
