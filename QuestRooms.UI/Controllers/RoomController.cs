using QuestRooms.BLL.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UI.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        private readonly IRoomsService roomsService;
        public RoomController(IRoomsService _roomsService)
        {
            roomsService = _roomsService; 
        }

        public ActionResult Index()
        {
            //return View();
            return View(roomsService.GetRooms().ToList());
        }
    }
}