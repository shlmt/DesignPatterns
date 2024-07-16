using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal;

namespace Factory_Method
{
    public interface FileWriter
    {
        void write(string path, Person o);
    }
}
