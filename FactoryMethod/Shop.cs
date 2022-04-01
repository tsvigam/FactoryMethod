using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Shop
    {
        public abstract Fish MakeFish(int cost, int g);
    }
}
