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
    public class Personal_dataController : Controller
    {
        private providersEntities db = new providersEntities();

        // GET: Personal_data
        public ActionResult Index()
        {
            return View(db.personal_data.ToList());
        }

        // GET: Personal_data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personal_data personal_data = db.personal_data.Find(id);
            if (personal_data == null)
            {
                return HttpNotFound();
            }
            return View(personal_data);
        }

        // GET: Personal_data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personal_data/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,address,passport_info,birthday,sex")] personal_data personal_data)
        {
            if (ModelState.IsValid)
            {
                db.personal_data.Add(personal_data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personal_data);
        }

        // GET: Personal_data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personal_data personal_data = db.personal_data.Find(id);
            if (personal_data == null)
            {
                return HttpNotFound();
            }
            return View(personal_data);
        }

        // POST: Personal_data/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,address,passport_info,birthday,sex")] personal_data personal_data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personal_data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personal_data);
        }

        // GET: Personal_data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            personal_data personal_data = db.personal_data.Find(id);
            if (personal_data == null)
            {
                return HttpNotFound();
            }
            return View(personal_data);
        }

        // POST: Personal_data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            personal_data personal_data = db.personal_data.Find(id);
            db.personal_data.Remove(personal_data);
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
