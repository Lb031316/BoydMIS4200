using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BoydMIS4200.DAL;
using BoydMIS4200.Models;

namespace BoydMIS4200.Controllers
{
    public class VetsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Vets
        public ActionResult Index()
        {
            return View(db.vets.ToList());
        }

        // GET: Vets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vet vet = db.vets.Find(id);
            if (vet == null)
            {
                return HttpNotFound();
            }
            return View(vet);
        }

        // GET: Vets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VetID,firstName,lastName,email,phone,VetSince")] Vet vet)
        {
            if (ModelState.IsValid)
            {
                db.vets.Add(vet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vet);
        }

        // GET: Vets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vet vet = db.vets.Find(id);
            if (vet == null)
            {
                return HttpNotFound();
            }
            return View(vet);
        }

        // POST: Vets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VetID,firstName,lastName,email,phone,VetSince")] Vet vet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vet);
        }

        // GET: Vets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vet vet = db.vets.Find(id);
            if (vet == null)
            {
                return HttpNotFound();
            }
            return View(vet);
        }

        // POST: Vets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vet vet = db.vets.Find(id);
            db.vets.Remove(vet);
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
