using Personal;
namespace Factory_Method
{
    public class FileFactory
    {
        protected FileFactory() { }
        public static FileFactory Instance { get; private set; }
        static FileFactory() => Instance = TxtFactory.Txt_Instance;

        public virtual FileWriter Factory() => new TxtWriter();

        public FileFactory FileWriterFactory(string file)
        {
            file = file.ToLower();
            Instance = (file == "xml") ? XmlFactory.Xml_Instance :
                       (file == "json") ? JsonFactory.Jsn_Instance :
                       (file == "txt") ? TxtFactory.Txt_Instance :
                       TxtFactory.Txt_Instance;
            return Instance;
        }
        public void WriteFile(Person p,string path)
        {
            Instance.Factory().write(path,p);
        }
    }
}