using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogNew1.Context;
using BlogNew1.Models;

namespace BlogNew1.Controllers
{
    public class AdminController : Controller
    {
        private ArtykulyContext db = new ArtykulyContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Artykuly.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artykuly artykuly = db.Artykuly.Find(id);
            if (artykuly == null)
            {
                return HttpNotFound();
            }
            return View(artykuly);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tytul,Wstep,TekstArtykulu,DataDodania")] Artykuly artykuly)
        {
            if (ModelState.IsValid)
            {
                db.Artykuly.Add(artykuly);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artykuly);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artykuly artykuly = db.Artykuly.Find(id);
            if (artykuly == null)
            {
                return HttpNotFound();
            }
            return View(artykuly);
        }

        // POST: Admin/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tytul,Wstep,TekstArtykulu,DataDodania")] Artykuly artykuly)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artykuly).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artykuly);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artykuly artykuly = db.Artykuly.Find(id);
            if (artykuly == null)
            {
                return HttpNotFound();
            }
            return View(artykuly);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artykuly artykuly = db.Artykuly.Find(id);
            db.Artykuly.Remove(artykuly);
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
