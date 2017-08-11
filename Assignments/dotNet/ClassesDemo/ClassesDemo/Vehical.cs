using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Vehicle
    {
        public virtual void Tyre()
        {
            Console.WriteLine("Tyre of vehicle");
        }
        public virtual void Color()
        {
            Console.WriteLine("Vehicle color red");

        }
    }

    class Ferrari :Vehicle
    {
        public override void Tyre()
        {
            Console.WriteLine("Tyre of Ferrari");
        }
        public override void Color()
        {
            Console.WriteLine("Ferrari color red");

        }
    }

    class Ford : Vehicle
    {
        public override void Tyre()
        {
            Console.WriteLine("Tyre of Ford");
        }
        public override void Color()
        {
            Console.WriteLine("Ford color yellow");

        }
    }
}
