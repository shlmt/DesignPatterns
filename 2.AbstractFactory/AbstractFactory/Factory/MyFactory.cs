using AbstractFactory.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal interface MyFactory
    {
        public ITraffic createTraffic();
        public Inavigation createNavigation();
    }
}
