using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Quad
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public int SideD { get; set; }

        public Quad() { }
        public Quad(int side1, int side2, int side3, int side4)
        {
            this.SideA = side1;
            this.SideB = side2;
            this.SideC = side3;
            this.SideD = side4;
        }

        public void Print()
        {
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }


        public int Perimeter ()
        {
            return SideA + SideB + SideC + SideD;
        }

    }
}
