using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
   public static class StaticClassDemo
    {
        public static void AreaRect(double length,double breadth)
        {
            Console.WriteLine("Area Of rectangle  = "+(length*breadth));
        }


        public static string UpperCaseFirstletter(this string value)
        {
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }

        public static void UpperCaseFirstletterOfString(this string value)
        {   
            string[] words = value.Split(' ');
            foreach (string word in words)
            {
                 string str = word.UpperCaseFirstletter();
                Console.Write(str+" ");
            }

        }



    }
}
