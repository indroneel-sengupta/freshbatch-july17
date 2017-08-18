using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18_Aug
{
    class DemoCollection
    {
        public void Col()
        {

            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("The collection is as follows");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------------------\nAfter Adding Elements");
            al.Add(99);
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------------------\nAfter deleting Elements");
            al.Remove(99);
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------------------\nAfter Updating Elements");
            int index = al.IndexOf(78);
            al.RemoveAt(index);
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
        }
    }
}
