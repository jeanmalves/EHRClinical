using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EHRWebApplication.Utils
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AdministradorAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (base.AuthorizeCore(httpContext))
            {
                if (HttpContext.Current.User.Identity.Name != null)
                {
                    var user = Model.BLL.UserBLL.GetUserByEmail(HttpContext.Current.User.Identity.Name);

                    if (user != null)
                    {
                        return user.RoleGroupID == (int)Model.DAO.Roles.ADMIN;
                    }
                }
            }
            
            return false;
        }
    }
}