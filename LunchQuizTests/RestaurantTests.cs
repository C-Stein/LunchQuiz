using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LunchQuiz;
using System.Collections.Generic;

namespace LunchQuizTests
{
    [TestClass]
    public class RestaurantTests
    {
        [TestMethod]
        public void RestaurantEnsureICanCreateInstance()
        {
            Restaurant joes = new Restaurant();
        }

        [TestMethod]
        public void RestaurantHasMenuItems()
        {
            Restaurant joes = new Restaurant();
            joes.MenuItems.Add("stuff");
            Assert.IsNotNull(joes.MenuItems);
            
        }
        [TestMethod]
        public void RestaurantCanSetNumberOf4Tops()
        {
            Restaurant joes = new Restaurant();
            joes.NumOf4Tops = 8;
            Assert.AreEqual(8, joes.NumOf4Tops);
        }
        [TestMethod]
        public void RestaurantCanSetNumberOf2Tops()
        {
            Restaurant joes = new Restaurant();
            joes.NumOf2Tops = 6;
            Assert.AreEqual(6, joes.NumOf2Tops);
        }
        [TestMethod]
        public void RestaurantCanCalculateCapacity()
        {
            Restaurant joes = new Restaurant();
            joes.NumOf4Tops = 8;
            joes.NumOf2Tops = 6;
            Assert.AreEqual(44, joes.capacity());
        }
    }
}
