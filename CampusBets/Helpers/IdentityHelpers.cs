using CampusBets;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace CampusBets
{
    public static class IdentityExtensions
    {
        public static string GetUserFirstName(this IIdentity identity)
        {
            var userName = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (userName != null) ? userName.FirstName : string.Empty;
        }

        public static string GetUserLastName(this IIdentity identity)
        {
            var userName = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (userName != null) ? userName.LastName : string.Empty;
        }

        public static double GetBalance(this IIdentity identity)
        {
            var userName = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>().FindById(identity.GetUserId());
            return (userName != null) ? userName.accBalance : 0;
        }
    }
}