using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShoppingProductS
{
    public class dbProduct
    {
        public static List<Product> GetProduct()

{

            List<Product> ProductList = new List<Product>()

{

new Product(){product_id=0, product_name="Apple Iphone 13 pro max", product_price = 140000 ,product_description="Pro camera system with new 12MP Telephoto, Wide and Ultra Wide cameras; LiDAR Scanner; 6x optical zoom range; macro photography; Photographic Styles, ProRes video, Smart HDR 4, Night mode, Apple ProRAW, 4K Dolby Vision HDR recording",product_category="Mobile"},

new Product(){product_id=1, product_name="HP ELITEBOOK", product_price =100000,product_description=" Windows 10 Home Single Language 64  Ram 16 GB 1TB sSd",product_category="Laptop"},

new Product(){product_id=2, product_name="Samsung Fridge 20", product_price =30000,product_description="Samsung 676 L Side by Side Refrigerator (RS74R5101SL, Silver)",product_category="Fridge"},

new Product(){product_id=3, product_name="OnePlus TV Version3", product_price = 45000 ,product_description="OnePlus 108 cm (43 inches) Y Series 4K Ultra HD Smart Android LED TV 43Y1S Pro (Black) (2022 Model)",product_category="TV"},

new Product(){product_id=4, product_name="Wirlpool Washing Machine 6th sens", product_price = 32000,product_description="Whirlpool 7.5 Kg 5 Star Fully-Automatic Top Loading Washing Machine with In-Built Heater (360 BLOOMWASH PRO (540) H 7.5, Graphite, Hexa Bloom Impeller)",product_category="Washing Macine"},

new Product(){product_id=5, product_name="Lenovo laptop 330", product_price = 52000,product_description="Lenovo Ideapad 3 AMD Ryzen 5 5500U 15.6 FHD Thin & Light Laptop (8GB/512GB SSD/Windows 11/Office 2021/Backlit Keyboard/2Yr Warranty/Arctic Grey/1.65Kg), 82KU017KIN",product_category="Laptop"}

};

            return ProductList;

        }
    }
}
