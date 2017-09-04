using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDataBase.Models
{
    public class EmployeeNew
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Sal { get; set; }
    }
}