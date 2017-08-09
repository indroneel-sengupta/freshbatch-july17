using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class ReverseString
    {
        public void RevStr()
        {
            Console.WriteLine("Please enter the string to be reversed");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');

            for (int i = words.Length-1 ; i >= 0 ; i--)
            {
                Console.Write(words[i]+" ");
            }
        }
    }
}
