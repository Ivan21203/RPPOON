using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{
    public class Client
    {
        public static void Run(Coffee myCoffee)
        {
            Console.WriteLine("Description: " + myCoffee.GetDescription());
            Console.WriteLine("Cost: $" + myCoffee.GetCost());
        }
    }
}
