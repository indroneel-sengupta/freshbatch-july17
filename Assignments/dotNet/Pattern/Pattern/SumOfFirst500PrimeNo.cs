using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class SumOfFirst500PrimeNo
    {
        public void sumOfPrime()
        {
            int cnt = 0;
            long sum = 0;
            
            for (int num=2; num<10000; num++) {
                bool flag = true;
                int i = 2;
                while (i  < num)
                {
                    if (num%i == 0)
                    {                        
                        flag = false;
                        break;                         
                    }
                    i++;                  
                }
                if (flag)
                {
                    if (cnt<1000) {
                        cnt++;
                        sum += num;
                        Console.WriteLine("num = "+num+" cnt = "+cnt);
                    }
                }
            }
            Console.WriteLine(sum);
        }    
    }
}
