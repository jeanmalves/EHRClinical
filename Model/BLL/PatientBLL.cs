using Model.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Model.BLL
{
    public static class PatientBLL
    {
        public static List<Patient> GetPatients()
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                return db.Patients.ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static  List<SourceList> GetPatientsList()
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                var patients = db.Patients.ToList();
                List<SourceList> list = new List<SourceList>();

                foreach (var item in patients)
                {
                    SourceList source = new SourceList();

                    source.Value = item.Id.ToString();
                    source.Name = item.FirstName + " " + item.LastName;

                    list.Add(source);
                }

                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Patient GetPatientById(int? patientId)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                Patient patient = db.Patients.Find(patientId);

                return patient;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Patient GetPatientByUserId(int? userId)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                Patient patient = db.Patients.FirstOrDefault(p => p.UserId == userId);

                return patient;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool AddPatient( Patient patient, User user)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var newUser = UserBLL.AddUser(user);

                patient.UserId = newUser.Id;

                db.Patients.Add(patient);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool UpdatePatient(Patient pa, User user)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var patient = db.Patients.Find(pa.Id);

                patient.FirstName = pa.FirstName;
                patient.LastName = pa.LastName;
                patient.sex = pa.sex;
                patient.Birth = pa.Birth;

                var updateUser = db.Users.Find(user.Id);

                updateUser.UserName = user.UserName;

                if (!string.IsNullOrEmpty(user.Password))
                {
                    updateUser.Password = user.Password;
                }

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeletePatient(int id)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                Patient patient = db.Patients.Find(id);
                db.Patients.Remove(patient);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
