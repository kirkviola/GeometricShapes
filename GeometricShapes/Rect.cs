using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rect : Quad
    {

 
        public int Area()
        {
            return SideA * SideB;
        }
        public Rect(int sideA, int sideB) : base(sideA, sideB, sideA, sideB)
        {
        }
        public new void Print() // new is the keyword to tell different is what we want
        {
            Console.WriteLine($"Perimeter: {Perimeter()}, Area: {Area()}");
        }
        
    }
}
