using QuestRooms.BLL.Services.Abstraction;
using QuestRooms.BLL.Services.Implementation;
using QuestRooms.UI.Models;
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
        public TestController(ICitiesService _citiesService)
        {
            citiesService = _citiesService;
        }
        public ActionResult Index()
        {
            return View(citiesService.GetCities().Select(t=>new CityViewModel() {Id=t.Id, Name=t.Name }));
        }
    }
}