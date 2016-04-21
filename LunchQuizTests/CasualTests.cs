using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LunchQuiz;
using System.Linq;

namespace LunchQuizTests
{
    [TestClass]
    public class CasualTests
    {
        [TestMethod]
        public void CasualCanCreateInstance()
        {
            Casual tchotchkes = new Casual();
            Assert.IsNotNull(tchotchkes);
        }
        [TestMethod]
        public void CasualCanSetPatio()
        {
            Casual tchotchkes = new Casual();
            tchotchkes.HasPatio = false;
            Assert.IsFalse(tchotchkes.HasPatio);
        }
        [TestMethod]
        public void CasualRestaurantsAreCreatedWithSomethingAlreadyOnTheMenu()
        {
            Casual tchotchkes = new Casual();
            Assert.IsTrue(tchotchkes.MenuItems.Count > 0);

        }
         
    }
}
