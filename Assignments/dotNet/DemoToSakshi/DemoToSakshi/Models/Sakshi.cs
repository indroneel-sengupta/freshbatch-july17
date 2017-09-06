using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoToSakshi.Models
{
    public class Sakshi
    {
        [Key]
        public int sakId { get; set; }
        public string sakName { get; set; }
        public int sakAge { get; set; }
    }
}