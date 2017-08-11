using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Table
    {
        public void tab()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i =1; i < 11; i++)
            {
                Console.WriteLine(i*num);
            }
        }
         public void CheckVoewl()
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            int i = 0;
            string rem = "";
            string temp = str;
            int count = str.Length;

            while (i<count)
            {
                switch (str[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        str = str.Remove(i,1);
                        Console.WriteLine("Inner switch = ",rem);
                        count = str.Length;
                        i = 0;
                        break;
                    default:
                        Console.WriteLine("Inner default = ", rem);
                        break;                       
                }
                
                i++;
            }
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
