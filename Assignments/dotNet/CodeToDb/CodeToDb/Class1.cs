using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToDb
{
    public class Department
    {
        [Key]
        public int Did { get; set; }
        public string DName { get; set; }
        public string DAdress { get; set; }
        public string AddURL { get; set; }
    }
}
