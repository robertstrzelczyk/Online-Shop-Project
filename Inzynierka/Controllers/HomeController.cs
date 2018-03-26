using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Inzynierka.Models;
namespace Inzynierka.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomeIndex(string Manufacturer)
        {
            using (OnlineShopEntities db = new OnlineShopEntities())
            {

                List<Products> ProductsList = db.Products.ToList();
                ShopViewModel ShopVW = new ShopViewModel();

                List<ShopViewModel> ShopVWList = ProductsList.Select(x => new ShopViewModel
                {
                    products = x,
                    specs = x.Specs,
                    images = x.Images.FirstOrDefault()
                }).ToList();
                
                return View(ShopVWList);
            }
        }
        
    }
}