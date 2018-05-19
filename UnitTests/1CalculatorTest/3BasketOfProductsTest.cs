using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.Linq;
using Moq;

using Domain.DataBaseContextAndEntitiesDb;
using Domain.Calculator.Abstract;
using Domain.Calculator.Concrete;
using Domain.Basket;

namespace UnitTests._3BasketOfProductsTest
{
    [TestClass]
    public class BasketOfProductsTest
    {
        List<Product> list = new List<Product>(){
            new Product(){Id= 1, Price = 10, Quantity = 10},
            new Product(){Id= 2, Price = 20, Quantity = 10},
            new Product(){Id= 3, Price = 30, Quantity = 10},
            new Product(){Id= 4, Price = 40, Quantity = 10}
        };

        [TestMethod]
        public void Can_BasketOfProducts_GetTotalSum()
        {
            Mock<IProductCalculator> calculator = new Mock<IProductCalculator>();
            calculator.Setup(x => x.TotalSum(It.IsAny<List<Product>>())).Returns<List<Product>>(x => x.Sum(m => m.Price * m.Quantity));

            BasketOfProducts basketOfProducts = new BasketOfProducts(calculator.Object);

            for (int i = 0; i < list.Count; i++)
            {
                basketOfProducts.listOfProducts.CreateUpdate(list[i]);
            }

            decimal sum = basketOfProducts.TotalSum();

            Assert.AreEqual(1000, sum);
        }

        [TestMethod]
        public void Can_BasketOfProducts_GetTotalSum_WithDiscount()
        {
            Mock<IProductCalculator> calculator = new Mock<IProductCalculator>();
            calculator.Setup(x => x.TotalSum(It.IsAny<List<Product>>())).Returns<List<Product>>(x => x.Sum(m => m.Price * m.Quantity));
            calculator.Setup(x => x.TotalSumWithDiscount(It.IsAny<decimal>())).Returns<decimal>(x =>x*0.9m);

            BasketOfProducts basketOfProducts = new BasketOfProducts(calculator.Object);

            for (int i = 0; i < list.Count; i++)
            {
                basketOfProducts.listOfProducts.CreateUpdate(list[i]);
            }

            decimal sum = basketOfProducts.TotalSumWithDiscount();

            Assert.AreEqual(900, sum);
        }
    }
}
