using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProvidersApp.Models;

namespace ProvidersApp.Controllers
{
    public class TariffsController : Controller
    {
        private providersEntities db = new providersEntities();

        // GET: Tariffs
        public ActionResult Index()
        {
            return View(db.tariffs.ToList());
        }

        // GET: Tariffs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tariffs tariffs = db.tariffs.Find(id);
            if (tariffs == null)
            {
                return HttpNotFound();
            }
            return View(tariffs);
        }

        // GET: Tariffs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tariffs/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,minute_number,sms_number,price")] tariffs tariffs)
        {
            if (ModelState.IsValid)
            {
                db.tariffs.Add(tariffs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tariffs);
        }

        // GET: Tariffs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tariffs tariffs = db.tariffs.Find(id);
            if (tariffs == null)
            {
                return HttpNotFound();
            }
            return View(tariffs);
        }

        // POST: Tariffs/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,minute_number,sms_number,price")] tariffs tariffs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tariffs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tariffs);
        }

        // GET: Tariffs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tariffs tariffs = db.tariffs.Find(id);
            if (tariffs == null)
            {
                return HttpNotFound();
            }
            return View(tariffs);
        }

        // POST: Tariffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tariffs tariffs = db.tariffs.Find(id);
            db.tariffs.Remove(tariffs);
            db.SaveChanges();
            return RedirectToAction("Index");
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
