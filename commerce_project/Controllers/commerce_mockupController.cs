using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using commerce_project.Models;

namespace commerce_project.Controllers
{
    public class commerce_mockupController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: commerce_mockup
        public ActionResult Index()
        {
            return View(db.commerce_mockup.ToList());
        }

        // GET: commerce_mockup/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            commerce_mockup commerce_mockup = db.commerce_mockup.Find(id);
            if (commerce_mockup == null)
            {
                return HttpNotFound();
            }
            return View(commerce_mockup);
        }

        // GET: commerce_mockup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: commerce_mockup/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] commerce_mockup commerce_mockup)
        {
            if (ModelState.IsValid)
            {
                db.commerce_mockup.Add(commerce_mockup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(commerce_mockup);
        }

        // GET: commerce_mockup/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            commerce_mockup commerce_mockup = db.commerce_mockup.Find(id);
            if (commerce_mockup == null)
            {
                return HttpNotFound();
            }
            return View(commerce_mockup);
        }

        // POST: commerce_mockup/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] commerce_mockup commerce_mockup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(commerce_mockup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(commerce_mockup);
        }

        // GET: commerce_mockup/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            commerce_mockup commerce_mockup = db.commerce_mockup.Find(id);
            if (commerce_mockup == null)
            {
                return HttpNotFound();
            }
            return View(commerce_mockup);
        }

        // POST: commerce_mockup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            commerce_mockup commerce_mockup = db.commerce_mockup.Find(id);
            db.commerce_mockup.Remove(commerce_mockup);
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
