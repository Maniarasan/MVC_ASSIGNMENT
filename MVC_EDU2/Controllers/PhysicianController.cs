using System;
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

        
        SpecialityService specialitylist;
        HospitalService hospitalservice; 

      public  PhysicianController()
        {
            specialitylist = new SpecialityService();
            hospitalservice = new HospitalService();
        }
   
        // GET: /Physician/
        public ActionResult Index()
        {
            PhysicianDetails physiciandetails = new PhysicianDetails();

            ViewBag.SpecialityList = specialitylist.GetSpecialityList();
            ViewBag.HospitalList =hospitalservice.GetAllHospital();
            
            return View(physiciandetails.GetAllPhysicianDetails());
        }

   

        // GET: /Physician/Create
        public ActionResult Create()
        {
            ViewBag.SpecialityList = specialitylist.GetSpecialityList();
            ViewBag.HospitalList = hospitalservice.GetAllHospital();
                   
            return View();
        }

        // POST: /Physician/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Npi,Name,Age,Speciality,ConsultationCharges,Hospital")] Physician physician)
        {

            if (ModelState.IsValid)
            {
                NewPhysicianService newphysician = new NewPhysicianService();
                newphysician.AddPhysician(physician);

                return RedirectToAction("Index");
           
            }
            return View();
        }

        // GET: /Physician/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhysicianFindService pfs = new PhysicianFindService();

            Physician physician = pfs.FindAphysician(id);

            if (physician == null)
            {
                return HttpNotFound();
            }
            ViewBag.SpecialityList = specialitylist.GetSpecialityList();
            ViewBag.HospitalList = hospitalservice.GetAllHospital();
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
                PhysicianDetailsUpdate pdu = new PhysicianDetailsUpdate();
                pdu.UpdatePhysician(physician);

                return RedirectToAction("Index");
            }
            return View(physician);
        }

 
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PhysicianDeleteService pds = new PhysicianDeleteService();
            pds.DeletePhysician(id);

            return RedirectToAction("Index");
        }

       
    }
}
