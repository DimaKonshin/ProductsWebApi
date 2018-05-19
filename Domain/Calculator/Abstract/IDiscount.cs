using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Calculator.Abstract
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal sum);
    }
}
