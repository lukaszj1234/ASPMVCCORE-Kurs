using System.Linq;
using KursASPMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace KursASPMVC.Controllers
{
    [Route("[controller]/[action]")]
    public class OrderController : Controller
    {
        private IOrderRepository _repository;
        private Cart _cart;

        public OrderController(IOrderRepository repo, Cart cartService)
        {
            _repository = repo;
            _cart = cartService;
        }
        public IActionResult Checkout(Order order)
        {
            if (_cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Koszyk jest pusty");
            }
            if (ModelState.IsValid)
            {
                order.Lines = _cart.Lines.ToArray();
                _repository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }
        public ViewResult Completed()
        {
            _cart.Clear();
            return View();
        }
    }
}
