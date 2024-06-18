using System;
namespace OperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result;
            int Num1 = 20, Num2 = 10;

            // Addition Operation
            Result = (Num1 + Num2);
            Console.WriteLine($"Addition Operator: {Result}");

            // Subtraction Operation
            Result = (Num1 - Num2);
            Console.WriteLine($"Subtraction Operator: {Result}");

            // Multiplication Operation
            Result = (Num1 * Num2);
            Console.WriteLine($"Multiplication Operator: {Result}");

            // Division Operation
            Result = (Num1 / Num2);
            Console.WriteLine($"Division Operator: {Result}");

            // Modulo Operation
            Result = (Num1 % Num2);
            Console.WriteLine($"Modulo Operator: {Result}");

            int x = 15;
            x += 10;  //It means x = x + 10 i.e. 15 + 10 = 25
            Console.WriteLine($"Add Assignment Operator: {x}");
            // initialize variable x again
            x = 20;
            x -= 5;  //It means x = x - 5 i.e. 20 - 5 = 15
            Console.WriteLine($"Subtract Assignment Operator: {x}");
            // initialize variable x again
            x = 15;
            x *= 5; //It means x = x * 5  i.e. 15 * 5 = 75
            Console.WriteLine($"Multiply Assignment Operator: {x}");
            // initialize variable x again
            x = 25;
            x /= 5; //It means x = x / 5 i.e. 25 / 5 = 5
            Console.WriteLine($"Division Assignment Operator: {x}");
            // initialize variable x again
            x = 25;
            x %= 5; //It means x = x % 5 i.e. 25 % 5 = 0
            Console.WriteLine($"Modulo Assignment Operator: {x}");

            Console.WriteLine("Printing Relational Operators   ");
            Console.WriteLine("                ");

            bool Result1;
            Result1 = (Num1 == Num2);
            Console.WriteLine("Equal (=) to Operator: " + Result1);
            // Greater than Operator
            Result1 = (Num1 > Num2);
            Console.WriteLine("Greater (<) than Operator: " + Result1);
            // Less than Operator
            Result1 = (Num1 < Num2);
            Console.WriteLine("Less than (>) Operator: " + Result1);
            // Greater than Equal to Operator
            Result1 = (Num1 >= Num2);
            Console.WriteLine("Greater than or Equal to (>=) Operator: " + Result1);
            // Less than Equal to Operator
            Result1 = (Num1 <= Num2);
            Console.WriteLine("Lesser than or Equal to (<=) Operator: " + Result1);
            // Not Equal To Operator
            Result1 = (Num1 != Num2);
            Console.WriteLine("Not Equal to (!=) Operator: " + Result1);

            Console.ReadKey();
        }
    }
}