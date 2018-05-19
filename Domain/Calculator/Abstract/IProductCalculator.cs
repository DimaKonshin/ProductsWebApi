using Domain.DataBaseContextAndEntitiesDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Calculator.Abstract
{
    public interface IProductCalculator
    {
        decimal TotalSum(List<Product> list);
        decimal TotalSumWithDiscount(decimal sum);
    }
}
