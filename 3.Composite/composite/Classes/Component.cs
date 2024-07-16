using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite.Classes
{
    internal abstract class Component
    {
        public Component(string name, string path)
        {
            Name = name;
            Path = path;
        }
        public string Path { get; set; }
        public string Name { get; set; }
        abstract public bool isDirectory();
        abstract public string getContent();
        abstract public void Add(Component c);
        abstract public void Remove(Component c);
    }
}
