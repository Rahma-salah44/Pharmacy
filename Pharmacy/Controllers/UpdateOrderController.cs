using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pharmacy.Models;

namespace Pharmacy.Controllers
{
    public class UpdateOrderController : Controller
    {
        private MyDBContext db = new MyDBContext();
        // GET: UpdateOrder
        public ActionResult Index()
        {
            return View(db.orders.ToList());
        }

        // GET: UpdateOrder/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: UpdateOrder/Create
       // public ActionResult Create()
      //  {
        //    return View();
       // }

        // POST: UpdateOrder/Create
      //  [HttpPost]
      //  public ActionResult Create(FormCollection collection)
   //     {
     //try
      //      {
                // TODO: Add insert logic here

        //        return RedirectToAction("Index");
          //  }
           // catch
            //{
              //  return View();
            //}
       // }

        // GET: UpdateOrder/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: UpdateOrder/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "medicine_id,total_price,amount")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        // GET: UpdateOrder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UpdateOrder/Delete/5
        // [HttpPost]
        //    public ActionResult Delete(int id, FormCollection collection)
        //  {
        //    try
        //  {
        // TODO: Add delete logic here

        //    return RedirectToAction("Index");
        // }
        // catch
        // {
        //   return View();
        //  }
        // }
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
