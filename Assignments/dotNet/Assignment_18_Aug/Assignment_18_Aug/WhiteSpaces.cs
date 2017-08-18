using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18_Aug
{
    class WhiteSpaces
    {
        public void WhiteSpace()
        {
            Console.WriteLine("Please Enter the string");
            string str = Console.ReadLine();
            string s1 = str.Replace(" ","");
            Console.WriteLine("The replaced string is : "+s1);
        }
    }
}
