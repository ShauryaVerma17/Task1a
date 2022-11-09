using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        private double _area;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double CalcArea()
        {
            _area = Length * Width;
            return _area;
        }
    }
}
