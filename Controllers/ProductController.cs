using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using practical6.Models;

namespace practical6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> P = GetProducts();

            return View(P);
        }

        public ActionResult Details(int id)
        {
            List<Product> PALL = GetProducts();

            Product P1 = PALL.FirstOrDefault(p => p.Id == id);

            return View(P1);
        }

        private List<Product> GetProducts()
        {
            List<Product> P = new List<Product>();

            Product p1 = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 55000,
                Category = "Electronics",
                ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8"
            };

            Product p2 = new Product
            {
                Id = 2,
                Name = "Mobile",
                Price = 25000,
                Category = "Electronics",
                ImageUrl = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9"
            };

            Product p3 = new Product
            {
                Id = 3,
                Name = "Shoes",
                Price = 5000,
                Category = "Fashion",
                ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff"
            };

            P.Add(p1);
            P.Add(p2);
            P.Add(p3);

            return P;
        }
    }
}




