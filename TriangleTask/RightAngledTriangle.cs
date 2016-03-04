using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask
{
    public class RightAngledTriangle : Triangle
    {

        public RightAngledTriangle(double a, double b, double c) : base(a, b, c)
        {
            double[] sides = new double[3] { a, b, c };
            Array.Sort(sides);

            //Verify Pythagoras' theorem
            if((Math.Pow(sides[0],2)+Math.Pow(sides[1],2)!=Math.Pow(sides[2],2)))
                throw new ArgumentOutOfRangeException("Not right-angled triangle");            
        }
    }
}
