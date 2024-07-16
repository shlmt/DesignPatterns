using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using Personal;

namespace Factory_Method
{
    internal class JsonWriter : FileWriter
    {
        public void write(string path, Person o)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Person));
            js.WriteObject(fs, o);
            fs.Close();
        }
    }
}
