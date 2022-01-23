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
            List<clothing> listOfShirts = dbCloting.clothings.Where(item => item.clothingType == "Shirt").ToList();
            ViewBag.AllShirts = listOfShirts;
            return View();
        }

        // GET: Shirts/Details/5
        public ActionResult MangerTableShirts()
        {
            List<clothing> listOfShirtsToTable = dbCloting.clothings.Where(item => item.clothingType == "Shirt").ToList();
                ViewBag.AllShirtsToTable = listOfShirtsToTable;
            return View();
        }

        // GET: Shirts/Create
        public ActionResult GetOnlyLongShirts()
        {
            List<clothing> onlyLongShorts = dbCloting.clothings.Where(item => item.clothingType == "Shirt" & item.isClothingShort == false).ToList();
                ViewBag.onlyLongShirt = onlyLongShorts;
            return View();
        }

        public ActionResult GetOnlyShortShirts()
        {
            List<clothing> onlyShortShirts = dbCloting.clothings.Where(item => item.clothingType == "Shirt" & item.isClothingShort == true).ToList();
            ViewBag.onlyShortShirts = onlyShortShirts;
            return View();
        }

        public ActionResult GetOnlyDryFitShirts()
        {
            List<clothing> onlyDryFitShirts = dbCloting.clothings.Where(item => item.clothingType == "Shirt" & item.isClothingDrifit == true).ToList();
                ViewBag.onlyDryFitShirts = onlyDryFitShirts;
            return View();
        }

        public ActionResult SortByPrice()
        {
            List<clothing> listOfShirts = dbCloting.clothings.Where(item => item.clothingType == "Shirt").OrderBy(clothe => clothe.clothingPrice).ToList();
            ViewBag.sortByPrice = listOfShirts;
            return View();
        }
    }
}
