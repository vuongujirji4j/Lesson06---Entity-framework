using Lesson06___Entity_framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson06___Entity_framework.Controllers
{
    public class PvvCategoriesController : Controller

    {
        private static PvvBookStore pvvDb;
        public PvvCategoriesController()
        {
            pvvDb = new PvvBookStore();
        }
        // GET: PvvCategories
        public ActionResult PvvIndex()
        {
           // PvvBookStore pvvDb = new PvvBookStore();
            var pvvCategories =pvvDb.PvvCategories.ToList();
            return View(pvvCategories);
        }
        public ActionResult PvvCreate()
        {
            var pvvCategory = new PvvBookStore();
            return View(pvvCategory);
        }
        [HttpPost]
        public ActionResult PvvCreate(PvvCategory pvvCategory)
        {
           pvvDb.PvvCategories.Add(pvvCategory);
            pvvDb.SaveChanges();
            return RedirectToAction("PvvIndex");
        }
    }
}