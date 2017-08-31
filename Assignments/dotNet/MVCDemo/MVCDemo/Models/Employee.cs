using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Sal { get; set; }
       
    }

    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}