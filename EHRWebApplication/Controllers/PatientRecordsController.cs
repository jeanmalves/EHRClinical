using EHRWebApplication.Models;
using Model.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EHRWebApplication.Controllers
{
   // [RoutePrefix("patient/{id:int}")]
    public class PatientRecordsController : MainController
    {
        // GET: PatientRecords
        [HttpGet]
       // [Route("consultas")]
        public ActionResult Index(int id)
        {
            if (id > 0)
            {
                var patientRecords = PatientRecordBLL.GetPatientRecordsByPatientId(id)
                                                     .Select(pr => new PatientRecordViewModel {
                                                         Id = pr.Id,
                                                         CreatedAt = pr.CreatedAt,
                                                         Doctor = pr.Doctor.FirstName + " " + pr.Doctor.LastName,
                                                         OptName = pr.OperationalsTemplate.Name
                                                     });
                return View(patientRecords);
            }

            return View(new PatientRecordViewModel());
        }

        // GET: PatientRecords/Details/5
      //  [Route("consultas/{recordId:int}")]
        public ActionResult Details(int id, int recordId)
        {
            ViewBag.recordId = recordId;
            ViewBag.id = id;

            var patientRecord = PatientRecordBLL.GetPatientRecord(recordId);

            PatientRecordDetailsViewModel patientRecordVM = new PatientRecordDetailsViewModel();

            patientRecordVM.Id = patientRecord.Id;
            patientRecordVM.PatientId = patientRecord.PatientId;
            patientRecordVM.CreatedAt = patientRecord.CreatedAt;
            patientRecordVM.OptName = patientRecord.OperationalsTemplate.Name;
            patientRecordVM.Doctor = patientRecord.Doctor.FirstName + " " + patientRecord.Doctor.LastName;
            patientRecordVM.Data = patientRecord.Data;
           
            return View(patientRecordVM);
        }

        
    }
}
