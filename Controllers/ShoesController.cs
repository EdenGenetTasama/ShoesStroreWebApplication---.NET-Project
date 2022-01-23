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
            List<Shoe> listOfSaleShoe = dbTableShoes.Shoes.Where(item=> item.isOnSall == true).ToList();
            ViewBag.shesOnSale = listOfSaleShoe;
            return View();
        }

        public ActionResult ManegerTableShoe()
        {
            ViewBag.allShoesToTable = dbTableShoes.Shoes.ToList();
            return View();
        }


    }
}