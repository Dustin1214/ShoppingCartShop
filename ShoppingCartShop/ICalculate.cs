using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartShop
{
    public interface ICalculate
    {
        decimal CalculateTotal(int Xbox, int Ps4, decimal XboxPrice, decimal Ps4Price);

    }
}
