using KursASPMVC.Controllers;
using KursASPMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace KursASPMVC.Tests
{
    public class OrderControllerTests
    {
        [Fact]
        public void Cannot_Checkout_Empty_Cart()
        {
            //Arrange
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
            Cart cart = new Cart();
            OrderController target = new OrderController(mock.Object, cart);
            Order order = new Order();
            //Act
            ViewResult result = target.Checkout(order) as ViewResult;
            //Assert
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()), Times.Never);
            Assert.True(string.IsNullOrEmpty(result.ViewName));
            Assert.False(result.ViewData.ModelState.IsValid);
        }

        [Fact]
        public void Cannot_Checkout_Invalid_SippingDetails()
        {
            //Arrange
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
            Cart cart = new Cart();
            cart.AddItem(new Product(), 1);
            OrderController target = new OrderController(mock.Object, cart);
            target.ModelState.AddModelError("error", "error");
            Order order = new Order();
            //Act
            ViewResult result = target.Checkout(order) as ViewResult;
            //Assert
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()), Times.Never);
            Assert.True(string.IsNullOrEmpty(result.ViewName));
            Assert.False(result.ViewData.ModelState.IsValid);
        }

        [Fact]
        public void Can_Checkout_And_submit_Order()
        {
            //Arrange
            Mock<IOrderRepository> mock = new Mock<IOrderRepository>();
            Cart cart = new Cart();
            cart.AddItem(new Product(), 1);
            OrderController target = new OrderController(mock.Object, cart);
            Order order = new Order();
            //Act
            RedirectToActionResult result = target.Checkout(order) as RedirectToActionResult;
            //Assert
            mock.Verify(m => m.SaveOrder(It.IsAny<Order>()), Times.Once);
            Assert.Equal("Completed", result.ActionName);
        }
    }
}
