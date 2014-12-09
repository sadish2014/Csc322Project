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
    public class SellController : Controller
    {
        private SellDBContext db = new SellDBContext();

        //
        // GET: /Sell/

        public ActionResult Index()
        {
            return View(db.Sell.ToList());
        }

        //
        // GET: /Sell/Details/5

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
        //
        // GET: /Sell/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Sell/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sell sell)
        {
            if (ModelState.IsValid)
            {
                db.Sell.Add(sell);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sell);
        }

        //
        // GET: /Sell/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Sell sell = db.Sell.Find(id);
            if (sell == null)
            {
                return HttpNotFound();
            }
            return View(sell);
        }

        //
        // POST: /Sell/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sell sell)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sell).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sell);
        }

        //
        // GET: /Sell/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Sell sell = db.Sell.Find(id);
            if (sell == null)
            {
                return HttpNotFound();
            }
            return View(sell);
        }

        //
        // POST: /Sell/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sell sell = db.Sell.Find(id);
            db.Sell.Remove(sell);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}