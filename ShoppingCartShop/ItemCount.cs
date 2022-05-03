using System;
using System.Linq;

namespace ShoppingCartShop
{
    public class ItemCount : IItemCount
    {
        public void Items(string[] item, ref int xbox, ref int ps4)
        {
            xbox = item.Count(a => a.Trim().ToLower() == "Xbox");
            ps4 = item.Count(a => a.Trim().ToLower() == "Ps4");
        }

        internal static object Item(string[] itemList, ref int xbox, ref int ps4)
        {
            throw new NotImplementedException();
        }
    }
}
