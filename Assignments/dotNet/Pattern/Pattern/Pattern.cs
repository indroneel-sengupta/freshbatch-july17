using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class Pattern
    {
        public void pat()
        {
            int itr = int.Parse(Console.ReadLine());
            int i = 0, j = 0;
            for (i = 0; i < itr; i++)
            {
                Console.WriteLine("{0}{1}",new string(' ',itr-i),new string('*',i+1));
              
            }

        }
    }
}
