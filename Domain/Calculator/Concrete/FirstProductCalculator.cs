using Domain.Abstract.Calculator;
using Domain.DataBaseContextAndEntitiesDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Calculator.Concrete
{
    public class FirstProductCalculator:IProductCalculator
    {
        IDiscount discount;

        public FirstProductCalculator(IDiscount discount)
        {
            this.discount = discount;
        }

        public decimal TotalSum(List<Products> list)
        {
            return list.Sum(x => x.Price * x.Quantity);
        }

        public decimal TotalSumWithDiscount(decimal sum)
        {
            return discount.ApplyDiscount(sum);
        }
    }
}
