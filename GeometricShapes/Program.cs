using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Quad()
            {
                SideA = 3,
                SideB = 4,
                SideC = 5,
                SideD = 6
            };
            var r1 = new Rect()
            {
                SideLengthA = 3, SideLengthB = 5
            };
            Console.WriteLine(r1.Perimenter());
            Console.WriteLine(r1.Area());

            var s1 = new Square()
            {
                Side = 5
            };
            Console.WriteLine(s1.Perimeter());
            Console.WriteLine(s1.Area());
        }
    }
}
