using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EHRWebApplication.Controllers
{
    [RoutePrefix("patient/{id:int}")]
    public class PatientRecordsController : MainController
    {
        // GET: PatientRecords
        [HttpGet]
        [Route("consultas")]
        public ActionResult Index(int id)
        {
            ViewBag.id = id;
            return View();
        }

        // GET: PatientRecords/Details/5
        [Route("consultas/{recordId:int}")]
        public ActionResult Details(int id, int recordId)
        {
            ViewBag.recordId = recordId;
            ViewBag.id = id;
            return View();
        }

        
    }
}
