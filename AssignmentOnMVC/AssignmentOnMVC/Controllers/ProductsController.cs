using AssignmentOnMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace AssignmentOnMVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
public ActionResult Index()
        {
            var products = GetProducts();

            return View(products);
        }

        private IEnumerable<ProductDetails> GetProducts()
        {
            return new List<ProductDetails>
            {
                new ProductDetails{ProductId = 101 , ProductName="AC",ProductRate=45000},
                new ProductDetails{ProductId = 102 , ProductName="Mobile",ProductRate=38000},
              new ProductDetails{ProductId = 103 , ProductName="Bike",ProductRate=94000}
            };
        }



        public ActionResult ProductDetail(int id)
        {
            var products = GetProducts().SingleOrDefault(p => p.ProductId == id);
            if (products == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(products);
            }












        }
    }
}

 
    

