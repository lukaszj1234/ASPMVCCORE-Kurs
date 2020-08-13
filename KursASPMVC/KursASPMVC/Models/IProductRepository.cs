using System.Linq;

namespace KursASPMVC.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
