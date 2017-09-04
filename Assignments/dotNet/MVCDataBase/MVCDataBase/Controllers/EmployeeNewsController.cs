using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDataBase.Models;

namespace MVCDataBase.Controllers
{
    public class EmployeeNewsController : Controller
    {
        private EmployeeNewContext db = new EmployeeNewContext();

        // GET: EmployeeNews
        public ActionResult Index()
        {
            return View(db.EmployeeNews.ToList());
        }

        // GET: EmployeeNews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeNew employeeNew = db.EmployeeNews.Find(id);
            if (employeeNew == null)
            {
                return HttpNotFound();
            }
            return View(employeeNew);
        }

        // GET: EmployeeNews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeNews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpId,Name,Sal")] EmployeeNew employeeNew)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeNews.Add(employeeNew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeNew);
        }

        // GET: EmployeeNews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeNew employeeNew = db.EmployeeNews.Find(id);
            if (employeeNew == null)
            {
                return HttpNotFound();
            }
            return View(employeeNew);
        }

        // POST: EmployeeNews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpId,Name,Sal")] EmployeeNew employeeNew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeNew).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeNew);
        }

        // GET: EmployeeNews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeNew employeeNew = db.EmployeeNews.Find(id);
            if (employeeNew == null)
            {
                return HttpNotFound();
            }
            return View(employeeNew);
        }

        // POST: EmployeeNews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeNew employeeNew = db.EmployeeNews.Find(id);
            db.EmployeeNews.Remove(employeeNew);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
