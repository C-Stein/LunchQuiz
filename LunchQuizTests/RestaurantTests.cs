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
            Assert.IsNotNull(joes.MenuItems);
            
        }
        [TestMethod]
        public void RestaurantCanSetNumberOf4Tops()
        {
            Restaurant joes = new Restaurant();
            joes.Numberof4PersonTables = 8;
            Assert.AreEqual(8, joes.Numberof4PersonTables);
        }
        [TestMethod]
        public void RestaurantCanSetNumberOf2Tops()
        {
            Restaurant joes = new Restaurant();
            joes.Numberof2PersonTables = 6;
            Assert.AreEqual(6, joes.Numberof2PersonTables);
        }
        [TestMethod]
        public void RestaurantCanCalculateCapacity()
        {
            Restaurant joes = new Restaurant();
            joes.Numberof4PersonTables = 8;
            joes.Numberof2PersonTables = 6;
            Assert.AreEqual(44, joes.capacity());
        }
    }
}
