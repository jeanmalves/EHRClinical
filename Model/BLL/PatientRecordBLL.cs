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
