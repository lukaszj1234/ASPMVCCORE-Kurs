using System.ComponentModel.DataAnnotations;

namespace KursASPMVC.Models
{
    public class Product
    {
        
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę produktu")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę produktu")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Proszę podać cenę")]
        [Range(0.01,double.MaxValue, ErrorMessage ="Proszę podać dodatną cenę")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Proszę okreslić kategorię")]
        public string Category { get; set; }
    }
}
