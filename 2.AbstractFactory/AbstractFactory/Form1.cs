using AbstractFactory.Factory;
using AbstractFactory.Objects;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyFactory Factory;
        ITraffic Traffic;
        Inavigation Nav;

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Factory = new SeaFactory();
            else Factory = new LandFactory();
            Traffic = Factory.createTraffic();
            Nav = Factory.createNavigation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Traffic?.Drive();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nav?.Light();
        }
    }
}