using KursASPMVC.Controllers;
using KursASPMVC.Models;
using Moq;
using System.Linq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KursASPMVC.Tests
{
    public class AdminControllerTests
    {
        [Fact]
        public void Index_Contains_All_Products()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m=>m.Products).Returns(new Product[] {
                new Product {ProductID = 1, Name = "P1" },
                new Product {ProductID = 2, Name = "P2" },
                new Product {ProductID = 3, Name = "P3" },
                new Product {ProductID = 4, Name = "P4" },
            }.AsQueryable<Product>);
            AdminController target = new AdminController(mock.Object);
            //Act
            Product[] result = GetViewModel<IEnumerable<Product>> (target.Index())?.ToArray();
            //Assert
            Assert.Equal(4, result.Length);
            Assert.Equal("P1", result[0].Name);
            Assert.Equal("P2", result[1].Name);
            Assert.Equal("P3", result[2].Name);
        }

        [Fact]
        public void Can_Edit_Products()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[] {
                new Product {ProductID = 1, Name = "P1" },
                new Product {ProductID = 2, Name = "P2" },
                new Product {ProductID = 3, Name = "P3" },
            }.AsQueryable<Product>);
            AdminController target = new AdminController(mock.Object);
            //Act
            Product P1 = GetViewModel<Product>(target.Edit(1));
            Product P2 = GetViewModel<Product>(target.Edit(2));
            Product P3 = GetViewModel<Product>(target.Edit(3));
            //Assert
            Assert.Equal("P1", P1.Name);
            Assert.Equal("P2", P2.Name);
            Assert.Equal("P3", P3.Name);
        }

        [Fact]
        public void Cannot_Edit_Nonexistent_Product()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[] {
                new Product {ProductID = 1, Name = "P1" },
                new Product {ProductID = 2, Name = "P2" },
                new Product {ProductID = 3, Name = "P3" },
            }.AsQueryable<Product>);
            AdminController target = new AdminController(mock.Object);
            //Act
            Product result = GetViewModel<Product>(target.Edit(4));

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void Can_Delete_Valid_Product()
        {
            Product product = new Product { ProductID = 2, Name = "P2" };
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[] {
                new Product {ProductID = 1, Name = "P1" },
                product,
                new Product {ProductID = 3, Name = "P3" },
            }.AsQueryable<Product>);
            AdminController target = new AdminController(mock.Object);
            //Act
            target.Delete(product.ProductID);

            //Assert
            mock.Verify(m => m.DeleteProduct(product.ProductID));
        }
        private T GetViewModel<T>(IActionResult result) where T : class
        {
            return (result as ViewResult)?.ViewData.Model as T;
        }
    }
}
