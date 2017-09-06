using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoToNinad.Models;

namespace DemoToNinad.Controllers
{
    public class NinadsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ninads
        public ActionResult Index()
        {
            return View(db.Ninads.ToList());
        }

        // GET: Ninads/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ninad ninad = db.Ninads.Find(id);
            if (ninad == null)
            {
                return HttpNotFound();
            }
            return View(ninad);
        }

        // GET: Ninads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ninads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Id")] Ninad ninad)
        {
            if (ModelState.IsValid)
            {
                db.Ninads.Add(ninad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ninad);
        }

        // GET: Ninads/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ninad ninad = db.Ninads.Find(id);
            if (ninad == null)
            {
                return HttpNotFound();
            }
            return View(ninad);
        }

        // POST: Ninads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Id")] Ninad ninad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ninad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ninad);
        }

        // GET: Ninads/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ninad ninad = db.Ninads.Find(id);
            if (ninad == null)
            {
                return HttpNotFound();
            }
            return View(ninad);
        }

        // POST: Ninads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ninad ninad = db.Ninads.Find(id);
            db.Ninads.Remove(ninad);
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
