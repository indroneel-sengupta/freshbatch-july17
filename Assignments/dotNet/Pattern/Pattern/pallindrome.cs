using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Pallindrome
    {
        public void isPallin()
        {
            string str = Console.ReadLine();
            bool flag = true;
            int len = str.Length;
            for (int i=0; i<len/2; i++)
            {
                if (str[i]  != str[len-1])
                {
                    flag = false;
                    break;
                }
                len--;
            }
            if (flag)
            {
                Console.WriteLine("The String is Pallindrome");
            }
            else Console.WriteLine("The String is not pallindrome");
        }
    }
}
