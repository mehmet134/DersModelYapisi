using DersModelYapisi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var product1 = new Product { Id = 1, Name = "TELEFON", Price = 20000 };
            var product2 = new Product { Id = 2, Name = "BİLGİSAYAR", Price = 30000};
            var product3 = new Product { Id = 3, Name = "TABLET", Price = 10000};

            var cartProduct1 = new cartProducts { Id = 1, Product = product1, Quantity = 5, Price = 5 };
            var cartProduct2 = new cartProducts { Id = 2, Product = product2, Quantity = 3, Price = 3};
            var cartProduct3 = new cartProducts { Id = 3, Product = product3, Quantity = 2, Price = 2 };

            var cartProducts = new List<cartProducts> { cartProduct1, cartProduct2, cartProduct3 };

            return View(cartProducts);
        }
    }
}
