using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Objects
{
    internal interface ITraffic
    {
        public int Fast { get; set; }
        public void Drive();
    }
}
