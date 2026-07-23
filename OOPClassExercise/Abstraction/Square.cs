using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClassExercise.Abstraction
{
    internal class Square : Shape
    {

        private double length;

        public Square(double l)
        {
            length = l;
        }
        public override double GetArea()
        {
            return length * length; 
        }
    }
}
