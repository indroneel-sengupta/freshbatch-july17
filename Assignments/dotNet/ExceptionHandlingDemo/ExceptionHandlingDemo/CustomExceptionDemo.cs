using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public class CustomException:Exception
    {
        public CustomException(string message) : base(message) { }
    }

    public class Temperature
    {
        public void Temp()
        {
            int temp = 0;
            try
            {
                Console.WriteLine("Enter Temperature");
                temp = int.Parse(Console.ReadLine());
                if (temp == 0) throw (new CustomException("TemperatureZeo Exception from method Temp"));
            }
            catch (CustomException tz)
            {
                Console.WriteLine("Exception : {0}",tz);
            }
            finally
            {
                Console.WriteLine("temperature = {0}",temp);
                Console.WriteLine("\n\nEnter Number greater Than 100");
                NumberGreaterThanHundred();
            }
        }


        public void NumberGreaterThanHundred()
        {
            int temp = 0;
            try
            {
                temp = int.Parse(Console.ReadLine());
                if (temp < 1000) throw (new CustomException("Number Less Than 100 Exception from method NumberGreaterThanHundred"));
            }
            catch (CustomException tz)
            {
                Console.WriteLine("Exception : {0}", tz.Message);
            }
            finally
            {
                Console.WriteLine("Number = {0}", temp);
            }
        }
    }
}
