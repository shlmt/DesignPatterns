using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Objects
{
    internal class TrafficLight : Inavigation
    {
        public bool IsLegal { get; set; } = true;
        public TrafficLight()
        {
              MessageBox.Show("create a TrafficLight🚦");
        }
        public void Light()
        {
            int num = new Random().Next(1, 4);
            string color="the traffic isn't working";
            switch (num) {
                case 1:
                    color= "red - stop,";
                    break;
                case 2:
                    color= "yellow - ready...";
                    break;
                case 3:
                    color= "green - drive!";
                    break;
            }
            MessageBox.Show(color);
        }
    }
}
