using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18_Aug
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoRegex r = new DemoRegex();
            //r.Reg();

            //WhiteSpaces w1 = new WhiteSpaces();
            //w1.WhiteSpace();


            //DemoCollection d1 = new DemoCollection();
            //d1.Col();
            CustomStringBuilder cs = new CustomStringBuilder("Indroneel");
            Console.WriteLine(cs);
            cs.Append(" Sengupta");
            Console.WriteLine(cs);
            cs.RemoveAt(2);
            Console.WriteLine(cs);

            cs.InsertAt(2,"daaaaa");
            Console.WriteLine(cs);

            Console.Read();
        }
    }
}
