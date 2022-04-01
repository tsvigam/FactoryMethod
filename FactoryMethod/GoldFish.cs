using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{

    public class GoldFish : Fish
    {
        public override int GroupOfNeeds { get; set; }

        public GoldFish(int c, int g) : base(c)
        {
            GroupOfNeeds = g;
        }

        public override string ShowColor()
        {
            string c = "Gold";
            return c;
        }

        public override StringBuilder GetNeeds()
        {
            StringBuilder s = new StringBuilder();
            s.Append("Need Oxygen, ");
            switch (GroupOfNeeds)
            {
                case (1):
                    {
                        s.Append("Need Castle");
                        break;
                    }
                case 2:
                    {
                        s.Append("Need Castle, ");
                        s.Append("Need friend");
                        break;
                    }
                case 3:
                    {
                        s.Append("Need Castle, ");
                        s.Append("Need friend, ");
                        s.Append("Need grass");
                        break;
                    }
            }
            return s;
        }
    }
}
