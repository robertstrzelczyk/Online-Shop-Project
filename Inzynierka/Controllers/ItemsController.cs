using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Inzynierka.Models;

namespace Inzynierka.Controllers
{ 
    public class ItemsController : Controller
    {
       
        // GET: Items
        public ActionResult ItemsIndex(string Manufacturer)
        {
            using (OnlineShopEntities db = new OnlineShopEntities())
            {
                
                List<Products> ProductsList = db.Products.Where(x => x.Manufacturer == Manufacturer).ToList();
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
        public ActionResult ItemsCattegory(string Manufacturer)
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

             /*   ShopViewModel elo = new ShopViewModel();
                elo.products = db.Products.Where(x => x.Manufacturer == Manufacturer);
                  elo.specs = db.Products.Where(x => x.Manufacturer == Manufacturer);
                  elo.images = db.Products.Find(Manufacturer).Images.FirstOrDefault();
                db.Products.Where(x => x.Manufacturer == Manufacturer);
                // elo.products = db.Products.Find(Manufacturer); */
                return View(ShopVWList.Where(x => x.products.Manufacturer == Manufacturer));
            }
        }

    }
}