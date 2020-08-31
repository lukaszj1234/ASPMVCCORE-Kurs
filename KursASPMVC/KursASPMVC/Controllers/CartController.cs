using System.Linq;
using KursASPMVC.Models;
using KursASPMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KursASPMVC.Controllers
{
    [Route("[controller]/[action]")]
    public class CartController : Controller
    {
        private IProductRepository _repository;
        private Cart _cart;

        public CartController(IProductRepository repository, Cart cartService)
        {
            _repository = repository;
            _cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = _cart,
                ReturnUrl = returnUrl
            });
        }
        
        public RedirectToActionResult AddToCart(int productId, string returnUrl)
        {
            Product product = _repository.Products.Where(
                p => p.ProductID == productId).FirstOrDefault();
           if (product!=null)
            {
                _cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        
        public RedirectToActionResult RemoveFromCart (int productId,
            string returnUrl)
        {
            Product product = _repository.Products.FirstOrDefault(
                p => p.ProductID == productId);
            if (product!=null)
            {
                _cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
