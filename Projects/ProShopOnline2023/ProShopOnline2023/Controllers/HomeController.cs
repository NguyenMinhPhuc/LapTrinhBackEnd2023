
using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProShopOnline2023.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> products = new ProductDao().GetProducts();
            return View(products);
        }
        public ActionResult Detail(int id)
        {
            Product product = new ProductDao().GetProductByID(id);
            return View(product);
        }
    }
}