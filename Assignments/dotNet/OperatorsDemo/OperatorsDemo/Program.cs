using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;


namespace OperatorsDemo
{
    class Program
    {
        public delegate void TestDelegate(string s);
        static void Main(string[] args)
        {
            ////TypreCasting t = new TypreCasting();
            ////t.Test1();
            //object[] myObj = new object[5];
            //myObj[0] = new Parent();
            //myObj[1] = new Child();
            //myObj[2] = 123;
            //myObj[3] = 12.25;
            //myObj[4] = 'i';
            //for (int i=0; i<myObj.Length; i++)
            //{
            //    if (myObj[i] is Parent)
            //    {
            //        Parent p = myObj[0] as Parent;
            //        p.Par();

            //    }else
            //    {
            //        if (myObj[i] is Child)
            //        {
            //            Child c = myObj[i] as Child;
            //            c.Chld();
            //        }
            //    }

            //}

            //Assignment 1
            //Assignment1 a1 = new Assignment1(2,4,4000);
            //a1.CallDelegate();

            ///Assignment2
            //Metronome m = new Metronome();
            //Listener l = new Listener();
            //l.Subscribe(m);
            //m.Start();

            //Assignment 3
            Employee[] emp = new Employee[5];
            emp[0] = new Employee(1, "Indroneel", "Admin", "NoProject");
            emp[1] = new Employee(1, "Indroneel1", "Clerk", "NoProject");
            emp[2] = new Employee(1, "Indroneel2", "Admin", "NoProject");
            emp[3] = new Employee(1, "Indroneel3", "Manager", "NoProject");
            emp[4] = new Employee(1, "Indroneel4", "Admin", "NoProject");
            emp[0].Lambda();
            Console.ReadLine();


        }
    }
}
