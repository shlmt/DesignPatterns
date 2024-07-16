using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite.Classes
{
    internal class CFile : Component
    {
        public CFile(string name, string path) : base(name, path){
            if (File.Exists(path))
                return;
            File.Create(path);
        }

        public override string getContent()
        {
            return Name;
        }

        public override bool isDirectory() => false;
        public override void Add(Component c) => throw new NotImplementedException();
        public override void Remove(Component c) => throw new NotImplementedException();
        
    }
}
