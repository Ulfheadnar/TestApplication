using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JobTestProject.Models;

namespace JobTestProject.Controllers
{
    //! Controller which works with db;
    public class MyAcuaintancesController : Controller
    {
       

        private AcuaintanceContext db = new AcuaintanceContext();

        //! GET: MyAcuaintances . Return View with list of acuaintances;
        [HttpGet]   
        public ActionResult Index()
    {
        string letter = Request.Params["letter"];

        var myAcuaintances = db.MyAcuaintances.OrderBy(a => a.Name).ToList();

        if (letter == null)
        {
            return View(myAcuaintances);
        }
        if (letter != null)
        {

               var list = from item in db.MyAcuaintances where item.Name.StartsWith(letter) select item;
                myAcuaintances = list.ToList();
                 
        }
        return View(myAcuaintances);

    }
        //! POST: MyAcuaintances . Return View with list of acuaintances, which contain "name";
        [HttpPost]
        public ActionResult Index(string name)
        {
            var result = db.MyAcuaintances.Where(a => a.Name.Contains(name)).ToList();
            return View(result);
        }




        //! GET: MyAcuaintances/Details/5. Return View with Information about acuaintance;
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyAcuaintance myAcuaintance = db.MyAcuaintances.Find(id);
            if (myAcuaintance == null)
            {
                return HttpNotFound();
            }
            return View(myAcuaintance);
        }

        //! GET: MyAcuaintances/Create. Return View of creation of new acuaintance;
        public ActionResult Create()
        {
            return View();
        }

        //! POST: MyAcuaintances/Create. Add to db new acuaintance;

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Surname,Email,Phone,Description")] MyAcuaintance myAcuaintance)
        {
            if (ModelState.IsValid)
            {
                db.MyAcuaintances.Add(myAcuaintance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myAcuaintance);
        }

        //! GET: MyAcuaintances/Edit/5. return View of acuaintance edition;
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyAcuaintance myAcuaintance = db.MyAcuaintances.Find(id);
            if (myAcuaintance == null)
            {
                return HttpNotFound();
            }
            return View(myAcuaintance);
        }

        //! POST: MyAcuaintances/Edit/5. Confirm edition;

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Surname,Email,Phone,Description")] MyAcuaintance myAcuaintance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myAcuaintance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myAcuaintance);
        }

        //! GET: MyAcuaintances/Delete/5. Return View of Deleting;
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyAcuaintance myAcuaintance = db.MyAcuaintances.Find(id);
            if (myAcuaintance == null)
            {
                return HttpNotFound();
            }
            return View(myAcuaintance);
        }

        //! POST: MyAcuaintances/Delete/5. Confirm Deleting;
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyAcuaintance myAcuaintance = db.MyAcuaintances.Find(id);
            db.MyAcuaintances.Remove(myAcuaintance);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //! Free resources
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
