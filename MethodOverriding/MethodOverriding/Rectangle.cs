using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Rectangle : Shape
    {
        public double Length;
        public double Width;
        public Rectangle(double Length, double Width)
        {
            this.length = Length;
            this.Width = Width;
        }
        public override void GetArea()
        {
            Console.WriteLine("Area of Rectangle :" + length * width);
        }
    }

}
