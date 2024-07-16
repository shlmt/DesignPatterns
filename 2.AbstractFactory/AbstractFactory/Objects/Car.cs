using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Objects
{
    internal class Car : ITraffic
    {
        public int Fast { get; set; }
        public Car() => MessageBox.Show("create a car🚗");
        public void Drive()
        {
            Fast = new Random().Next(10,100);
            MessageBox.Show("annnnnn Car🚗 drive "+Fast);
        }
    }
}
