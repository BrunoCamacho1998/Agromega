using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agromega.Controllers
{
    public class CicloLunarController : Controller
    {
        // GET: CicloLunar
        public ActionResult Index()
        {
            return View();
        }

        // GET: CicloLunar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CicloLunar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CicloLunar/Create
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

        // GET: CicloLunar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CicloLunar/Edit/5
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

        // GET: CicloLunar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CicloLunar/Delete/5
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
