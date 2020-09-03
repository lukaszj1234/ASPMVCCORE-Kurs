using KursASPMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KursASPMVC.Controllers
{
    [Route("[controller]/[action]")]
    public class AdminController : Controller
    {
        private IProductRepository _productRepository;

        public AdminController(IProductRepository repo)
        {
            _productRepository = repo;
        }
        public IActionResult Index()
        {
            return View(_productRepository.Products);
        }

        public ViewResult Edit(int productID)
        {
            return View(_productRepository.Products
                .FirstOrDefault(p => p.ProductID == productID));
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.SaveProduct(product);
                TempData["message"] = $"Zpisano {product.Name}.";
                return RedirectToAction(nameof(Index)); 
            }
            return View(product);
        }
    }
}
