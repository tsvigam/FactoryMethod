using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopGold shG = new ShopGold();
            ShopCorall shC = new ShopCorall();
            List<Fish> listFish = new List<Fish>();
            listFish.Add(shG.MakeFish(100, 2));
            Console.WriteLine(listFish[0].ShowColor());
            Console.WriteLine(listFish[0].GetNeeds() + "Cost -" + listFish[0].Cost);
            listFish.Add(shC.MakeFish(2000, 3));
            Console.WriteLine(listFish[1].ShowColor());
            Console.WriteLine(listFish[1].GetNeeds() + "Cost -"+listFish[1].Cost);
            listFish.Add(shG.MakeFish(200, 1));
            Console.WriteLine(listFish[2].ShowColor());
            Console.WriteLine(listFish[2].GetNeeds() + "Cost -" + listFish[2].Cost);
            listFish.Add(shC.MakeFish(5000, 1));
            Console.WriteLine(listFish[3].ShowColor());
            Console.WriteLine(listFish[3].GetNeeds() + "Cost -" + listFish[3].Cost);
        }
    }
}
