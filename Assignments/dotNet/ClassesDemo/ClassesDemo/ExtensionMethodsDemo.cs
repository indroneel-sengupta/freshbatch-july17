using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
   public static class ExtensionMethodsDemo
    {
        public static void MultiplyBy(this int value,int multiplier)
        {
            Console.WriteLine("Result = "+(value*multiplier));
        }

        public static void DivideBy(this double value, double divisor)
        {
            Console.WriteLine("Result = " + (value/divisor));
        }
    }
}
