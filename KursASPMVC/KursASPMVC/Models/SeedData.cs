using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace KursASPMVC.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
               .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kajak",
                        Description = "Łódka",
                        Category = "Sporty wodne",
                        Price = 275
                    },
                    new Product
                    {
                    Name = "Kamizelka",
                        Description = "Chroni",
                        Category = "Sporty wodne",
                        Price = 48.95m
                    },
                    new Product
                    {
                         Name = "Piłka",
                         Description = "Oficjalna",
                         Category = "Piłka nożna",
                         Price = 275
                    },
                    new Product
                    {
                        Name = "Stadion",
                        Description = "Składany",
                        Category = "Piłka nożna",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Czapka",
                        Description = "Oficjalna",
                        Category = "Szachy",
                        Price = 16
                    },
                    new Product
                    {
                         Name = "Krzesło",
                         Description = "Do szachów",
                         Category = "Szachy",
                         Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Szachownica",
                        Description = "Do szachów",
                        Category = "Szachy",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Błyszczący król",
                        Description = "Król ze złota",
                        Category = "Szachy",
                        Price = 145685
                    },
                    new Product
                    {
                        Name = "Flagi narożne",
                        Description = "Na boisko",
                        Category = "Piłka nożna",
                        Price = 275   
                    });
                context.SaveChanges();
            }
        }
    }
}
