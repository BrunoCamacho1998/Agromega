using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Agromega;
using Agromega.Models;

namespace Agromega.Controllers
{
    public class ProduccionsController : Controller
    {
        private AgroContext db = new AgroContext();

        // GET: Produccions
        public ActionResult Index()
        {
            return View(db.Produccion.ToList());
        }

        // GET: Produccions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produccion produccion = db.Produccion.Find(id);
            if (produccion == null)
            {
                return HttpNotFound();
            }
            return View(produccion);
        }

        // GET: Produccions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produccions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProduccionId,NombreProducto,Clima")] Produccion produccion)
        {
            if (ModelState.IsValid)
            {
                db.Produccion.Add(produccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produccion);
        }

        // GET: Produccions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produccion produccion = db.Produccion.Find(id);
            if (produccion == null)
            {
                return HttpNotFound();
            }
            return View(produccion);
        }

        // POST: Produccions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProduccionId,NombreProducto,Clima")] Produccion produccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produccion);
        }

        // GET: Produccions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produccion produccion = db.Produccion.Find(id);
            if (produccion == null)
            {
                return HttpNotFound();
            }
            return View(produccion);
        }

        // POST: Produccions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produccion produccion = db.Produccion.Find(id);
            db.Produccion.Remove(produccion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        private void ListClima()
        {
            
            var usuarios = (from sd in db.TipoClima select sd.NombreClima).ToList();

                var listaUsuarios = new SelectList(usuarios, "TipoClimaId", "NombreClima");

                ViewData["TipoClima"] = listaUsuarios;

        }

        private void ListSuelo()
        {
            List<TipoSuelo> data = db.TipoSuelo.ToList();
            SelectList lista = new SelectList(data, "TipoSueloId", "NombreTipoSuelo");
            ViewBag.ListSuelo = lista;
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
