using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadingDemo
{
    class MultiThreadDemo
    {
        public void _MultiThreadDemo()
        {
            Console.WriteLine("Inside _mutiThread Demo");
            Console.ReadLine();
            Thread t = new Thread(Fun1);
            t.Start();
        }

        public void Fun1()
        {
            Console.WriteLine("inside fun1");
            Console.ReadLine();
            Thread t = new Thread(Fun2);
            t.Start();

        }

        public void Fun2()
        {
            Console.WriteLine("inside fun2");
            Console.ReadLine();
            Thread t = new Thread(Fun3);
            t.IsBackground = true;
            t.Start();

        }
        public void Fun3()
        {
            Console.WriteLine("inside fun3");
            Console.ReadLine();
            Thread t = new Thread(_MultiThreadDemo);
            t.Start();

        }
    }
}
