using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Quad(3, 4, 5, 6);
            var r1 = new Rect(3, 7);
            q1.Print();
            r1.Print();
           
            Console.WriteLine(r1.Perimeter());
            Console.WriteLine(r1.Area());

            var s1 = new Square(4);
            Console.WriteLine(s1.Perimeter());
            Console.WriteLine(s1.Area());
            s1.Print();
        }
    }
}
