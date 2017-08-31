using DemoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new EmployeeLatestEntities())
            {
                //    var emp = new EmpTable();
                //    emp.EmpId = 2;
                //    emp.Name = "Emp2";
                //    emp.Salary = 100009;

                //    EmpObj.EmpTables.Add(emp);
                //    EmpObj.SaveChanges();

                Console.WriteLine("Record inserted");

                foreach (var e in EmpObj.EmpTables.Where((e1)=> e1.EmpId == 2))
                {
                    e.Name = "Emp2New";
                    EmpObj.EmpTables.Remove(e);
                    Console.WriteLine("EmpId : {0}  Name : {1}  Salary : {2}",e.EmpId,e.Name,e.Salary);
                }

            }
        }
    }
}
