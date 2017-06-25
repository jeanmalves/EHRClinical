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
            return PartialView(features);
        }
    }
}