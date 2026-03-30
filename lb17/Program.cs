using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb17
{
    internal class Program
    {
        public static void Main()
        {
            var rivnobedTriangle = new RivnobedTriangle { SizeOfStorona1 = 5, SizeOfStorona2 = 6, CytMijStoronami = 60};
            var pramTriangle = new PramocutTriangle { SizeOfStorona1 = 5, SizeOfStorona2 = 6 };
            var rivnTriangle = new RivnoStoronniTriangle {SizeOfStorona = 6};
            printshape(rivnobedTriangle);
            printshape(pramTriangle);
            printshape(rivnTriangle);
        }
        static void printshape(Triangle triangle)
        {
            Console.WriteLine($"Perimitr: {triangle.Perimetr()} Area: {triangle.Area()}");
        }
    }
}
