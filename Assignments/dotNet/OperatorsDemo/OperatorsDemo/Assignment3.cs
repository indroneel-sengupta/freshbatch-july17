using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsDemo
{
    class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string deptName { get; set; }
        public string projectName { get; set; }
        static List<Employee> empList = new List<Employee>();


        public Employee(int id,string name,string deptName,string projectName)
        {
            this.ID = id;
            this.name = name;
            this.deptName = deptName;
            this.projectName = projectName;
            empList.Add(this);
        }

        public void Lambda()
        {
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("Retrieving Employee in Dept Admin\n");
            foreach (Employee emp in empList.FindAll(e => (e.deptName == "Admin")))
            {
                Console.WriteLine("Name : " + emp.name + " \t\tDeptName: " + emp.deptName);
            }


            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("Retrieving Any Employee in Clerical Dept\n");

            if (empList.Any(e => (e.deptName == "Clerk")))
            {
                Console.WriteLine("Yes, we have some Clerks in the list");
            }

            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\nChecking whether a person having name 'Indroneel' exists or not...");
            if (empList.Exists(e => e.name == "Indroneel"))
            {
                Console.WriteLine("Yes, A person having name  'Indroneel' exists in our list");
            }else
            {
                Console.WriteLine("No, A person having name  'Indroneel' does not exists in our list");

            }

            Console.WriteLine("\n-----------------------------------------------------------------------------");
            var tmp = empList.GroupBy(x => x.ID);
            Console.WriteLine(tmp);



        }
    }
}
