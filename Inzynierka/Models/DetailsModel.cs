using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inzynierka.Models;


namespace Inzynierka.Models
{
    public class DetailsModel
    {
        public Products products { get; set; }
        public Specs specs { get; set; }
        public ICollection<Images> images { get; set; }

        public DetailsModel()
        {
            products = new Products();
            specs = new Specs();
        }
    }
}