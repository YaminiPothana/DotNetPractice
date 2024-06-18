//using System;
//namespace ClassObjectsDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Creating object
//            Calculator calObject = new Calculator();

//            //Accessing Calculator class member using Calculator class object
//            int result = calObject.CalculateSum(10, 20);

//            Console.WriteLine(result);
//            Console.ReadKey();
//        }
//    }

//    //Defining class or blueprint or template
//    public class Calculator
//    {
//        public int CalculateSum(int no1, int no2)
//        {
//            return no1 + no2;
//        }
//    }
//}

using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            Console.WriteLine($"i = {obj.i}");
            Console.WriteLine($"b = {obj.b}");

            //value null will be printed, so here we checking the null
            if (obj.s == null)
            {
                Console.WriteLine("s = null");
            }

            Console.ReadKey();
        }
    }
    class Test
    {
        public int i;
        public bool b;
        public string s;
    }
}