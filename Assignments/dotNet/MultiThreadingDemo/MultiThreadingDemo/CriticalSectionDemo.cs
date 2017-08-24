using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo
{
    class CriticalSectionDemo
    {
        decimal balance;
        public CriticalSectionDemo(decimal balance)
        {
            this.balance = balance;
        }
        public CriticalSectionDemo() { }
        public void _CriticalSectionDemo(decimal amount)
        {
            
                Console.WriteLine(Thread.CurrentThread.Name + "start");
            //if (amount > balance)
            //{
            //    throw new Exception("Insufficient funds");
            //}
            lock (this)
            {
                balance -= amount;
            }
            Console.WriteLine("Balance: {0}", balance);
                //Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + "End");
            
        }
    }
}
