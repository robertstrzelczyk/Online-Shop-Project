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
    public class CurrentItemController : Controller
    {
        // GET: CurrentItem
        public ActionResult CurrentItemIndex(int? id)
        {
            
            using (OnlineShopEntities db = new OnlineShopEntities())
            {          
                DetailsModel elo = new DetailsModel();
                elo.products= db.Products.Find(id);
                elo.specs = db.Products.Find(id).Specs;
                elo.images = db.Products.Find(id).Images;
                return View(elo);
            }
        }
    }
}