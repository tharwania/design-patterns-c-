using System.IO;

namespace AdaptorPattern
{
    internal class TextFileReader : IFileReader
    {
        string path;
        public string Read()
        {
            return File.ReadAllText(path);
        }

        public void SetPath(string path)
        {
            this.path = path;
        }
    }
}