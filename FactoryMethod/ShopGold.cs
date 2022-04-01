using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ShopGold : Shop
    {
        public override Fish MakeFish(int cost, int g)
        {
            return new GoldFish(cost, g);
        }
    }
}
