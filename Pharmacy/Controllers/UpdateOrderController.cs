﻿using System;
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
        // GET: UpdateOrder
        public ActionResult Index()
        {
            return View();
        }

        // GET: UpdateOrder/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UpdateOrder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UpdateOrder/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UpdateOrder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UpdateOrder/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UpdateOrder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UpdateOrder/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
