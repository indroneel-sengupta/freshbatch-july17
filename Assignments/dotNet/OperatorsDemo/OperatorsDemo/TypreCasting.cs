using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OperatorsDemo
{
    class TypreCasting
    {
        public void Test()
        {
            bool num = true;
           
            try
            {
                if(num is bool)
                Console.WriteLine("Num is float");
                else Console.WriteLine("Num is int");
            }
            catch (Exception e)
            {
                Console.WriteLine("The Error is : " + e);
            }
        }
        public void Test1()
        {
            object[] myObj = new object[5];
            myObj[0] = null;
            myObj[1] = "STRING";
            myObj[2] = 123;
            myObj[3] = 12.25;
            myObj[4] = 'i';

            //for (int i = 0; i < myObj.Length; i++)
            //{
            //    string s = myObj[i] as string;
            //    bool b = String.IsNullOrEmpty(s);
            //    Console.WriteLine(b);

            //}

            int k = 20;
            object o = k;
            int j = (int)o;
            Console.WriteLine(j);
            long sn = 10; 
            long something = (long)2000000 * (long)10000000;



            Console.WriteLine("Explicit  =  "+ something);
                
        }


    }
}
