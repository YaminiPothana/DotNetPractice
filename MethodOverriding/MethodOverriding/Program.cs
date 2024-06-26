using System.Drawing;

namespace MethodOverriding
{
    class Program
    {
        public static void PrintArea(Shape shape)
        {
            shape.GetArea();
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Main Starts");
            PrintArea(new Circle(6));
            PrintArea(new Rectangle(4.0, 6.0));
            PrintArea(new Triangle(2, 8));
            Console.WriteLine("Main Ends");
        }
    }
}