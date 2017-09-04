using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCValidationDemo.Models
{
    public class User
    {
        [Key]
        [Required]
        [RegularExpression(@"^[A-Za-z]{4,6}[0-9]{4,6}$",ErrorMessage ="Invalid Credentials")]
        public string userName { get; set; }

        [Required(ErrorMessage ="please enter password")]
        public string password { get; set; }
    }
}