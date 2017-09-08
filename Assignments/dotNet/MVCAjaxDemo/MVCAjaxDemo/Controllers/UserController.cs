using MVCAjaxDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAjaxDemo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
       

        public ActionResult Index(UserBinder userInsert)
        {
            using (var user  = new UserModelContext())
            {
                UserModel um = userInsert.user;
                user.UserModels.Add(um);
                user.SaveChanges();
               
            }
            return RedirectToAction("Insert");
        }

        public ActionResult Insert()
        {
            List<UserModel> userList = new List<UserModel>();
            using (var users = new UserModelContext())
            {
                userList = users.UserModels.ToList();
                
            }
                
                //return View(new UserBinder() { users = usersList });
                return View(new UserBinder() { users = userList});
        }
        [HttpPost]
        public ActionResult Insert(UserBinder user)
        {
            List<UserModel> userList = new List<UserModel>();
            using (var users = new UserModelContext())
            {
                userList = users.UserModels.Where(u=>u.Id == user.user.Id).ToList();

            }

            //return View(new UserBinder() { users = usersList });
            return View(new UserBinder() { users = userList });
        }
        public ActionResult Search(UserBinder ub)
        {
            int ub1 = ub.user.Id;
            return View("Insert",ub);
        }
        public ActionResult GetSearchedUser(int ident)
        {
            int id = /*Convert.ToInt32(*/ident/*)*/;
            List<UserModel> userList = new List<UserModel>();
            using (var users = new UserModelContext())
            {
                userList = users.UserModels.Where(u=>u.Id == id).ToList();

            }
            return Json(userList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAllUsers()
        {
            List<UserModel> userList = new List<UserModel>();
            using (var users = new UserModelContext())
            {
                userList = users.UserModels.ToList();

            }
            return Json(userList,JsonRequestBehavior.AllowGet);
        }
    }
}