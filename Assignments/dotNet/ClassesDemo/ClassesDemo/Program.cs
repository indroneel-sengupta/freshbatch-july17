using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PartialClass p1 = new PartialClass();
            //p1.p1();
            //p1.p2();
            //p1.p3();
            //StaticClassDemo.AreaRect(2.5,3.3);


            //10.MultiplyBy(2);
            //22.5.DivideBy(2.2);

            //IEmployee e1 = new Employee1();
            //IEmployee e2 = new Employee2();


            //e1.CalSal();
            //e2.CalSal();
            //DontKnow(e2);


            //Console.WriteLine("Please enter the string");
            //string str = Console.ReadLine();
            //str.UpperCaseFirstletterOfString();



            IVehicle m1 = new Maruti();
            IVehicle s1 = new Suzuki();
           
            DontKnow(s1);
            Console.ReadLine();
        }

        //public static void DontKnow(Vehicle v1)
        //{
        //    v1.Tyre();
        //    v1.Color();
        // }
        public static void DontKnow(IVehicle v1)
        {
            v1.Tyre();
            v1.Color();
        }


    }
}
