using ShoesStroreWebApplication__.NET_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesStroreWebApplication__.NET_Project.Controllers
{
    public class ShirtsController : Controller
    {
        ShirtsContextDataContext dbCloting = new ShirtsContextDataContext();
     

        // GET: Shirts
        public ActionResult ShirtsPage()
        {
            var listOfShirts = dbCloting.clothings.GroupBy(item => item.clothingType == "Shirt");
            foreach (var shirt in listOfShirts)
            {
                ViewBag.AllShirts = shirt;

            }
        
            return View();
        }

        // GET: Shirts/Details/5
        public ActionResult MangerTableShirts()
        {
            var listOfShirts = dbCloting.clothings.GroupBy(item => item.clothingType == "Shirt");
            foreach (var shirt in listOfShirts)
            {
                ViewBag.AllShirts = shirt;

            }

            return View();
        }

        // GET: Shirts/Create
        public ActionResult GetOnlyLongShirts()
        {
            var onlyLongShorts = dbCloting.clothings.GroupBy(item => item.clothingType == "Shirt" & item.isClothingShort == false);
            foreach (var shirt in onlyLongShorts)
            {
                ViewBag.onlyLongShirt = shirt;

            }
            return View();
        }

        public ActionResult GetOnlyShortShirts()
        {
            var onlyShortShirts = dbCloting.clothings.GroupBy(item => item.clothingType == "Shirt" & item.isClothingShort == true);
            foreach (var shirt in onlyShortShirts)
            {
                ViewBag.onlyShortShirts = shirt;

            }
            return View();
        }

        public ActionResult GetOnlyDryFitShirts()
        {
            var onlyDryFitShirts = dbCloting.clothings.GroupBy(item => item.clothingType == "Shirt" & item.isClothingDrifit == true);
            foreach (var shirt in onlyDryFitShirts)
            {
                ViewBag.onlyDryFitShirts = shirt;

            }
            return View();
        }
    }
}
