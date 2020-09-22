using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BODojo;
using Dojo.Data;
using Dojo.Models;

namespace Dojo.Controllers
{
    public class SamouraisController : Controller
    {
        private DojoContext db = new DojoContext();

        // GET: Samourais
        public ActionResult Index()
        {
            return View(db.Samourais.ToList());
        }

        // GET: Samourais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samourai samourai = db.Samourais.Find(id);
            SamouraiVM vm = new SamouraiVM();
            vm.Samourai = samourai;
            if (samourai.Arme != null) 
            {
                vm.Samourai.Arme = db.Armes.Find(samourai.Arme.Id);
            }
            if (samourai == null)
            {
                return HttpNotFound();
            }
            return View(vm);
        }

        // GET: Samourais/Create
        public ActionResult Create()
        {
            SamouraiVM vm = new SamouraiVM();
            vm.Armes = db.Armes.ToList();
            return View(vm);
        }

        // POST: Samourais/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SamouraiVM vm)
        {
            if (ModelState.IsValid)
            {
                vm.Samourai.Arme = db.Armes.Find(vm.ArmesId);
                db.Samourais.Add(vm.Samourai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vm);
        }

        

// GET: Samourais/Edit/5
public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samourai samourai = db.Samourais.Find(id);
            if (samourai == null)
            {
                return HttpNotFound();
            }
            SamouraiVM vm = new SamouraiVM();
             vm.Samourai = samourai;
             vm.Armes = db.Armes.ToList();
            return View(vm);
        }

        // POST: Samourais/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SamouraiVM vm)
        {
            if (ModelState.IsValid)
            {
                Samourai sam = db.Samourais.Find(vm.Samourai.Id);
                sam.Force = vm.Samourai.Force;
                sam.Nom = vm.Samourai.Nom;
                if (vm.ArmesId != null) 
                {
                    sam.Arme = db.Armes.Find(vm.ArmesId);
                }
                db.Entry(sam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: Samourais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samourai samourai = db.Samourais.Find(id);
            SamouraiVM vm = new SamouraiVM();
            vm.Samourai = samourai;
            if (samourai.Arme != null)
            {
                vm.Samourai.Arme = db.Armes.Find(samourai.Arme.Id);
            }
            if (samourai == null)
            {
                return HttpNotFound();
            }
            return View(vm);
        }

        // POST: Samourais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Samourai samourai = db.Samourais.Find(id);
            db.Samourais.Remove(samourai);
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
