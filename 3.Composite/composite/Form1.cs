using composite.Classes;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace composite
{
    public partial class Form1 : Form
    {
        CDirectory root = new CDirectory("computer", "");

        public Form1()
        {
            InitializeComponent();
            var drvs = DriveInfo.GetDrives();
            foreach (var item in drvs)
            {
                if (item.IsReady)
                {
                    CDirectory d = new CDirectory(item.Name, item.RootDirectory.FullName);
                    root.Add(d);
                    treeView1.Nodes.Add(d.Name).Tag = d.Path;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //create folder
        {
            string selectedDir = treeView1.SelectedNode.Text;
            CDirectory path = (CDirectory)FindComponentByPath(root, selectedDir);
            if (!path.isDirectory())
                return;
            CDirectory d = new CDirectory(textBox1.Text, path.Path + "\\" + textBox1.Text);
            path.Add(d);
            treeView1.SelectedNode.Nodes.Add(textBox1.Text).Tag = d.Path;
            treeView1.SelectedNode.Expand();
        }

        private void button2_Click(object sender, EventArgs e) //create file
        {
            string selectedDir = (string)treeView1.SelectedNode.Tag;
            Classes.Component path = FindComponentByPath(root, selectedDir);
            if (!path.isDirectory())
                return;
            CFile f = new CFile(textBox1.Text, path.Path + "\\" + textBox1.Text);
            path.Add(f);
            treeView1.SelectedNode.Nodes.Add(textBox1.Text).Tag = f.Path;
            treeView1.SelectedNode.Expand();
        }

        private void button3_Click(object sender, EventArgs e) //view contents
        {
            string selectedDir = (string)treeView1.SelectedNode.Tag;
            Classes.Component path = FindComponentByPath(root, selectedDir);
            MessageBox.Show(path.getContent());
        }

        private static Classes.Component FindComponentByPath(CDirectory root, string path)
        {
            foreach(var comp in root.Contents)
            {
                if (comp.Path == path)
                    return comp;

                else if (comp.isDirectory())
                {
                    var foundComponent = FindComponentByPath((CDirectory)comp, path);
                    if (foundComponent != null)
                        return foundComponent;
                }
            }
            return null;
        }
        

    }

}
