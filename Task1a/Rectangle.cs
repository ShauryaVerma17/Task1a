using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a
{
    class Rectangle : Shape
    {
        public double Length;
        public double Width;
        private double area;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double CalcArea()
        {
            area = Length * Width;
            return area;
        }
    }
}
