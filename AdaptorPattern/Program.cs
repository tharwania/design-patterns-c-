using System;

namespace AdaptorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            IFileReader fileReader = CreateFileReader("Text");
            fileReader.SetPath(@"..\myFile.txt");
            Console.WriteLine(fileReader.Read());
            // now, what if we need to read pdf files ?
            // we have already implimented FileReader in lots of places so instead of changing everywhre
            // we'll impliment new implimentation of IFileReader 
            fileReader = CreateFileReader("PDF");
            fileReader.SetPath("mypdf.pdf");
            // so even if internal library has different interface but we implimented an adaptor
            // so we can just use same interface everywhere
            // and also we can call this interface facade too because we have simplified pdf library
            // instead of calling multiple functions to read we just call Read()
            // it would have been called proxy if we impliment same/near same interface as PDF Library
            Console.WriteLine(fileReader.Read());
        }

        private static IFileReader CreateFileReader(string type)
        {
            return type switch
            {
                "Text" => new TextFileReader(),
                "PDF" => new PDFFileReader(),
                _ => new TextFileReader(),
            };
        }
    }
}
