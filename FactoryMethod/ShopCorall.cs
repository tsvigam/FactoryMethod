using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ShopCorall : Shop
    {
        public override Fish MakeFish(int cost, int g)
        {
            return new CorallFish(cost, g);
        }
    }
}
