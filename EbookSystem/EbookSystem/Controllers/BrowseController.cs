using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EbookSystem.Models;

namespace EbookSystem.Controllers
{
    public class BrowseController : Controller
    {

        private SellDBContext db = new SellDBContext();
        //
        // GET: /Browse/

        public ActionResult Index()
        {
            return View(db.Sell.ToList());
        }

        public ActionResult SearchIndex(string searchString)
        {
            var books  = from m in db.Sell
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Title.Contains(searchString));
            }

            return View(books);
        }
        public ActionResult Details(int id = 0)
        {
            Sell sell = db.Sell.Find(id);
            if (sell == null)
            {
                return HttpNotFound();
            }
            return View(sell);
        }
        public ActionResult Comment()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Comment(Sell sell, int id = 0)
        {
            if (ModelState.IsValid)
            {
                Sell sell1 = db.Sell.Find(id);
                if (sell1 == null)
                {
                    return HttpNotFound();
                }

                db.Entry(sell1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sell);
        }
    }
}
