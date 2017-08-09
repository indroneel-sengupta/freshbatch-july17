using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class LeapYear
    {
        public void CheckLeap()
        {
            Console.WriteLine("Please Enter the Year");
            int year = 0;
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("The Year is Leap year : "+year);

                }else
                {
                    Console.WriteLine("The Year is Not Leap year : " + year);

                }
            }else
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("The Year is Leap year : " + year);

                }
                else
                {
                    Console.WriteLine("The Year is Not Leap year : " + year);

                }
            }



        }
    }
}
