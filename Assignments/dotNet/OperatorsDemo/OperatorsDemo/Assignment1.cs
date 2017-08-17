using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsDemo
{
    class Assignment1
    {
        public delegate void TestDelegate();

        public int rate { get; set; }
        public int year { get; set; }
        public int principal { get; set; }

        public Assignment1(int rate, int year , int principal)
        {
            this.rate = rate;
            this.year = year;
            this.principal = principal;
        }
        public void CallDelegate()
        {
            TestDelegate d1 = new TestDelegate(getTotalInterest);
            d1 += new TestDelegate(getInterestPerYear);
            //d1 += delegate (string s)
            //{
            //    Console.WriteLine(string.Format("Hello {0} from Anonomyous method", s));
            //};
            //d1 += n =>
            //{
            //    Console.WriteLine(string.Format("Hello {0} from lambda method", n));
            //};
            d1();
        }

        public void getTotalInterest()
        {
            Console.WriteLine("Total Interest :"+(double)(this.rate*this.principal));
        }

        public void getInterestPerYear()
        {
            
            Console.WriteLine("Per Year Interest :" + (double)(this.rate * this.principal/this.year));
        }
        public void ImplementDelegate(string s)
        {
            Console.WriteLine(string.Format("Hello {0} from instance method", s));
        }

        public void ImplementDelegate1(string s)
        {
            Console.WriteLine(string.Format("Hello {0} from ImplementDelegate1 method", s));
        }
    }
}
