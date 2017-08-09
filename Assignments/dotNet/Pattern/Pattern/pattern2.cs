using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Pattern2
    {
        public void pat()
        {
            int i = 0, j = 0, k = 1;
            for (i = 0; i < 5; i++)
            {
                for (j = 5; j > i; j--) Console.Write(" ");
                for (j = 0; j < i; j++)
                {
                    Console.Write(" *");

                }
                Console.WriteLine();
            }

            for (i = 5; i > 0; i--)
            {
                for (j = 5; j > i; j--) Console.Write(" ");
                for (j = i; j > 0; j--)
                {
                    Console.Write(" *");

                }
                Console.WriteLine();
            }
        }


        public void pat2()
        {
            Console.WriteLine("Enter the number for pattern");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0, j = 0, k = 1;
            for (i = 0; i < num; i++)
            {
                for (j = 5; j > i; j--) Console.Write("{0}",num);
                Console.WriteLine();
            }

        }
    }
}
