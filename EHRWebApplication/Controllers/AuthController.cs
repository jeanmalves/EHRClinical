using EHRWebApplication.Models;
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
    public class AuthController : MainController
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
            user.RoleGroupID = (short) auth.Role;

            user = UserBLL.Authenticate(user);

            if (user != null)
            {
                Session["user"] = user.UserName;
                Session["role"] = user.RolesGroup.Id;
                Session["auth"] = "EHR_" + user.RolesGroup.Id;
                Session["Id"] = user.Id;

                System.Web.Security.FormsAuthentication.SetAuthCookie(user.Email, false);
                
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Dados inválidos, tente novamente.");
                return View(auth);
            }
        }

        // POST: /Auth/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Auth");
        }
    }
}
