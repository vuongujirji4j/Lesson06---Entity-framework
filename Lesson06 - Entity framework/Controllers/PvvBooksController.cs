using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson06___Entity_framework.Models;

namespace Lesson06___Entity_framework.Controllers
{
    public class PvvBooksController : Controller
    {
        private PvvBookStore db = new PvvBookStore();

        // GET: PvvBooks
        public ActionResult Index()
        {
            return View(db.PvvBooks.ToList());
        }

        // GET: PvvBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PvvBook pvvBook = db.PvvBooks.Find(id);
            if (pvvBook == null)
            {
                return HttpNotFound();
            }
            return View(pvvBook);
        }

        // GET: PvvBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PvvBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PvvId,PvvBookId,PvvTitle,PvvAuthor,PvvYear,PvvPulisher,PvvPicture,PvvCategoryId")] PvvBook pvvBook)
        {
            if (ModelState.IsValid)
            {
                db.PvvBooks.Add(pvvBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pvvBook);
        }

        // GET: PvvBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PvvBook pvvBook = db.PvvBooks.Find(id);
            if (pvvBook == null)
            {
                return HttpNotFound();
            }
            return View(pvvBook);
        }

        // POST: PvvBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PvvId,PvvBookId,PvvTitle,PvvAuthor,PvvYear,PvvPulisher,PvvPicture,PvvCategoryId")] PvvBook pvvBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pvvBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pvvBook);
        }

        // GET: PvvBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PvvBook pvvBook = db.PvvBooks.Find(id);
            if (pvvBook == null)
            {
                return HttpNotFound();
            }
            return View(pvvBook);
        }

        // POST: PvvBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PvvBook pvvBook = db.PvvBooks.Find(id);
            db.PvvBooks.Remove(pvvBook);
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
