using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    public class Triangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Triangle(double a, double b, double c)
        {
            //Verify the sides' lenght
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Wrong sides");

            //Verify the triangle inequality theorem
            if (a >= (b + c) || b >= (a + c) || c >= (b + a))
                throw new ArgumentOutOfRangeException("Inequality triangle");
            
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public double getArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

}
