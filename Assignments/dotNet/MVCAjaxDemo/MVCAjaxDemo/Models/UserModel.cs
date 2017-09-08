using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAjaxDemo.Models
{
    public class UserModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string  name { get; set; }
        [Required]
        public string userCity { get; set; }
    }

    public class UserModelContext : DbContext
    {
        public DbSet<UserModel> UserModels { get; set;}
    }
}