using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    public abstract class CoffeeDecorator
    {
        protected Coffee coffee;

        public CoffeeDecorator(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public double GetCost()
        {
            return coffee.GetCost();
        }

        public string GetDescription()
        {
            return coffee.GetDescription();
        }
    }
}
