namespace AdaptorPattern
{
    internal interface IFileReader
    {
        void SetPath(string path);
        string Read();
    }
}