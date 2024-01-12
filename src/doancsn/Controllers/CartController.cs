using doancsn.Data;
using doancsn.Infrastructure;
using doancsn.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace doancsn.Controllers
{
    public class CartController : Controller
    {
        public Cart? Cart { get; set; }
        private readonly doancsnContext _context;

        public CartController(doancsnContext context)
        {
            _context = context;
        }
        public IActionResult AddToCart(int id, int quantity = 1)
        { 
            Product? product = _context.Product
                .FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, quantity);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }

        public IActionResult UpdateCart(int id, int quantity = 1)
        {
            Product? product = _context.Product
                .FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, -1);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }

        public IActionResult RemoveFromCart(int id, int quantity = 1)
        {
            Product? product = _context.Product
                .FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart");
                Cart.RemoveLine(product);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }
    }
}
