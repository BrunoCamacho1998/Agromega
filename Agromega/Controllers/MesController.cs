using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agromega.Controllers
{
    public class MesController : Controller
    {
        // GET: Mes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mes/Create
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

        // GET: Mes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mes/Edit/5
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

        // GET: Mes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mes/Delete/5
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
