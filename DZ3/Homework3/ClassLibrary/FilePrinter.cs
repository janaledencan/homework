using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public class FilePrinter : IPrinter
    {
        public string FileName{get; private set;}
        public FilePrinter(string fileName)
        {
            this.FileName = fileName;
        }


        public void Print(string value)
        {
            using (var writer = new StreamWriter(FileName, true))
            {
                 writer.WriteLine(value);
            }
        }
    }
}
