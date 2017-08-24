using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo
{
    class MutexDemo
    {
        public void _MutexDemo()
        {
            using (var m = new Mutex(false,"TestMutex"))
            {
                Console.WriteLine("App started");

                if (!m.WaitOne(5000,false))
                {
                    Console.WriteLine("Already running");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("App started");
                Console.ReadLine();
            }
        }
    }
}
