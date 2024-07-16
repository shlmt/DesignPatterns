using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite.Classes
{
    internal class CDirectory : Component
    {
        public List<Component> Contents { get; set; } = new List<Component>();
        public CDirectory(string name, string path) : base(name, path){
            if (path == "" || Directory.Exists(path))
                return;
            Directory.CreateDirectory(Path);
        }
        public override bool isDirectory() => true;
        public override void Add(Component c)
        {
            Contents.Add(c);
        }
        public override void Remove(Component c)
        {
            File.Delete(c.Path);
            Contents.Remove(c);
        }
        public override string getContent()
        {
            string s = Name+"( ";
            foreach(var c in Contents)
                s += c.getContent()+",";
            s=s.Remove(s.Length-1);
            return  s+= ")";
        }
    }
}
