using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Triangle : Shape
    {
    public int basee;
    public int height;
    public Triangle(int basee, int height)
    {
        this.basee = basee;
        this.height = height;
    }
    public override void  getArea()
    {
            Console.WriteLine("Area of Triangle :" + 0.5 * basee * height);
    }
}

}
