using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Swap
    {
        public void swap()
        {
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Swapped numbers are : {0} {1}",num1,num2);
        }
    }
}
