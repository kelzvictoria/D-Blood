using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using D_Blood.Models;

namespace D_Blood.Controllers
{
    public class RegisterDonorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RegisterDonors
        public ActionResult Index(string search)
        {
            var donors = from d in db.RegisterDonors
                         select d;
            if(!String.IsNullOrEmpty(search))
            {
                donors = donors.Where(s => s.Name.Contains(search));
            }
            return View(donors);
        }

        // GET: RegisterDonors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterDonor registerDonor = db.RegisterDonors.Find(id);
            if (registerDonor == null)
            {
                return HttpNotFound();
            }
            return View(registerDonor);
        }

        // GET: RegisterDonors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterDonors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address,Occupation,Dob,Sex,Phone,State,LGA,RepPerson,BloodGroup,LastDonated")] RegisterDonor registerDonor)
        {
            if (ModelState.IsValid)
            {
                db.RegisterDonors.Add(registerDonor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registerDonor);
        }

        // GET: RegisterDonors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterDonor registerDonor = db.RegisterDonors.Find(id);
            if (registerDonor == null)
            {
                return HttpNotFound();
            }
            return View(registerDonor);
        }

        // POST: RegisterDonors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,Occupation,Dob,Sex,Phone,State,LGA,RepPerson,BloodGroup,LastDonated")] RegisterDonor registerDonor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registerDonor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registerDonor);
        }

        // GET: RegisterDonors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegisterDonor registerDonor = db.RegisterDonors.Find(id);
            if (registerDonor == null)
            {
                return HttpNotFound();
            }
            return View(registerDonor);
        }

        // POST: RegisterDonors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegisterDonor registerDonor = db.RegisterDonors.Find(id);
            db.RegisterDonors.Remove(registerDonor);
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
