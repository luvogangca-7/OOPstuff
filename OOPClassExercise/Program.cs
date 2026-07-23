using OOPClassExercise.Abstraction;
using OOPClassExercise.Encapsulation;

namespace OOPClassExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EncapsulationSample.Run();

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
