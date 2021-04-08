using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VajaCodeFirst1.Models;

namespace VajaCodeFirst1.Controllers
{
    public class RačunController : Controller
    {
        private VajaCodeFirst1Context db = new VajaCodeFirst1Context();

        // GET: Račun
        public ActionResult Index()
        {
            return View(db.Račun.Include("Kupec").ToList());
        }

        // GET: Račun/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Račun račun = db.Račun.Find(id);
            if (račun == null)
            {
                return HttpNotFound();
            }
            return View(račun);
        }

        // GET: Račun/Create
        public ActionResult Create()
        {
            var x = (from a in db.Kupecs
                     select a).ToList();
            ViewBag.Kupci = new SelectList(x,"Id","ImePodjetja");
            return View();
        }

        // POST: Račun/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Vrednost,DatumIzdaje,KupecId")] Račun račun)
        {
            if (ModelState.IsValid)
            {
                db.Račun.Add(račun);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(račun);
        }

        // GET: Račun/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Račun račun = db.Račun.Find(id);
            if (račun == null)
            {
                return HttpNotFound();
            }
            return View(račun);
        }

        // POST: Račun/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Vrednost,DatumIzdaje")] Račun račun)
        {
            if (ModelState.IsValid)
            {
                db.Entry(račun).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(račun);
        }

        // GET: Račun/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Račun račun = db.Račun.Find(id);
            if (račun == null)
            {
                return HttpNotFound();
            }
            return View(račun);
        }

        // POST: Račun/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Račun račun = db.Račun.Find(id);
            db.Račun.Remove(račun);
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
