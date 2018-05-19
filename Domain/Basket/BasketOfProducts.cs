using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Calculator.Abstract;
using Domain.Calculator.Concrete;

namespace Domain.Basket
{
    public class BasketOfProducts
    {
        public ListOfProducts listOfProducts = new ListOfProducts();

        IProductCalculator calculator; 

        public BasketOfProducts(IProductCalculator calculator)
        {
            this.calculator = calculator;
        }

        public decimal TotalSum()
        {
            return calculator.TotalSum(listOfProducts.Read());
        }

        public decimal TotalSumWithDiscount()
        {
            return calculator.TotalSumWithDiscount(this.TotalSum());
        }
    }
}
