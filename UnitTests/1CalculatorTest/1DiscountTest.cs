using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Domain.Calculator.Abstract;
using Domain.Calculator.Concrete;

namespace UnitTests._1DiscountTest
{
    [TestClass]
    public class DiscountTest
    {
        [TestMethod]
        public void Can_FirstDiscount_ApplyDiscount()
        {
            IDiscount discount = new FirstDiscount();

            decimal res1 = discount.ApplyDiscount(5);
            decimal res2 = discount.ApplyDiscount(10);
            decimal res3 = discount.ApplyDiscount(50);
            decimal res4 = discount.ApplyDiscount(100);
            decimal res5 = discount.ApplyDiscount(200);

            Assert.AreEqual(5, res1);
            Assert.AreEqual(10, res2);
            Assert.AreEqual(45, res3);
            Assert.AreEqual(90, res4);
            Assert.AreEqual(160, res5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Can_FirstDiscount_Generate_Exception()
        {
            IDiscount discount = new FirstDiscount();

            decimal res1 = discount.ApplyDiscount(-1);
        }
    }
}
