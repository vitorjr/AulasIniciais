using Empresa.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    abstract class Shape
    {
        public Color Cor { get; set; }

        public Shape(Color cor)
        {
            Cor = cor;
        }

        public abstract Double Area();
    }
}
