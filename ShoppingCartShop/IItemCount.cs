using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartShop
{
    public interface IItemCount
    {
        void Items(string[] item, ref int Xbox, ref int Ps4);
    }
}
