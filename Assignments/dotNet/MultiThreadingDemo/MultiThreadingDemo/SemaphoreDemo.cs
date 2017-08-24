using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo
{
    class SemaphoreDemo
    { static Semaphore s1 = null;
        public void _SemaphoreDemo()
        {
            try
            {
                s1 = Semaphore.OpenExisting("TestDemo");
            }
            catch (Exception ex)
            {
                s1 = new Semaphore(3,3,"TestDemo");
            }
            Console.WriteLine("Acquiring...");
            s1.WaitOne();
            Console.WriteLine("Thread Acquired..");
            Console.ReadLine();
            s1.Release();
        }
    }
}
