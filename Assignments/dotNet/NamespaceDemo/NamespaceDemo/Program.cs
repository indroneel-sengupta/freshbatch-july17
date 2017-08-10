using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cc= Demo.Ddemo1;


/// <summary>
/// We are practicing namespace Demo
/// </summary>
namespace NamespaceDemo
{
    class Program
    {
        static int Main(string[] args)
        {
            cc.Program p = new cc.Program();
            Console.WriteLine("1st Main");
            Demo.Ddemo1.Program.Main();
            Console.WriteLine(args[0] + " "  + args[1]);
            Console.ReadLine();

            return 1;
        }
    }
}

namespace Demo
{
    namespace Ddemo1
    {
        class Program
        {
            public static void Main()
            {
                Console.WriteLine("2nd Main");
            }
        }
    }
    
}
