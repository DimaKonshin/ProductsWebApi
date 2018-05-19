using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.Linq;
using Moq;

using Domain.DataBaseContextAndEntitiesDb;
using Domain.Calculator.Abstract;
using Domain.Calculator.Concrete;

namespace UnitTests._2ProductCalculatorTest
{
    [TestClass]
    public class ProductCalculatorTest
    {
        List<Product> list = new List<Product>(){
            new Product(){Id= 1, Price = 10, Quantity=10},
            new Product(){Id= 2, Price = 20, Quantity = 10},
            new Product(){Id= 3, Price = 30, Quantity = 10},
            new Product(){Id= 4, Price = 40, Quantity = 10}
        };


        [TestMethod]
        public void Can_FirstProductCalculator_GetSum()
        {
            Mock<IDiscount> discount = new Mock<IDiscount>();

            IProductCalculator calculator = new FirstProductCalculator(discount.Object);

            decimal sum = calculator.TotalSum(list);

            Assert.AreEqual(1000, sum);
        }

        [TestMethod]
        public void Can_FirstProductCalculator_GetSumWithDiscount()
        {
            Mock<IDiscount> discount = new Mock<IDiscount>();
            discount.Setup(x => x.ApplyDiscount(It.IsAny<decimal>())).Returns<decimal>(x => x * 0.9m);

            IProductCalculator calculator = new FirstProductCalculator(discount.Object);

            decimal sum = calculator.TotalSumWithDiscount(1000);

            Assert.AreEqual(900, sum);
        }
    }
}
