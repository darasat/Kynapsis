using Kynapsis.Controllers;
using Kynapsis.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Kynapsis.Controllers
{
    public class FisioterapeutaController : Controller
    {
        private KynapsisDBContext db = new KynapsisDBContext();
        // GET: Fisioterapeuta
        public ActionResult Index()
        {
           // return View();

           // var fisioterapeuta = db.Fisioterapeuta.ToList();
            return View(db.Fisioterapeuta.ToList());
        }

        // GET: /Fisioterapeuta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fisioterapeuta fisioterapeuta = db.Fisioterapeuta.Find(id);
            if (fisioterapeuta == null)
            {
                return HttpNotFound();
            }
            return View(fisioterapeuta);

        }

        // GET: /Fisioterapeuta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Fisioterapeuta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, Documento,TipoDocumento,Nombre,Apellido,FechaNacimiento,Edad,Sexo,Direccion,Telefono,Correo")] Fisioterapeuta fisioterapeuta)
        {
            if (ModelState.IsValid)
            {
                db.Fisioterapeuta.Add(fisioterapeuta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fisioterapeuta);
        }

        // GET: /Fisioterapeuta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fisioterapeuta fisioterapeuta = db.Fisioterapeuta.Find(id);
            if (fisioterapeuta == null)
            {
                return HttpNotFound();
            }
            return View(fisioterapeuta);
        }

        // POST: /Fisioterapeuta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Documento,TipoDocumento,Nombre,Apellido,FechaNacimiento,Edad,Sexo,Direccion,Telefono,Correo")] Fisioterapeuta fisioterapeuta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fisioterapeuta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fisioterapeuta);
        }

        // GET: /Cotizacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fisioterapeuta fisioterapeuta = db.Fisioterapeuta.Find(id);
            if (fisioterapeuta == null)
            {
                return HttpNotFound();
            }
            return View(fisioterapeuta);
        }

        // POST: /Cotizacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fisioterapeuta cotizacion = db.Fisioterapeuta.Find(id);
            db.Fisioterapeuta.Remove(cotizacion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}