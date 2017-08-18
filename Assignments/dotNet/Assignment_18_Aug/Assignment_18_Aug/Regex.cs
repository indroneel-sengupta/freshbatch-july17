using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace Assignment_18_Aug
{
    class DemoRegex
    {
        public void Reg()
        {
            Console.WriteLine("Please Enter the mobile Number");
            string phone = Console.ReadLine();
            string pattern = @"^\d{3}-\d{4}$";

            
            
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);            
          
            if (r.IsMatch(phone)) Console.WriteLine("Valid Input");
            else Console.WriteLine("Invalid Input");
        }
    }
}
