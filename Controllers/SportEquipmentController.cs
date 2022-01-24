using ShoesStroreWebApplication__.NET_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesStroreWebApplication__.NET_Project.Controllers
{
    public class SportEquipmentController : Controller
    {
        SportEquipmentContextDataContext sportDb = new SportEquipmentContextDataContext();
        // GET: SportEquipment
        public ActionResult EquipmentPage()
        {
            ViewBag.allEquipment = sportDb.sportEquipments.ToList();
            return View();
        }

        public ActionResult MangerMode()
        {
            ViewBag.MangerMode = sportDb.sportEquipments.ToList();
            return View();
        }

        public ActionResult OnlyBaskBallEquipment()
        {
            List<sportEquipment> listOfBaskball = sportDb.sportEquipments.Where(item=> item.sportBranch == "Basketball").ToList();
            ViewBag.onlyBaskball = listOfBaskball;
            return View(); 

        }

        public ActionResult OnlyFootballEquipment()
        {
            List<sportEquipment> listOfFootball = sportDb.sportEquipments.Where(item => item.sportBranch == "Football").ToList();
            ViewBag.onlyFootball = listOfFootball;
            return View();

        }
        public ActionResult SortEquipment()
        {
            List<sportEquipment> listToSort = sportDb.sportEquipments.OrderBy(item=> item.productPrice).ToList();
            ViewBag.toSort = listToSort;
            return View();

        }
    }
}