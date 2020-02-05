using Empresa.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    abstract class AbstractShape : Ishape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
