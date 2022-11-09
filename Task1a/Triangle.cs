using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a
{
    class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        private double _semiP;
        private double _area;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Have to override the abstract function in the abstract class and make it according to the derived class requirements.
        public override double CalcArea()
        {

            _semiP = (SideA + SideB + SideC) / 2;

            _area = Math.Sqrt((_semiP) * (_semiP - SideA) * (_semiP - SideB) * (_semiP - SideC));

            return _area;
        }
    }
}
