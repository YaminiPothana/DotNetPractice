using System;
namespace TypesOfVariables
{
    internal class Program
    {

        /*This to show the usage of static variable with in the program without creating an instance.*/

        //static int x = 100; //Static Variable
        //int y = 200; //Non-Static or Instance Variable
        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"x value: {x}");
        //    Console.Read();


        /*Static variable is initialized when the execution of the program starts whereas non static variable needs an instance to initialize it.*/

        //static int x = 100; //static variable
        //int y = 200; //non-static or instance variable

        ////class constructor
        //public  Program(int a)
        //{
        //    y = a;
        //}

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine($"x value: {x}");
        //    Program obj1 = new Program(300);
        //    Program obj2 = new Program(400);
        //    Console.WriteLine($"obj1 y value: {obj1.y}");
        //    Console.WriteLine($"obj2 y value: {obj2.y}");
        //    Console.Read();

        //}



        /**/
        //static int x = 100; //Static Variable
        //int y = 200; //Non-Static or Instance Variable
        ////Class Constructor
        //static int m;
        //public Program(int a)
        //{
        //    y = a;
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"x value: {x}");
        //    Program obj1 = new Program(300);
        //    Program obj2 = new Program(400);
        //    Console.WriteLine($"obj1 y value: {obj1.y}");
        //    Console.WriteLine($"obj2 y value: {obj2.y}");
        //    Console.WriteLine(m);
        //    Console.Read();
        //}

        static void Main(string[] args)
        {
            Console.Read();
        }
        public void NonStaticBlock()
        {
            //By Default, every local variable is going to be non-static
            //The Scope is limited to this method only
            int x = 100;

        }
        public static void StaticBlock()
        {
            //By Default, every local variable is going to be static
            //The Scope is limited to this method only
            int y = 100;


            /* Variables are of 4 types:
             1. Static : Declared with an static modifier and all the variables in static block and 
                         Static variables of a class are initialized immediately once the execution of the class starts.
            
             2.Non Static: All the variabled except static variables and all the vaiables in non static block and 
                           non-static variables or instance variables are initialized only after creating the class instance.

             3. Constant: In C#, if we declare a variable by using the const keyword, then it is a constant variable and the value of the constant 
                          variable can’t be modified once after its declaration. The only difference between a static and constant variable is that the static variables can be modified 
                          whereas the constant variables in C# can’t be modified once it is declared.
             4. Read only:  
            */

        }
    }
}
