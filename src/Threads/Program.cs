using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a single thread to run Function1 in parallel

            Thread obj1 = new Thread(Function1);

            // Threads are foreground by default

            // Foreground Execution
            // ======================
            // Thread1 continues to run even though Main has exited i.e. child continues even though parent is terminated
            // It continues until its logic is done
            // Function 1 is entered...
            // The main application has exited...
            // <enter in something>
            // Function 1 is exited...

            // Background Execution
            // =====================
            // Thread1 dies as soon as Min is finished i.e. child is terminated as soon as parent is
            // The main application has exited...
            // Function 1 is entered...

            // Start as a background thread. Comment out this line to run as foreground
            obj1.IsBackground = true;

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
