using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Rectangle: Shape
    {
    public double length;
    public double width;
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public override void getArea()
    {
       Console.WriteLine("Area of Rectangle :" + length * width);
    }
}

}
