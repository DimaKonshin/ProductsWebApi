using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract.Calculator
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal sum);
    }
}
