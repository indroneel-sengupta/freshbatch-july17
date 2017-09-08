using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAjaxDemo.Models
{
    public class UserBinder
    {
        public UserModel user { get; set; }
        public List<UserModel> users { get; set; }
    }
}