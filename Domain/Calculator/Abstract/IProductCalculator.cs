﻿using Domain.DataBaseContextAndEntitiesDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract.Calculator
{
    public interface IProductCalculator
    {
        decimal TotalSum(List<Products> list);
        decimal TotalSumWithDiscount(decimal sum);
    }
}