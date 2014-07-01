using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTestEngineBL;

namespace OnlineTestEngine.Controllers
{
    public class DashboardController : Controller
    {
        OTEBLClass objOTEBL = new OTEBLClass();
        //
        // GET: /Dashboard/
        public ActionResult Index(string returnUrl)
        {

            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Admin"))
                {
                    ViewBag.Role = "Admin";

                    return View();
                }
            }
            return RedirectToLocal(returnUrl);
        }
        [ValidateAntiForgeryToken]
        public ActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateStudent()
        {
         
            if (ModelState.IsValid)
            {
                if (User.Identity.IsAuthenticated)
                {
                    
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}