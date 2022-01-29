using ShoesStroreWebApplication__.NET_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesStroreWebApplication__.NET_Project.Controllers
{
    public class MansClothingController : Controller
    {
        ShirtsContextDataContext clothingDB = new ShirtsContextDataContext();
        // GET: MansClothing
        public ActionResult onlyMansClothes()
        {
            List<clothing> onlyMansCloth = clothingDB.clothings.Where(item => item.clothingGender == "Man").ToList();
            ViewBag.MansCloth= onlyMansCloth;
            return View();
        }

        public ActionResult OnlyWomenClothes()
        {
            List<clothing> onlyMansCloth = clothingDB.clothings.Where(item => item.clothingGender == "Female").ToList();
            ViewBag.WomenCloth= onlyMansCloth;
            return View();
        }

        public ActionResult OnlyKidesClothes()
        {
            List<clothing> onlyKidsCloth = clothingDB.clothings.Where(item => item.clothingGender == "Kids").ToList();
            ViewBag.KidsCloth= onlyKidsCloth;
            return View();
        }
    }
}