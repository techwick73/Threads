using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a single thread to run Function1 in parallel
            // Threads are foreground by default
            // Thread1 continues to run even though Main has exited

            // Function 1 is entered...
            // The main application has exited...
            // <enter in something>
            // Function 1 is exited...
            Thread obj1 = new Thread(Function1);

            obj1.Start();

            // Control is returned from Function1
            System.Console.WriteLine("The main application has exited ...");

        }

        static void Function1()
        {

            System.Console.WriteLine("Function 1 is entered ...");
            // waits here until user enters something
            Console.ReadLine(); // wait here
            System.Console.WriteLine("Function 1 is exited ...");

        }

    }
}
