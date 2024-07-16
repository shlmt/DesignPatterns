using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public string ToString()
        {
            return Name + " " + Phone;
        }
    }
}
