using KursASPMVC.Controllers;
using KursASPMVC.Models;
using KursASPMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace KursASPMVC.Tests
{
    public class ProductControlerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
                {
                new Product() {ProductID = 1, Name = "P1"},
                new Product() {ProductID = 2, Name = "P2"},
                new Product() {ProductID = 3, Name = "P3"},
                new Product() {ProductID = 4, Name = "P4"},
                new Product() {ProductID = 5, Name = "P5"},
                }).AsQueryable<Product>());
            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;
            //Act
            ProductListViewModel result =
                controller.List(null,2).ViewData.Model as ProductListViewModel;
            //Assert
            Product[] prodArray = result.Products.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P4", prodArray[0].Name);
            Assert.Equal("P5", prodArray[1].Name);
        }

        [Fact]
        public void Can_Send_Pagination_View_Model()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product() {ProductID = 1, Name = "P1"},
                new Product() {ProductID = 2, Name = "P2"},
                new Product() {ProductID = 3, Name = "P3"},
                new Product() {ProductID = 4, Name = "P4"},
                new Product() {ProductID = 5, Name = "P5"},
            }).AsQueryable<Product>());
            ProductController controller = new ProductController(mock.Object);
            //Act
            var result = controller.List(null,2).ViewData.Model as ProductListViewModel;
            //Assert
            PagingInfo pagingInfo = result.PagingInfo;
            Assert.Equal(2, pagingInfo.CurrentPage);
            Assert.Equal(4, pagingInfo.ItemsPerPage);
            Assert.Equal(5, pagingInfo.TotalItems);
            Assert.Equal(2, pagingInfo.TotalPages);
        }

        [Fact]
        public void Can_Filter_Products()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product() {ProductID = 1, Name = "P1", Category="Cat1"},
                new Product() {ProductID = 2, Name = "P2", Category="Cat2"},
                new Product() {ProductID = 3, Name = "P3", Category="Cat1"},
                new Product() {ProductID = 4, Name = "P4", Category="Cat2"},
                new Product() {ProductID = 5, Name = "P5", Category="Cat3"},
            }).AsQueryable<Product>());
            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;
            //Act
            var result = (controller.List("Cat2", 1).ViewData.Model as ProductListViewModel).Products.ToArray();
            //Assert
            Assert.Equal(2, result.Length);
            Assert.True(result[0].Name == "P2" && result[0].Category == "Cat2");
            Assert.True(result[1].Name == "P4" && result[1].Category == "Cat2");
        }

        [Fact]
        public void Generate_Category_Specific_Products()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product() {ProductID = 1, Name = "P1", Category="Cat1"},
                new Product() {ProductID = 2, Name = "P2", Category="Cat2"},
                new Product() {ProductID = 3, Name = "P3", Category="Cat1"},
                new Product() {ProductID = 4, Name = "P4", Category="Cat2"},
                new Product() {ProductID = 5, Name = "P5", Category="Cat3"},
            }).AsQueryable<Product>());
            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;
            Func<ViewResult, ProductListViewModel> GetModel = result =>
                result?.ViewData?.Model as ProductListViewModel;
            //Act
            int? result1 = GetModel(controller.List("Cat1"))?.PagingInfo.TotalItems;
            int? result2 = GetModel(controller.List("Cat2"))?.PagingInfo.TotalItems;
            int? result3 = GetModel(controller.List("Cat3"))?.PagingInfo.TotalItems;
            int? resultAll = GetModel(controller.List(null))?.PagingInfo.TotalItems;
            //Assert
            Assert.Equal(2, result1);
            Assert.Equal(2, result2);
            Assert.Equal(1, result3);
            Assert.Equal(5, resultAll);
        }
    }
}
