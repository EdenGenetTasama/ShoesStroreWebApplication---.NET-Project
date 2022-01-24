using ShoesStroreWebApplication__.NET_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesStroreWebApplication__.NET_Project.Controllers
{
    public class PantsController : Controller
    {
        ShirtsContextDataContext dbCloting = new ShirtsContextDataContext();

        // GET: Pants
        public ActionResult ShowPantsall()
        {
            List<clothing> listOfPants = dbCloting.clothings.Where(item => item.clothingType == "Pants").ToList();
            ViewBag.AllPants = listOfPants;
            return View();
        }

        public ActionResult MangerTable()
        {
            List<clothing> listOfPantsToTable = dbCloting.clothings.Where(item => item.clothingType == "Pants").ToList();
          
                ViewBag.AllPantsToTable = listOfPantsToTable;
                return View();


        }

        public ActionResult OnlyLongPants()
        {
            List<clothing> onlyLongPants = dbCloting.clothings.Where(item => item.clothingType == "Pants" & item.isClothingShort == false).ToList();
          
            ViewBag.onlyLongPants = onlyLongPants;
           
            return View();
      

        }
        public ActionResult OnlyShortsPants()
        {
            List<clothing> onlyPantsShirts = dbCloting.clothings.Where(item => item.clothingType == "Pants" & item.isClothingShort == true).ToList();

            ViewBag.onlyShortPants= onlyPantsShirts;
            return View();
           
            //return Content("<script language='javascript' type='text/javascript'>alert('Sorry item not found, Going to all pants');</script>");
            //return RedirectToAction("ShowPantsall") ;


        }

        public ActionResult GetOnlyDryFitPants()

        {
            List<clothing> onlyDryFitPants = dbCloting.clothings.Where(item => item.clothingType == "Pants" & item.isClothingDrifit == true).ToList();
          
             ViewBag.onlyDryFitPants = onlyDryFitPants;
            return View();
        
        }

        public ActionResult SortByPricePants()
        {
            List<clothing> listOfShirts = dbCloting.clothings.Where(item => item.clothingType == "Pants").OrderBy(clothe => clothe.clothingPrice).ToList();
           
            ViewBag.sortByPrice = listOfShirts;
            return View();

            //return RedirectToAction("ShowPantsall");

        }


    }
}