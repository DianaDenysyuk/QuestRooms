using QuestRooms.BLL.Services.Abstraction;
using QuestRooms.BLL.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UI.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        private readonly ICitiesService citiesService;
        //public TestController()
        //{
        //    citiesService = new CitiesService _citiesService; 
        //}
        public ActionResult Index()
        {
            return View();
        }
    }
}