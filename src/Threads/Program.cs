using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread obj1 = new Thread(Function1);
            Thread obj2 = new Thread(Function2);

            obj1.Start();
            obj2.Start();

        }

        static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Function 1 executed: {i.ToString()}"); ;
                // wait fir 4 secs
                Thread.Sleep(4000);
            }

        }
        static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Function 2 executed: {i.ToString()}"); ;
                // wait fir 4 secs
                Thread.Sleep(4000);
            }

        }
    }
}
