using KursASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace KursASPMVC.Tests
{
    public class CartTests
    {
        [Fact]
        public void Can_Add_New_Lines()
        {
            //Arranege
            var p1 = new Product { ProductID = 1, Name = "P1" };
            var p2 = new Product { ProductID = 2, Name = "P2" };
            var cart = new Cart();
            //Act
            cart.AddItem(p1, 1);
            cart.AddItem(p2, 2);
            CartLine[] results = cart.Lines.ToArray();
            //Asseert
            Assert.Equal(2, results.Count());
            Assert.Equal(p1, results[0].Product);
            Assert.Equal(p2, results[1].Product);
        }

        [Fact]
        public void Can_Add_Quantity_For_ExistingLines()
        {
            //Arranege
            var p1 = new Product { ProductID = 1, Name = "P1" };
            var p2 = new Product { ProductID = 2, Name = "P2" };
            var cart = new Cart();
            //Act
            cart.AddItem(p1, 1);
            cart.AddItem(p2, 2);
            cart.AddItem(p1, 10);
            cart.AddItem(p2, 11);
            CartLine[] results = cart.Lines.ToArray();
            //Asseert
            Assert.Equal(2, results.Count());
            Assert.Equal(11, results[0].Quantity);
            Assert.Equal(13, results[1].Quantity);
        }

        [Fact]
        public void Can_Remove_Line()
        {
            //Arranege
            var p1 = new Product { ProductID = 1, Name = "P1" };
            var p2 = new Product { ProductID = 2, Name = "P2" };
            var cart = new Cart();
            //Act
            cart.AddItem(p1, 1);
            cart.AddItem(p2, 2);
            cart.RemoveLine(p1);
            CartLine[] results = cart.Lines.ToArray();
            //Asseert
            Assert.Single(results);
            Assert.Equal(p2, results[0].Product);
        }

        [Fact]
        public void Can_Count_Total_Price()
        {
            //Arranege
            var p1 = new Product { ProductID = 1, Name = "P1",Price = 100};
            var p2 = new Product { ProductID = 2, Name = "P2", Price = 20};
            var cart = new Cart();
            //Act
            cart.AddItem(p1, 1);
            cart.AddItem(p2, 2);
            decimal results = cart.ComputeTotalValue();
            //Asseert
            Assert.Equal(140, results);
        }

        [Fact]
        public void Can_Delete_All_Lines()
        {
            //Arranege
            var p1 = new Product { ProductID = 1, Name = "P1", Price = 100 };
            var p2 = new Product { ProductID = 2, Name = "P2", Price = 20 };
            var p3 = new Product { ProductID = 3, Name = "P3", Price = 20 };
            var cart = new Cart();
            //Act
            cart.AddItem(p1, 1);
            cart.AddItem(p2, 2);
            cart.AddItem(p3, 3);
            cart.Clear();
            //Asseert
            Assert.Empty(cart.Lines);
        }
    }
}
