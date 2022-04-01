using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Fish
    {
        public abstract int GroupOfNeeds { get; set; }

        public int Cost
        {
            get; protected set;
        }

        protected Fish(int cost)
        {
            Cost = cost;
        }

        public void Swim()
        {
            Console.Write("I'm swimming");
        }
        public abstract string ShowColor();
        public abstract StringBuilder GetNeeds();
    }
}
