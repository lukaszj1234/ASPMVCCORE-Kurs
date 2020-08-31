using KursASPMVC.Components;
using KursASPMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Routing;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace KursASPMVC.Tests
{
    public class NavigationMenuViewComponetnTests
    {
        [Fact]
        public void Can_Select_Categories()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
                {
                new Product() {ProductID = 1, Name = "P1", Category="Szachy"},
                new Product() {ProductID = 2, Name = "P2", Category="Piłka nożna"},
                new Product() {ProductID = 3, Name = "P3", Category="Szachy"},
                new Product() {ProductID = 4, Name = "P4", Category="Piłka nożna"},
                new Product() {ProductID = 5, Name = "P5", Category="Szachy"},
                }).AsQueryable<Product>());
            NavigationMenuViewComponent component = new NavigationMenuViewComponent(mock.Object);
            //Act
            string[] result =((IEnumerable<string>)(component.Invoke() 
                as ViewViewComponentResult).ViewData.Model).ToArray();
            //Assert
            Assert.Equal(2, result.Length);
            Assert.True(Enumerable.SequenceEqual (new string[] { "Piłka nożna", "Szachy" }, result));
        }
        [Fact]
        public void Indicates_Select_Categories()
        {
            //Arrange
            string categoryToSelect = "Szachy";
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
                {
                new Product() {ProductID = 1, Name = "P1", Category="Szachy"},
                new Product() {ProductID = 4, Name = "P2", Category="Piłka nożna"},
                }).AsQueryable<Product>());
            NavigationMenuViewComponent component = 
                new NavigationMenuViewComponent(mock.Object);
            component.ViewComponentContext = new ViewComponentContext
            {
                ViewContext = new ViewContext
                {
                    RouteData = new RouteData()
                }
            };
            component.RouteData.Values["category"] = categoryToSelect;
            //Act
            string result = (string)(component.Invoke() as
                ViewViewComponentResult).ViewData["SelectedCategory"];
            //Assert
            Assert.Equal(categoryToSelect, result);
        }
    }
}
