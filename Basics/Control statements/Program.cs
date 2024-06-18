
/*Looping statements*/


using System;
namespace forloop
{
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        for (int i = 1; i <= 10; i++)
    //        {
    //            Console.WriteLine(i);
    //        }

    //    }
    //}


    //class Looping
    //{
    //    static void Main(string[] args)
    //    {
    //        int i, n;
    //        Console.Write("Enter a Number : ");
    //        n = Convert.ToInt32(Console.ReadLine());
    //        i = 4;
    //        while (i <= n)
    //        {
    //            Console.Write($"{i} ");
    //            i = i + 2;
    //        }
    //        Console.ReadKey();

    //    }
    //}



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER  A NUMBER ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine();
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }
                i++;
            }

            Console.ReadKey();
        }
    }




    //class Program1
    //{
    //    static void Main(string[] args)
    //    {
    //        int number = 1;
    //        do
    //        {
    //            Console.Write($"{number} ");
    //            number++;
    //        } while (number <= 5);

    //        Console.ReadKey();
    //    }
    //}
}