using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Devices
{
    abstract class Scanner : Device
    {
        public override void ProcessDocs(string document)
        {
            Console.WriteLine("Scanner processing: "+document);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
