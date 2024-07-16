using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Objects
{
    internal interface Inavigation
    {
        public bool IsLegal { get; set; }
        public void Light();
    }
}
