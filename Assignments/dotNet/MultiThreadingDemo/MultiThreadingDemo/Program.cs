using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parallel.For(0, 100000, x => Function1());
            //Console.ReadLine();
            //MultiThreadDemo md = new MultiThreadDemo();
            //md._MultiThreadDemo();

            //CriticalSectionDemo csd = new CriticalSectionDemo(100);
            //Thread th1 = new Thread(() => csd._CriticalSectionDemo(100));
            //Thread th2 = new Thread(() => csd._CriticalSectionDemo(100));
            //th1.Name = "Thread 1";
            //th2.Name = "th2";
            //th1.Start();
            //th2.Start();


            //MutexDemo md = new MutexDemo();
            //md._MutexDemo();
            //using (var m = new Mutex(false, "TestMutex"))
            //{


            //    if (!m.WaitOne(5000, false))
            //    {
            //        Console.WriteLine("Already running");
            //        Console.ReadLine();
            //        return;
            //    }
            //    Console.WriteLine("App started");
            //    Console.ReadLine();
            //}

            SemaphoreDemo sd = new SemaphoreDemo();
            sd._SemaphoreDemo();
            //sd._SemaphoreDemo();
            //sd._SemaphoreDemo();
            //sd._SemaphoreDemo();

            Console.ReadLine();
             

            //Console.WriteLine("Main last line");


        }

        static void Function1()
        {
            
            Console.WriteLine("ABove readline");
            Console.ReadLine();
            Console.WriteLine("Inside function");
        }
    }
}
