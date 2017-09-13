using Model.BLL;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EHRWebApplication.Controllers
{
    public class UserController : MainController
    {
        // GET: User
        public ActionResult Index()
        {
            return HttpNotFound("Funcionalidade não implementada.");
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            //var user = new User();

            //if (id > 0)
            //{
            //    user = UserBLL.GetUserById(id);
            //    return View(user);
            //}

            return RedirectToAction("Index");
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");
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

                return RedirectToAction("Details", new { id = id });
            }

            return RedirectToAction("Login", "Auth");
        }
    }
}
