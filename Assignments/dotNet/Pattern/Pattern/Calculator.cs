using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Calculator
    {
        public void Calc()
        {
            Console.WriteLine("1-Additon");
            Console.WriteLine("2-Subtraction");
            Console.WriteLine("3-Multiplication");
            Console.WriteLine("4-Divison");
            Console.WriteLine("5-Exit");
            int menu = Convert.ToInt32(Console.ReadLine());
            int num1 = 0, num2 = 0;
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Enter First number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second number");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Addition of {0}+{1} = {2}",num1,num2,(num1+num2));
                    break;

                case 2:
                    Console.WriteLine("Enter First number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second number");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Subtratcion of {0}-{1} = {2}", num1, num2, (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Enter First number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second number");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Product of {0}*{1} = {2}", num1, num2, (num1 * num2));
                    break;

                case 4:
                    Console.WriteLine("Enter First number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    double temp = (double)num1 / num2;
                    Console.WriteLine("Division of {0}/{1} = {2}", num1, num2, temp);
                    break;

                default:
                    return;
                    break;
            }
        }
    }
}
