using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartShop
{
    public interface IOffer
    {
        int BuyOneGetOne(int item);
        int ThreeForTwo(int item);
    }
}
