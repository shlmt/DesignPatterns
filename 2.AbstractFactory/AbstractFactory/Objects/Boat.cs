using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Objects
{
    internal class Boat:ITraffic
    {
        public int Fast { get; set; } = 20;
        public Boat()=>MessageBox.Show("create a boat⛵");
        public void Drive()
        {
            Fast = new Random().Next(0, 50);
            MessageBox.Show("trrrrr boat⛵ drive " + Fast);
        }
    }
}
