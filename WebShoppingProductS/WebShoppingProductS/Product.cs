using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShoppingProductS
{
    public class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int product_price { get; set; }
        public string product_mfg_date  { get; set; }
        public string product_description { get; set; }
        public string product_category { get; set; }
    }
}
