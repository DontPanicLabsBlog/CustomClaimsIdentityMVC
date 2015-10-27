using CustomClaimsIdentityMVC.Controllers;
using System.Web;
using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Congratulations, you're authorized!";
            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            if (IsAnonymousUser())
            {
                HttpContext.GetOwinContext().Authentication.SignOut();
                return RedirectToAction("Index");
            }

            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
