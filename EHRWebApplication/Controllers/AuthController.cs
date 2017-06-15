﻿using EHRWebApplication.Models;
using Model.BLL;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EHRWebApplication.Controllers
{
    [Authorize]
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Auth/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View(new AuthViewModel());
        }

        // POST: /Auth/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AuthViewModel auth )
        {
            if (!ModelState.IsValid)
            {
                return View(auth);
            }
            
            User user = new User();
            user.UserName = auth.UserName;
            user.Password = auth.Password;
            user.Access = (short) auth.Role;

            user = UserBLL.Authenticate(user);

            if (user != null)
            {
                Session["user"] = user.UserName;
                Session["email"] = user.Email;
                Session["role"] = user.Access;
                Session["auth"] = "EHR_" + user.Access;
                Session["Id"] = user.Id;

                if (user.Access == (short)Roles.ADMIN)
                {
                    var features = FeatureBLL.GetFeatures()
                                             .Where(f => f.DisplayMenu == 1)
                                             .Select(f => f.name);

                    ViewBag.menuList = features;
                }

                if (user.Access == (short)Roles.PATIENT)
                {

                }

                return RedirectToAction("About", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Dados inválidos, tente novamente.");
                return View(auth);
            }
        }

        // POST: /Auth/LogOff
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Auth");
        }
    }
}
