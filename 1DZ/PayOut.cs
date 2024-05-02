using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DZ
{
    internal class PayOut:Transaction
    {
        
            public PayOut(IBankAcc bankAcc, float amount) : base(bankAcc, amount) { }

            public override void MakeATransaction()
            {
                BankAcc.Payout(amount);
                Console.WriteLine("Isplata izvršena: -" + amount);
            }
     }
    
}
