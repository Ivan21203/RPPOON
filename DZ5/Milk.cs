using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    public class Milk:CoffeeDecorator
    {
        public Milk(Coffee coffee) : base(coffee) { }

        public double GetCost()
        {
            return base.GetCost() + 0.50;
        }

        public String GetDescription()
        {
            return base.GetDescription() + ", Milk";
        }
    }
}
