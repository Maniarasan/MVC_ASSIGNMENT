﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_EDU2;
using MVC_EDU2.Services;

namespace MVC_EDU2.Controllers
{
    public class PhysicianController : Controller
    {
        private HospitalEntities db = new HospitalEntities();

        // GET: /Physician/
        public ActionResult Index()
        {
            PhysicianDetails physiciandetails = new PhysicianDetails();
            return View(physiciandetails.GetAllPhysicianDetails());
        }

        // GET: /Physician/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Physician physician = db.Physicians.Find(id);
            if (physician == null)
            {
                return HttpNotFound();
            }
            return View(physician);
        }

        // GET: /Physician/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Physician/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="id,Npi,Name,Age,Speciality,ConsultationCharges,Hospital")] Physician physician)
        {
            if (ModelState.IsValid)
            {
                db.Physicians.Add(physician);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(physician);
        }

        // GET: /Physician/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Physician physician = db.Physicians.Find(id);
            if (physician == null)
            {
                return HttpNotFound();
            }
            return View(physician);
        }

        // POST: /Physician/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="id,Npi,Name,Age,Speciality,ConsultationCharges,Hospital")] Physician physician)
        {
            if (ModelState.IsValid)
            {
                db.Entry(physician).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(physician);
        }

        // GET: /Physician/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Physician physician = db.Physicians.Find(id);
        //    if (physician == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(physician);
        //}

        // POST: /Physician/Delete/5
        [ActionName("Delete")]
     //   [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Physician physician = db.Physicians.Find(id);
            db.Physicians.Remove(physician);
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