using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb17
{
    internal abstract class Triangle
    {
        public abstract double Perimetr();
        public abstract double Area();

    }
    class PramocutTriangle : Triangle
    {
        public double SizeOfStorona1 { get; set; }
        public double SizeOfStorona2 { get; set; }


        public override double Perimetr()
        {
            return SizeOfStorona1 + SizeOfStorona2 + Math.Pow((Math.Pow(SizeOfStorona1, 2) + Math.Pow(SizeOfStorona2, 2)), 0.5);
        }

        public override double Area()
        {
            return 0.5 * SizeOfStorona1 * SizeOfStorona2;
        }
    }
    class RivnobedTriangle : Triangle
    {
        public double SizeOfStorona1 { get; set; }
        public double SizeOfStorona2 { get; set; }
        public double CytMijStoronami { get; set; }
        
        public override double Perimetr()
        {
            double radians = CytMijStoronami * Math.PI / 180;

            double c = Math.Sqrt(Math.Pow(SizeOfStorona1, 2) + Math.Pow(SizeOfStorona2, 2) - 2 * SizeOfStorona1 * SizeOfStorona2 * Math.Cos(radians));
            return SizeOfStorona1 + SizeOfStorona2 + c;
        }
        public override double Area()
        {
            double radians = CytMijStoronami * Math.PI / 180;

            double c = Math.Sqrt(Math.Pow(SizeOfStorona1, 2) + Math.Pow(SizeOfStorona2, 2) - 2 * SizeOfStorona1 * SizeOfStorona2 * Math.Cos(radians));
            double p = (SizeOfStorona1 + SizeOfStorona2 + c) / 2;
            double h = (2 / SizeOfStorona1) * Math.Pow((p * (p - SizeOfStorona1)*(p - SizeOfStorona2)*(p-c)), 0.5);
            return (0.5)*SizeOfStorona1*h;
        }

    }

    class RivnoStoronniTriangle : Triangle
    {
        public double SizeOfStorona { get; set; }

        public override double Perimetr()
        {
            return SizeOfStorona * 3;
        }
        public override double Area() 
        {
            return (Math.Pow(SizeOfStorona, 2) * Math.Pow(3, 0.5))/4;
        }
    }
}

