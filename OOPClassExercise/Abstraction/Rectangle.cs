using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClassExercise.Abstraction
{
    internal class Rectangle : Shape
    {

        double length;

        double breadth;

        public Rectangle(double l, double b)
        {
            length = l;
            breadth = b;
        }
        public override double GetArea()
        {
            return length * breadth;
        }
    }

}
