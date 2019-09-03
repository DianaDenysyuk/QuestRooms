using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using QuestRooms.DAL.Entities;
using QuestRooms.UI.App_Start;
using QuestRooms.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UI.Controllers
{
    public class AccountController : Controller
    {
        private AppUserManager _userManager;
        public AppUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        public AccountController()
        {
            //userManager = HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            //AuthenticationManager = HttpContext.GetOwinContext().Authentication;
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserRegisterVM model)
        {
            var user = new AppUser { Email = model.Login, UserName = model.Login };
            var res = UserManager.Create(user, model.Password);
            if (res.Succeeded)
            {
                return RedirectToAction("Index","Room");
            }

            ViewBag.Error = res.Errors;
            return View();
        }

    }
}