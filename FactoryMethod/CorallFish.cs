using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CorallFish : Fish
    {
        public override int GroupOfNeeds { get; set; }
        public CorallFish(int c, int g) : base(c)
        {
            GroupOfNeeds = g;
        }
        public override string ShowColor()
        {
            Random rnd = new Random();
            string c1 = (Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))).ToString();
            string c2 = (Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))).ToString();
            string c3 = (Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))).ToString();
            string c = c1 + "-" + c2 + "-" + c3;
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
                        s.Append("Need enimy");
                        break;
                    }
                case 2:
                    {
                        s.Append("Need enimy, ");
                        s.Append("Need friend");
                        break;
                    }
                case 3:
                    {
                        s.Append("Need Rocks, ");
                        s.Append("Need enimy, ");
                        s.Append("Need friend");
                        break;
                    }
            }
            return s;
        }
    }
}
