using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClassExercise.Abstraction
{
    internal class Triangle : Shape
    {
        double baseLength;

        double height;

        public Triangle(double bL, double h)
        {
            baseLength = bL;
            height = h;
        }

        public override double GetArea()
        {
            return 0.5 * baseLength * height;
        }
    }
}
