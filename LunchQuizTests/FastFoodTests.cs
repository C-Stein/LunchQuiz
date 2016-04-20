using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LunchQuiz;
using System.Collections.Generic;

namespace LunchQuizTests
{
    [TestClass]
    public class FastFoodTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FastFood krustys = new FastFood();
            Assert.IsNotNull(krustys);
        }

        [TestMethod]
        public void EnsureICanCreateMenuItem()
        {
            MenuItem milkshake = new MenuItem();
            Assert.IsNotNull(milkshake);
        }

        //[TestMethod]
        //public void FastFoodHasMenuItems()
        //{
        //    FastFood krustys = new FastFood();
           
        //    krustys.addMenuItem("soylentGreen");
        //    Assert.IsNotNull(krustys.MenuItems);
        //}

        [TestMethod]
        public void tryLists()
        {
            List<string> menuThing = new List<string>();
            Assert.IsNotNull(menuThing);
        }

        [TestMethod]
        public void CanAddMenuItemWithJustName()
        {
            FastFood krustys = new FastFood();
            krustys.addMenuItem("hamburger");
            //Assert.AreEqual(1, krustys.MenuItems.Count);
        }
    }
}
