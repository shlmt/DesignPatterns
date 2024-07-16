using AbstractFactory.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class LandFactory : MyFactory
    {

        public ITraffic createTraffic()
        {
            return new Car();
        }
        public Inavigation createNavigation()
        {
            return new TrafficLight();
        }
    }
}
