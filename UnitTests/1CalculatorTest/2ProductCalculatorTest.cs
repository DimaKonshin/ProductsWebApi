using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.Linq;
using Moq;

using Domain.DataBaseContextAndEntitiesDb;

namespace UnitTests._2ProductCalculatorTest
{
    [TestClass]
    public class ProductCalculatorTest
    {
        List<Product> list = new List<Product>(){
            new Product(){Id= 1, Price = 10},
            new Product(){Id= 2, Price = 20},
            new Product(){Id= 3, Price = 30},
            new Product(){Id= 4, Price = 40},
        };


        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
