using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        [HttpGet]
        public ActionResult LogIn()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult LogIn(UserAuthModel user)
        {
          return RedirectToAction("Index", "Home", user);
        }
    }
}
