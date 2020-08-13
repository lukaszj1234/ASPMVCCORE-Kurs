using System.Collections.Generic;
using System.Linq;

namespace KursASPMVC.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
            new Product {Name = "Piłka nożna", Price = 25 },
            new Product {Name = "Deska", Price = 179 },
            new Product {Name = "Buty", Price = 95 } }.AsQueryable<Product>();
    }
}
