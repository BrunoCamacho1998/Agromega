﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agromega.Controllers
{
    public class ClimaController : Controller
    {
        AgroContext db = new AgroContext();
        // GET: Clima
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: Clima/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clima/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clima/Create
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

        // GET: Clima/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clima/Edit/5
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

        // GET: Clima/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clima/Delete/5
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
