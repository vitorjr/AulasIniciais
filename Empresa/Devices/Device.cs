using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDocs(string document);
    }
}
