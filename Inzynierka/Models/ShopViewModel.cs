using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Inzynierka.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Inzynierka.Models
{
    public class ShopViewModel
    {
        //  public IList<Inzynierka.Models.Products> Products { get; set; }
        // public IList<Inzynierka.Models.Specs> Specs { get; set; }
        /*   public int ID { get; set; }
           public string Model { get; set; }
           public string Manufacturer { get; set; }
           public decimal Price { get; set; }
           public int Quantity { get; set; }
           public int Specs_ID { get; set; }



          // public int ID { get; set; }
           public string Processor { get; set; }
           public Nullable<int> RAM { get; set; }
           public Nullable<int> Max_RAM { get; set; }
           public Nullable<int> Disk_size { get; set; }
           public string Disk_type { get; set; }
           public string Display_type { get; set; }
           public Nullable<decimal> Display_size { get; set; }
           public string Resolution { get; set; }
           public string Graphics_card { get; set; }
           public string Battery { get; set; }
           public string OS { get; set; }
           public Nullable<decimal> Height { get; set; }
           public Nullable<decimal> Width { get; set; }
           public Nullable<decimal> Depth { get; set; }
           public Nullable<decimal> Weight { get; set; }
           public Nullable<int> Warranty { get; set; }

         //  public int ID { get; set; }
           public string Name { get; set; }
           public byte[] Image { get; set; }
           public int Product_ID { get; set; }
           */
        public Products products { get; set; }
        public Specs specs { get; set; }
        public Images images { get; set; }
        
      
    }

}