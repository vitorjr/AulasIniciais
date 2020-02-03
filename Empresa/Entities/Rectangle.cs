using Empresa.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class Rectangle : Shape
    {
        public Double Width { get; set; }
        public Double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override Double Area()
        {
            return Width * Height;
        }
    }
}
