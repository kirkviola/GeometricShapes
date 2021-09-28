using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rect
    {
        public int SideLengthA { get; set; }
        public int SideLengthB { get; set; }

        public int Perimenter()
        {
            return SideLengthA * 2 + SideLengthB *  2;
        }

        public int Area()
        {
            return SideLengthA * SideLengthB;
        }
    }
}
