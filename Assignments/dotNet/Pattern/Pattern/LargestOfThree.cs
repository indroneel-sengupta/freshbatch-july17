using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class LargestOfThree
    {
        public void Largest()
        {   

            int a = 2;
            int b = 10;
            int c = 5;

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("1st is Largest : "+a);
                }else
                {
                    Console.WriteLine("3rd is Largest : " + c);
                }
            }else
            {
                if (b > c)
                {
                    Console.WriteLine("2nd is Largest : " + b);
                }else
                {
                    Console.WriteLine("C is Largest : " + c);
                }
            }
        }
    }
}
