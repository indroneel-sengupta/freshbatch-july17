using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeToDb;
namespace CodeToDbConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dept = new DepartmentContext())
            {
                Console.WriteLine("Add Department");
                var deptObj = new Department { Did = 1,DName = "Clerk" , DAdress = "Pune"};
                dept.Departments.Add(deptObj);
                dept.SaveChanges();

                Console.WriteLine("Department recorded");
                Console.ReadLine();
            }

        }
    }
}
