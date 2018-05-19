using Domain.Calculator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Calculator.Concrete
{
    public class FirstDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal sum)
        {
            if(sum <0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (sum > 10 && sum <= 100)
            {
                return sum * 0.9m;
            }
            else if(sum > 100)
            {
                return sum * 0.8m;
            }
            else
            {
                return sum;
            }
        }
    }
}
