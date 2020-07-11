using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingInCSharp
{
    class ThreadTest
    {
        bool done; 

       

        public void Go2()
        {
            if (!done)
            {
                
                Console.WriteLine("Done");
                done = true;
            }
        }
    }
}
