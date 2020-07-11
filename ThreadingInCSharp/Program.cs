using System;
using System.Threading;


namespace ThreadingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);          
            
            // Kick off a new thread
            t.Start();                               
            
            // running WriteY()
            
            Console.Write(t.IsAlive);
            
            // Simultaneously, do something on the main thread.
            
            for (int i = 0; i < 1000; i++) Console.Write("x");
            
            Console.Write(t.IsAlive);
            
            Console.ReadLine();

            new Thread(Go).Start();
            Go();
            Console.ReadLine();

            ThreadTest tt = new ThreadTest(); // Create a common instance

            new Thread(tt.Go2).Start();

            tt.Go2();
            Console.ReadLine();






        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }

        static void Go()
        {
            for (int cycles = 0; cycles < 5; cycles++)
            {
                Console.Write('?');
            }
        }

    }
    
}
