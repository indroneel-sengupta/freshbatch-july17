using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoToNinad.Models
{
    public class Ninad
    {

        [Key]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}