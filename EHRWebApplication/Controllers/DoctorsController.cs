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
    public class DoctorsController : Controller
    {
        private ClinicalEntities db = new ClinicalEntities();

        // GET: Doctors
        public ActionResult Index()
        {
            var doctors = DoctorBLL.GetDoctors();
            return View(doctors);
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int? id, bool profile = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Doctor doctor;

            if (profile)
            {
                doctor = DoctorBLL.GetDoctorByUserId(id);
            }
            else
            {
                doctor = DoctorBLL.GetDoctorById(id);
            }

            if (doctor == null)
            {
                return HttpNotFound();
            }

            DoctorDetailsViewModel doctorDetails = new DoctorDetailsViewModel();

            doctorDetails.Id = doctor.Id;
            doctorDetails.FirstName = doctor.FirstName;
            doctorDetails.LastName = doctor.LastName;
            doctorDetails.Birth = doctor.Birth;
            doctorDetails.Sex = SexDictionary.getValue(doctor.Sex);
            doctorDetails.CRMNumber = doctor.MedicId.ToString();
            doctorDetails.User = doctor.User;

            return View(doctorDetails);
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            var doctorVM = new DoctorViewModel();
            doctorVM.User = new UserViewModel();
            return View(doctorVM);
        }

        // POST: Doctors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( DoctorViewModel doctorVM, UserViewModel User)
        {
            if (ModelState.IsValid)
            {
                Doctor doctor = new Doctor();
                doctor.FirstName = doctorVM.FirstName;
                doctor.LastName = doctorVM.LastName;
                doctor.Birth = (DateTime)doctorVM.Birth;
                doctor.Sex = doctorVM.Sex;
                doctor.MedicId = doctorVM.MedicId;

                User user = new User();
                user.Email = User.Email;
                user.UserName = User.UserName;
                user.Password = User.Password;
                user.Access = (short)Roles.DOCTOR;
                user.Status = 1;

                bool create = DoctorBLL.AddDoctor(doctor, user);

                return RedirectToAction("Index");
            }

            return View(doctorVM);
        }

        // GET: Doctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var doctor = DoctorBLL.GetDoctorById(id);
            
            if (doctor == null)
            {
                return HttpNotFound();
            }

            var doctorVM = new DoctorViewModel();
            doctorVM.Id = doctor.Id;
            doctorVM.FirstName = doctor.FirstName;
            doctorVM.LastName = doctor.LastName;
            doctorVM.Birth = doctor.Birth;
            doctorVM.Sex = doctor.Sex;
            doctorVM.MedicId = doctor.MedicId;

            var userVM = new UserViewModel();
            userVM.UserName = doctor.User.UserName;
            userVM.Password = doctor.User.Password;
            userVM.Email = doctor.User.Email;
            doctorVM.User = userVM;
            
            ViewBag.sexSelected = new SelectList(SexDictionary.SexList, "Key", "Value", doctor.Sex);
            
            return View(doctorVM);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Birth,Sex,MedicId,UserId")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", doctor.UserId);
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doctor doctor = db.Doctors.Find(id);
            db.Doctors.Remove(doctor);
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
