using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Triangle : Shape
    {
        public int Basee;
        public int Height;
        public Triangle(int Basee, int Height)
        {
            this.basee = Basee;
            this.height = Height;
        }
        public override void GetArea()
        {
            Console.WriteLine("Area of Triangle :" + 0.5 * basee * height);
        }
    }

}
