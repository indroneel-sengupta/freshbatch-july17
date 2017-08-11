using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    interface IEmployee
    {
        void CalSal();
        void GetSal();
      
    }

    class Employee1 : IEmployee
    {
        void IEmployee.CalSal()
        {
            Console.WriteLine("Inside calsal Employee 1");
        }

        void IEmployee.GetSal()
        {
            Console.WriteLine("Inside getSal Employee 1");
        }
    }

    class Employee2 : IEmployee
    {
        void IEmployee.CalSal()
        {
            Console.WriteLine("Inside calsal Employee 2");
        }

        void IEmployee.GetSal()
        {
            Console.WriteLine("Inside getSal Employee 2");
        }
    }
}
