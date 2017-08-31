using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using System.Dynamic;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private delegate void AddEmpEvent(Employee emp);

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post1Action()
        {
            return View("Index");
        }


        [HttpPut]
        public ActionResult PutAction()
        {
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteAction()
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadAction()
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionsAction()
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchAction()
        {
            return View("Index");
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string GetDate()
        {

            return DateTime.Now.ToString();
        }

        public ActionResult MyViewDemo()
        {
            

            dynamic response = new ExpandoObject();
            response.Add += new AddEmpEvent(AddEmp);
            //response.Entities = logObj.BankDetails.ToArray<BankDetail>();
            return View(response);
        }

        public void AddEmp(Employee emp)
        {
            var empObj = new EmployeeContext();
            empObj.Employees.Add(emp);
            empObj.SaveChanges();
        }
    }
}