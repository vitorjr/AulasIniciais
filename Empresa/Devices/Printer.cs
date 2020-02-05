using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Devices
{
    abstract class Printer : Device
    {
        public override void ProcessDocs(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print"+document);
        }
    }
}
