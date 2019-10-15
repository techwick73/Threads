using System;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Function1();
            Function2();
        }

        static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Function 1 executed: {i.ToString()}"); ;
            }

        }
        static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Function 2 executed: {i.ToString()}"); ;
            }

        }
    }
}
