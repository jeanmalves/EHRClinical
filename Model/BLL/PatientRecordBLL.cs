using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BLL
{
    public class PatientRecordBLL
    {
        public static PatientRecord GetPatientRecord(int id)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var patientRecord = db.PatientRecords.Find(id);

                return patientRecord;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static PatientRecord GetPatientRecordByPatientId(int? patientId)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var patientRecord = db.PatientRecords.FirstOrDefault(p => p.PatientId == patientId);

                return patientRecord;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<PatientRecord> GetPatientRecordsByPatientId(int? patientId)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var patientRecords = db.PatientRecords
                                      .Where(p => p.PatientId == patientId)
                                      .ToList();

                return patientRecords;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<PatientRecord> GetPatientRecordsByDoctorId(int? doctorId)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var patientRecords = db.PatientRecords
                                      .Where(p => p.DoctorId == doctorId)
                                      .ToList();

                return patientRecords;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static PatientRecord AddPatientRecord(PatientRecord patientRecord)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                patientRecord = db.PatientRecords.Add(patientRecord);
                db.SaveChanges();

                return patientRecord;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
