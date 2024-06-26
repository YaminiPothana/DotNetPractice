using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Circle : Shape
    {
        public static double PI = 3.14;
        public int r;
        public Circle(int r)
        {
            this.r = r;
        }
        public override void GetArea()
        {
            Console.WriteLine("Area of Circle :" + pi * r * r);
        }
    }
}
