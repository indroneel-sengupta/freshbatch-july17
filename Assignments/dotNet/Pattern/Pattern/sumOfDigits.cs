using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class SumOfDigits
    {
        public void Sum()
        {
            int i = 1345;
            String s = i.ToString();
            int len = s.Length;
           
            i = Convert.ToInt32(s);
            int j=0,sum=0;
            while (j<len)
            {
                sum += i % 10;
                i /= 10;
                j++;
            }

            Console.WriteLine(sum);

        }
    }
}
