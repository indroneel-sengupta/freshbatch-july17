using MVCValidationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCValidationDemo.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(UserDetails user)
        {
            if (!ModelState.IsValid)
            {
                return View("Register", user);
            }
            using (UserDetailsContext ud = new UserDetailsContext())
            {
                ud.Users.Add(user);
                ud.SaveChanges();
            }


                return View();
        }

        public ActionResult Register()
        {
            
            return View();
        }
        

        [HttpPost]
        public ActionResult DoLogin(User user)
        {
            bool flag = false;
            if(!ModelState.IsValid)
            {
                return View("Login", user);
            }
            using (UserDetailsContext udObj = new UserDetailsContext())
            {
                foreach (var ud in udObj.Users.Where((u)=> u.userName == user.userName && u.password == user.password) )
                {
                    flag = true;
                }

            }
            if(flag) return View(user);
            return View("Login", user);
        }
    }
}