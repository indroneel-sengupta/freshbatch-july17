using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionHand ex = new ExceptionHand();
            //ex.TestException();

            Temperature t1 = new Temperature();
            t1.Temp();
        }
    }
}
