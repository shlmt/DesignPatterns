using AbstractFactory.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal class SeaFactory : MyFactory
    {

        public ITraffic createTraffic()
        {
            return new Boat();
        }
        public Inavigation createNavigation()
        {
            return new ControlTower();
        }
    }
}
