using Model.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EHRWebApplication.Controllers
{
    public class MainController : Controller
    {
        [ChildActionOnly]
        public ActionResult _MenuPartial()
        {
            int role = (int)Session["role"];
            var features = FeatureBLL.GetFeaturesByRole(role);

            if (role == (int) Model.DAO.Roles.PATIENT)
            {
                int userId = (int)Session["Id"];
                var patient = PatientBLL.GetPatientByUserId(userId);
                ViewBag.Patient = patient.Id;
            }
           
            return PartialView(features);
        }
    }
}