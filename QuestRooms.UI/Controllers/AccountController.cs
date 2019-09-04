using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using QuestRooms.DAL.Entities;
using QuestRooms.UI.App_Start;
using QuestRooms.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.ModelBinding;
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


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginVM model)
        {
            //var user = new AppUser { Email = model.Login, UserName = model.Login };
            var res = UserManager.Find(model.Login, model.Password);
            if (res != null)
            {
                ClaimsIdentity claim = UserManager.CreateIdentity(res,
                                    DefaultAuthenticationTypes.ApplicationCookie);
                AuthenticationManager.SignOut();
                AuthenticationManager.SignIn(new AuthenticationProperties
                {
                    IsPersistent = true
                }, claim);
                return RedirectToAction("Index", "Room");
            }
            //ModelState.AddModelError("", "User not exist");
            ViewBag.Error = "User not exist";
            return View();
        }

        [HttpPost]
        public ActionResult LogOut(UserLoginVM model)
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Index", "Room");
        }


    }
}