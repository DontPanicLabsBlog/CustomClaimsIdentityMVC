using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace CustomClaimsIdentityMVC.Controllers
{
    public class BaseController : Controller
    {
        protected bool IsAnonymousUser()
        {
            var claim = ((ClaimsIdentity)User.Identity).Claims.FirstOrDefault(c => c.Type == "urn:Custom:UserType");
            return claim.Value == "AnonymousUser";
        }
    }
}