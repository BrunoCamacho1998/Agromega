using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agromega.Controllers
{
    public class DistritoController : Controller
    {
        // GET: Distrito
        public ActionResult Index()
        {
            return View();
        }

        // GET: Distrito/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Distrito/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Distrito/Create
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

        // GET: Distrito/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Distrito/Edit/5
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

        // GET: Distrito/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Distrito/Delete/5
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
