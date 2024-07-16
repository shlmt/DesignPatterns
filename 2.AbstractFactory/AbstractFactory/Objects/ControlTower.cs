using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Objects
{
    internal class ControlTower : Inavigation
    {
        public bool IsLegal { get; set; } = true;
        public ControlTower()
        {
            MessageBox.Show("create a ControlTower🗽");
        }

        public void Light()
        {
            MessageBox.Show("🗽Light....");
        }
    }
}
