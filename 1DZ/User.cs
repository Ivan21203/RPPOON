using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DZ
{
    public class User:IBankAcc
    {
        private float amount;
        public User(float amount)
        {
            this.amount = amount;
        }
        public void Payin(float addmoney) 
        {
            amount += addmoney;
        }
        public void Payout(float addmoney) {  amount -= addmoney; }

        public float CheckBalance() 
        {
            Console.WriteLine();
            return amount; 
        }
    }
}
