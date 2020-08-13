using KursASPMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace KursASPMVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repo)
        {
            _repository = repo;
        }
        public ViewResult List()
        {
            return View(_repository.Products);
        } 
    }
}
