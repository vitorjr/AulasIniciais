using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class ProductFile
    {
        public string Name { get; set; }
        public Double Price { get; set; }

        public ProductFile(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
