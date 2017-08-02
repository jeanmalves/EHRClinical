using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EHRWebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                "patientRecord",
                "Patient/{id}/PatientRecords",
                new { controller = "PatientRecords", action = "Index"},
                new { id = @"\d+" }
            );

            routes.MapRoute(
                "patientRecordDetails",
                "Patient/{id}/PatientRecords/{recordId}",
                new { controller = "PatientRecords", action = "Details" },
                new { id = @"\d+", recordId = @"\d+" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
