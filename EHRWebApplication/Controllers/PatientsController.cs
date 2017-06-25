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
    public class PatientsController : MainController
    {
        private ClinicalEntities db = new ClinicalEntities();

        // GET: Patients
        public ActionResult Index()
        {
            var patients = PatientBLL.GetPatients()
                .Select(l => new PatientDetailsViewModel
                {
                    Id = l.Id,
                    FirstName = l.FirstName,
                    LastName = l.LastName,
                    Birth = l.Birth,
                    Sex = SexDictionary.getValue(l.sex),
                    EhrNumber = l.EHR.ToString()
                });

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

            PatientDetailsViewModel patientViewModel = new PatientDetailsViewModel();

            patientViewModel.Id = patient.Id;
            patientViewModel.FirstName = patient.FirstName;
            patientViewModel.LastName = patient.LastName;
            patientViewModel.Birth = patient.Birth;
            patientViewModel.Sex = SexDictionary.getValue(patient.sex);
            patientViewModel.EhrNumber = patient.EHR.ToString();
            patientViewModel.User = patient.User;

            return View(patientViewModel);
        }

        // GET: Patients/Create
        public ActionResult Create()
        {
            var patientVM = new PatientViewModel();
            patientVM.User = new UserViewModel();

            return View(patientVM);
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PatientViewModel pa, UserViewModel User)
        {
            if (ModelState.IsValid)
            {
                Patient patient = new Patient();

                patient.FirstName = pa.FirstName;
                patient.LastName = pa.LastName;
                patient.sex = pa.Sex;
                patient.Birth = (DateTime) pa.Birth;

                User user = new User();
                user.Email = User.Email;
                user.UserName = User.UserName;
                user.Password = User.Password;
                user.RoleGroupID = (short) Roles.PATIENT;
                user.Status = 1;

                bool create = PatientBLL.AddPatient(patient, user);

                if (create)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(pa);
        }

        // GET: Patients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Patient patient = PatientBLL.GetPatientById(id);

            if (patient == null)
            {
                return HttpNotFound();
            }

            PatientViewModel patientVM = new PatientViewModel();
            patientVM.FirstName = patient.FirstName;
            patientVM.LastName = patient.LastName;
            patientVM.Sex = patient.sex;
            patientVM.Birth = patient.Birth;

            var userVM = new UserViewModel();
            userVM.UserName = patient.User.UserName;
            userVM.Password = patient.User.Password;
            userVM.Email = patient.User.Email;
            patientVM.User = userVM;

            ViewBag.sexSelected = new SelectList(SexDictionary.SexList, "Key", "Value", patientVM.Sex);
            
            return View(patientVM);
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
