using System.Drawing;

namespace MethodOverriding
{
    class SCRT_MAIN
    {
        public static void printArea(Shape shape)
        {
            shape.getArea();
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Main Starts");
            printArea(new Circle(6));
            printArea(new Rectangle(4.0, 6.0));
            printArea(new Triangle(2, 8));
            Console.WriteLine("Main Ends");
        }
    }
}