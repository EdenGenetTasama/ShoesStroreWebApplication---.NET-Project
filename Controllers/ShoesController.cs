using ShoesStroreWebApplication__.NET_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesStroreWebApplication__.NET_Project.Controllers
{
    public class ShoesController : Controller
    {

        ShoesContextDataContext dbTableShoes = new ShoesContextDataContext();
        public ActionResult ShoesPage()
        {
            ViewBag.allShoes = dbTableShoes.Shoes.ToList();
            return View();
        }
        public ActionResult ShoesOnSale()
        {
            var listOfSaleShoe = dbTableShoes.Shoes.GroupBy(item => item.isOnSall==true);
            foreach (var shoe in listOfSaleShoe)
            {
                ViewBag.shesOnSale = shoe;
          
            }

            return View();
        }

        public ActionResult ManegerTableShoe()
        {
            ViewBag.allShoesToTable = dbTableShoes.Shoes.ToList();
            return View();
        }


    }
}