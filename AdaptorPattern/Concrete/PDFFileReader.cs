using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace AdaptorPattern
{
    internal class PDFFileReader : IFileReader
    {
        PdfDocument document;
        public string Read()
        {
            string text = string.Empty;
            foreach(var page in document.Pages)
            {
                text += page.Contents.ToString();
            }
            return text;
        }

        public void SetPath(string path)
        {
            document = PdfReader.Open(path);
        }
    }
}