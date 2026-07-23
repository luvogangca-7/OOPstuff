using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClassExercise.Abstraction
{
    internal class Circle : Shape
    {
        double radius;

        public Circle(double r)
        {
            radius = r;
        }
        public override double GetArea()
        {
            return 3.14 * radius * radius;
        }
    }
}
