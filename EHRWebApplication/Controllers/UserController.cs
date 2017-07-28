using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EHRWebApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public RedirectToRouteResult profile()
        {
            if (Session["role"] != null)
            {
                var role = Convert.ToInt32(Session["role"]);
                int id = 0;

                if (role == (int) Roles.PATIENT)
                {
                    id = Convert.ToInt32(Session["Id"]);
                    return RedirectToAction("Details", "Patients", new { id = id, profile = true });
                }

                if (role == (int)Roles.DOCTOR)
                {
                    id = Convert.ToInt32(Session["Id"]);
                    return RedirectToAction("Details", "Doctors", new { id = id, profile = true });
                }
                
                id = Convert.ToInt32(Session["Id"]);

                return RedirectToAction("Details", id);
            }

            return RedirectToAction("Login", "Auth");
        }
    }
}
