using System;
using System.Collections.Generic;
using System.Text;

namespace OOPClassExercise.Abstraction
{
    internal class AbstractionSample
    {
        public static void Run()
        {
            Square spongebob = new Square(6);

            double area = spongebob.GetArea();

            Console.WriteLine(area);

            Rectangle rec = new Rectangle(2.6, 7.7);

            area = rec.GetArea();

            Console.WriteLine(area);

            Triangle tri = new Triangle(2.6, 7.7);

            area = tri.GetArea();

            Console.WriteLine(area);
        }
    }
}
