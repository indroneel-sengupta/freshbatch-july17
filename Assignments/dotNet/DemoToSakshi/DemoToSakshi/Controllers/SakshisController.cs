using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoToSakshi.Models;

namespace DemoToSakshi.Controllers
{
    public class SakshisController : Controller
    {
        private DemoToSakshiContext db = new DemoToSakshiContext();

        // GET: Sakshis
        public ActionResult Index()
        {
            return View(db.Sakshis.ToList());
        }

        // GET: Sakshis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sakshi sakshi = db.Sakshis.Find(id);
            if (sakshi == null)
            {
                return HttpNotFound();
            }
            return View(sakshi);
        }

        // GET: Sakshis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sakshis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "sakId,sakName,sakAge")] Sakshi sakshi)
        {
            if (ModelState.IsValid)
            {
                db.Sakshis.Add(sakshi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sakshi);
        }

        // GET: Sakshis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sakshi sakshi = db.Sakshis.Find(id);
            if (sakshi == null)
            {
                return HttpNotFound();
            }
            return View(sakshi);
        }

        // POST: Sakshis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "sakId,sakName,sakAge")] Sakshi sakshi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sakshi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sakshi);
        }

        // GET: Sakshis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sakshi sakshi = db.Sakshis.Find(id);
            if (sakshi == null)
            {
                return HttpNotFound();
            }
            return View(sakshi);
        }

        // POST: Sakshis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sakshi sakshi = db.Sakshis.Find(id);
            db.Sakshis.Remove(sakshi);
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
