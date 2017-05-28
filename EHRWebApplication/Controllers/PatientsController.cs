using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using EHRWebApplication.Models;
using Model.BLL;

namespace EHRWebApplication.Controllers
{
    public class PatientsController : Controller
    {
        private ClinicalEntities db = new ClinicalEntities();

        // GET: Patients
        public ActionResult Index()
        {
            var patients = PatientBLL.GetPatients();
            return View(patients);
        }

        // GET: Patients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var patient = PatientBLL.GetPatientById(id);

            if (patient == null)
            {
                return HttpNotFound();
            }

            return View(patient);
        }

        // GET: Patients/Create
        public ActionResult Create()
        {
            //ViewBag.UserId = new SelectList(db.Users, "Id", "UserName");
            return View(new PatientViewModel());
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Birth,sex,UserId,EHR")] PatientViewModel pa)
        {
            if (ModelState.IsValid)
            {
                Patient patient = new Patient();
                patient.FirstName = pa.FirstName;
                patient.LastName = pa.LastName;
                patient.sex = pa.Sex;
                
                bool update = PatientBLL.UpdatePatient(patient);

                if (update)
                {
                    return RedirectToAction("Index");
                }
            }

           // ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", patient.UserId);
            return View(pa);
        }

        // GET: Patients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", patient.UserId);
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Birth,sex,UserId,EHR")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", patient.UserId);
            return View(patient);
        }

        // GET: Patients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var delete = PatientBLL.DeletePatient(id);

            if (delete)
            {
                return RedirectToAction("Index");
            }

            return View("Index");
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
