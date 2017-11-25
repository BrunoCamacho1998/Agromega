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
using System.Threading.Tasks;
using Agromega.Services;

namespace Agromega.Controllers
{
    public class ProduccionsController : Controller
    {
        private AgroContext db = new AgroContext();
        IProduccionServices prodser;
        public class Mymodel
        {
            public IEnumerable<string> NomProd { get; set; }
        }
        
        public ProduccionsController()
        {
            prodser = new ProduccionServices();
        }

        // GET: Produccions
        [HttpGet]
        public ActionResult Index()
        {
            
            using (var contextoBd = new AgroContext())
            {
                var Tipocultivo = (from sd in contextoBd.TipoCultivo
                                 select new
                                 {
                                     sd.CultivoId,
                                     sd.NombreCultivo
                                 }).ToList();
                var listacultivo = new SelectList(Tipocultivo.OrderBy(o => o.CultivoId), "CultivoId", "NombreCultivo");
                ViewData["TipoCultivo"] = listacultivo;

                var Tiposuelo = (from sd in contextoBd.TipoSuelo
                                 select new
                                 {
                                     sd.TipoSueloId,
                                     sd.NombreTipoSuelo
                                 }).ToList();
                var listaSuelo = new SelectList(Tiposuelo.OrderBy(o => o.TipoSueloId), "TipoSueloId", "NombreTipoSuelo");
                ViewData["TipoSuelo"] = listaSuelo;

            }
            
            var query = db.Produccion
                    .Include("TipoClima")
                    .Include("TipoSuelo")
                    .Include("Cultivo");
            return View(query.ToList());
        }

        [HttpPost]
        public ActionResult Index(string TipoSuelo, string Cultivo)
        {
            var Tipocultivo = (from sd in db.TipoCultivo
                               select new
                               {
                                   sd.CultivoId,
                                   sd.NombreCultivo
                               }).ToList();
            var listacultivo = new SelectList(Tipocultivo.OrderBy(o => o.CultivoId), "CultivoId", "NombreCultivo", Cultivo);
            ViewData["TipoCultivo"] = listacultivo;

            var Tiposuelo = (from sd in db.TipoSuelo
                             select new
                             {
                                 sd.TipoSueloId,
                                 sd.NombreTipoSuelo
                             }).ToList();
            var listaSuelo = new SelectList(Tiposuelo.OrderBy(o => o.TipoSueloId), "TipoSueloId", "NombreTipoSuelo", TipoSuelo);
            ViewData["TipoSuelo"] = listaSuelo;
            
            int cul = Convert.ToInt32(Cultivo);
            int sl = Convert.ToInt32(TipoSuelo);
            var query = db.Produccion
                .Where(x=>x.TipoSuelo.TipoSueloId==sl)
                .Where(x => x.Cultivo.CultivoId == cul)
                .Include("TipoClima")
                .Include("TipoSuelo")
                .Include("Cultivo");
            return View(query.ToList());
        }
        // GET: Produccions/Details/5
        [HttpGet]
        
        public ActionResult Details(int? id)
        {
            var producto = db.Produccion.Find(id);
            ViewBag.prod = producto.NombreProducto;

            var query = db.Precio_Actual
                .Include("Produccion")
                .Where(x => x.ProduccionId == id);
            return View(query.ToList());
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
        //private void ListClima()
        //{

        //    List<TipoClima> usuarios = db.TipoClima.ToList();

        //    var listaUsuarios = new SelectList(usuarios, "TipoClimaId", "NombreClima");

        //    ViewData["TipoClima"] = listaUsuarios;

        //}

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
