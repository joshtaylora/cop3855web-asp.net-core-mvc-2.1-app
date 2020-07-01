using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cop3855web.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int ProductID { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }
    }
}
