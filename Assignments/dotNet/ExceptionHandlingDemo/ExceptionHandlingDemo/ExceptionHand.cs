using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class ExceptionHand
    {
        public void Add()
        {
            int num1;
            int num2;
            int num3= 0;
            try
            {
                Console.WriteLine("Enter 1st number");
                 num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1st number");
                num2 = int.Parse(Console.ReadLine());
                 

                num3 = num1 + num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("exception caught : "+e);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Format Exception: {0}", fe);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}",e);
            }
            finally
            {
                Console.WriteLine("num1+num2 :" + (num3));

            }
        }

        public void Sub()
        {
            int num1;
            int num2;
            int num3 = 0;
            try
            {
                Console.WriteLine("Enter 1st number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1st number");
                num2 = int.Parse(Console.ReadLine());


                num3 = num1 - num2;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("exception caught : " + e);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Format Exception: {0}",fe);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e);
            }
            finally
            {
                Console.WriteLine("num1-num2 :" + (num3));

            }
        }
        public void Mul()
        {
            int num1;
            int num2;
            int num3 = 0;
            try
            {
                Console.WriteLine("Enter 1st number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1st number");
                num2 = int.Parse(Console.ReadLine());


                num3 = num1 * num2;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("exception caught : " + e);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Format Exception: {0}", fe);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e);
            }
            finally
            {
                Console.WriteLine("num1 * num2 :" + (num3));

            }
        }

        public void TestException()
        {
            
            try
            {
                Console.WriteLine("Enter Date");
                char s = Convert.ToChar(Console.ReadLine());
                DateTime dt = Convert.ToDateTime(s);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("exception caught : " + e);
            }
            catch (InvalidCastException ie)
            {
                Console.WriteLine("Invalid Cast Exception: {0}", ie);

            }
            catch (FormatException fe)
            {
                Console.WriteLine("Format Exception: {0}", fe);
            }
           
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e);
            }
            finally
            {
                Console.WriteLine("Exception Test :");

            }
        }

        public void Divide()
        {
            int num1;
            int num2;
            int num3 = 0;
            try
            {
                Console.WriteLine("Enter 1st number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1st number");
                num2 = int.Parse(Console.ReadLine());


                num3 = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("exception caught : " + e);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Format Exception: {0}", fe);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0}", e);
            }
            finally
            {
                Console.WriteLine("num1/num2 :" + (num3));

            }
        }


    }
}
