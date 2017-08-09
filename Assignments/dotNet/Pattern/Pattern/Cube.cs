using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Cube
    {
        public void CalCube()
        {
            Console.WriteLine("Please Enter the number of terms");
            int terms = Convert.ToInt32(Console.ReadLine());
            
            for (int i=1; i <= terms; i++ )
            {
                Console.WriteLine("The Cube of Number {0} = {1} ",i,(i*i*i));
            }
        }
    }
}
