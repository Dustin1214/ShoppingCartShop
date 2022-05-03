using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartShop
{
    public class CalculateBase : ICalculate
    {
        public double CalculateTotal(int Xbox, int Ps4, double XboxPrice, double Ps4Price)
        {
            return ((Xbox * XboxPrice) + (Ps4Price * XboxPrice) / 100) * 20;





        }

        decimal ICalculate.CalculateTotal(int Xbox, int Ps4, decimal XboxPrice, decimal Ps4Price)
        {
            throw new NotImplementedException();
        }
    }
}

