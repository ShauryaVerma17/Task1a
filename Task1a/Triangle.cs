using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a
{
    class Triangle : Shape
    {
        public double SideA;
        public double SideB;
        public double SideC;
        private double semiP;
        private double area;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Have to override the abstract function in the abstract class and make it according to the derived class requirements.
        public override double CalcArea()
        {

            semiP = (SideA + SideB + SideC) / 2;

            area = Math.Sqrt((semiP) * (semiP - SideA) * (semiP - SideB) * (semiP - SideC));
            return area;
        }
    }
}
