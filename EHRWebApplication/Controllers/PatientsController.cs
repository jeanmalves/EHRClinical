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
    [Authorize]
    public class PatientsController : MainController
    {
        private ClinicalEntities db = new ClinicalEntities();

        // GET: Patients
        [Utils.Administrador]
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
        public ActionResult Details(int? id, bool profile = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Patient patient;

            if (profile)
            {
                patient = PatientBLL.GetPatientByUserId(id);
                ViewBag.Title = "Perfil";
                ViewBag.resource = "Dados do Usuário";
            }
            else
            {
                patient = PatientBLL.GetPatientById(id);
                ViewBag.Title = "Dados do Paciente";
                ViewBag.resource = "Detalhes";
            }
            
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
        [Utils.Administrador]
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
        [Utils.Administrador]
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

            var patientVM = new PatientEditViewModel();
            patientVM.Id = patient.Id;
            patientVM.FirstName = patient.FirstName;
            patientVM.LastName = patient.LastName;
            patientVM.Sex = patient.sex;
            patientVM.Birth = patient.Birth;

            var userVM = new UserEditViewModel();
            userVM.Id = patient.User.Id;
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
        public ActionResult Edit(
          //  [Bind(Include = "Id,FirstName,LastName,Birth,sex,UserId,EHR, UserName, Email, Password")]
            PatientEditViewModel pa,
            UserEditViewModel User)
        {
            if (ModelState.IsValid)
            {
                pa.User = User;

                Patient patient = new Patient();

                patient.Id = pa.Id;
                patient.FirstName = pa.FirstName;
                patient.LastName = pa.LastName;
                patient.sex = pa.Sex;
                patient.Birth = (DateTime)pa.Birth;

                User user = new User();

                user.Id = User.Id;
                user.Email = User.Email;
                user.UserName = User.UserName;
                user.Password = User.Password;


                var updated = PatientBLL.UpdatePatient(patient, user);

                if (updated)
                {
                    return RedirectToAction("Details", new { id = patient.Id });
                }
            }

            ViewBag.sexSelected = new SelectList(SexDictionary.SexList, "Key", "Value", pa.Sex);
            return View(pa);
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
