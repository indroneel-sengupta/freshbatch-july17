using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class CelciusToFarheneit
    {
        public void celToFar()
        {
            double cel = double.Parse(Console.ReadLine());
            double far = (cel * 1.8) +32.0;

            Console.WriteLine("cel = "+cel+"^C  "+"Farheneit = "+far);
        }
    }
}
