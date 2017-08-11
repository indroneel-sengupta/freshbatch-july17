using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    interface IVehicle
    {
        void Tyre();
        void Color();
    }

    class Maruti : IVehicle
    {
        public  void Tyre()
        {
            Console.WriteLine("Tyre of Maruti");
        }
        public  void Color()
        {
            Console.WriteLine("Maruti color red");

        }
    }

    class Suzuki : IVehicle
    {
        public void Tyre()
        {
            Console.WriteLine("Tyre of Suzuki");
        }
        public  void Color()
        {
            Console.WriteLine("Suzuki color yellow");

        }
    }
}
