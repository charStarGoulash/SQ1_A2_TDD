﻿using System;
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
            if (sideA < 179 & sideB < 179)
            {
                double result = 180 - sideA - sideB;
                return result;
            }
            else
            {
                return -1;
            }
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
