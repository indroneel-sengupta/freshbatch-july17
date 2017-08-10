using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class ConstType
    {
        private int Id;
        private string eName;
        //default constructor
        ConstType()
        {
            this.Id = 201;
            this.eName = "Default Constructor";
            Console.WriteLine(this.eName);
        }
    }
}
