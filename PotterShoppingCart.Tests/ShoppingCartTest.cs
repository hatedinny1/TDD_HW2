﻿using PotterShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod()]
        public void Test_PotterOne_1_PotterTwo_1_PotterThree_1_AcualPaid_Should_be_270()
        {
            //arrange
            var books = new Dictionary<string, int> {
                { "episode 1",1},
                { "episode 2",1},
                { "episode 3",1},
            };
            var cart = new ShoppingCart();
            //act
            cart.CalculateActualPaid(books);
            //assert
            var excepted = 270;
            Assert.AreEqual(excepted, cart.actualPaid);
        }

        [TestMethod()]
        public void Test_PotterOne_1_PotterTwo_1_PotterThree_1_PotterFour_1_AcualPaid_Should_be_320()
        {
            //arrange
            var books = new Dictionary<string, int> {
                { "episode 1",1},
                { "episode 2",1},
                { "episode 3",1},
                { "episode 4",1},
            };
            var cart = new ShoppingCart();
            //act
            cart.CalculateActualPaid(books);
            //assert
            var excepted = 320;
            Assert.AreEqual(excepted, cart.actualPaid);
        }

        [TestMethod()]
        public void Test_PotterOne_1_PotterTwo_1_PotterThree_1_PotterFour_1_PotterFive_1_AcualPaid_Should_be_375()
        {
            //arrange
            var books = new Dictionary<string, int> {
                { "episode 1",1},
                { "episode 2",1},
                { "episode 3",1},
                { "episode 4",1},
                { "episode 5",1},
            };
            var cart = new ShoppingCart();
            //act
            cart.CalculateActualPaid(books);
            //assert
            var excepted = 375;
            Assert.AreEqual(excepted, cart.actualPaid);
        }

        [TestMethod()]
        public void Test_PotterOne_1_PotterTwo_1_PotterThree_2_AcualPaid_Should_be_370()
        {
            //arrange
            var books = new Dictionary<string, int> {
                { "episode 1",1},
                { "episode 2",1},
                { "episode 3",2},
            };
            var cart = new ShoppingCart();
            //act
            cart.CalculateActualPaid(books);
            //assert
            var excepted = 370;
            Assert.AreEqual(excepted, cart.actualPaid);
        }

        [TestMethod()]
        public void Test_PotterOne_1_PotterTwo_2_PotterThree_2_AcualPaid_Should_be_460()
        {
            //arrange
            var books = new Dictionary<string, int> {
                { "episode 1",1},
                { "episode 2",2},
                { "episode 3",2},
            };
            var cart = new ShoppingCart();
            //act
            cart.CalculateActualPaid(books);
            //assert
            var excepted = 460;
            Assert.AreEqual(excepted, cart.actualPaid);
        }

        [TestMethod()]
        public void Test_PotterOne_1_PotterTwo_2_PotterThree_3_AcualPaid_Should_be_560()
        {
            //arrange
            var books = new Dictionary<string, int> {
                { "episode 1",1},
                { "episode 2",2},
                { "episode 3",3},
            };
            var cart = new ShoppingCart();
            //act
            cart.CalculateActualPaid(books);
            //assert
            var excepted = 560;
            Assert.AreEqual(excepted, cart.actualPaid);
        }
    }
}