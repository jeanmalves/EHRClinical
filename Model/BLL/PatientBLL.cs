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

        public static bool AddPatient( Patient patient)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                db.Patients.Add(patient);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool UpdatePatient(Patient patient)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                db.Entry(patient).State = EntityState.Modified;
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
