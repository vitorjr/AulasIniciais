using Empresa.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class Circle : Shape
    {
        public Double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
