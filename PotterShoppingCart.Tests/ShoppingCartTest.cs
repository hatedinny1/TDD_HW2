using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PotterShoppingCart;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void Test_PotterOne_1_AcualPaid_Should_be_100()
        {
            //arrange
            var books = new Dictionary<string, int> {
                { "episode 1",1}
            };
            var cart = new ShoppingCart();
            //act
            cart.CalculateActualPaid(books);
            //assert
            var excepted = 100;
            Assert.AreEqual(excepted, cart.actualPaid);
        }

        [TestMethod()]
        public void Test_PotterOne_1_PotterTwo_1_AcualPaid_Should_be_190()
        {
            //arrange
            var books = new Dictionary<string, int> {
                { "episode 1",1},
                { "episode 2",1}
            };
            var cart = new ShoppingCart();
            //act
            cart.CalculateActualPaid(books);
            //assert
            var excepted = 190;
            Assert.AreEqual(excepted, cart.actualPaid);
        }
    }
}
