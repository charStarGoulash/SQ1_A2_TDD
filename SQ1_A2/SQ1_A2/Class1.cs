using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ1_A2
{
    public class Triangle
    {
        public double GetMissingAngle(double sideA, double sideB)
        {
            double result = 180 - sideA - sideB;
            return result;
        }

        public double FindHypotenuse(double sideA, double sideB)
        {
            return 0;
        }

        public double GetArea(double sideA, double sideB)
        {
            return 0;
        }
    }
}
