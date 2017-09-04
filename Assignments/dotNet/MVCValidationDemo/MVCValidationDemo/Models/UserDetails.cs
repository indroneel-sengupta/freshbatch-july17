using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCValidationDemo.Models
{
    public class UserDetails
    {
        [Key]
        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public int mobNumber { get; set; }
        [Required]
        public string email { get; set; }
    }

    public class UserDetailsContext : DbContext
    {
        public DbSet<UserDetails> Users { get; set; }
    }
}