using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DZ
{
    public class PayIn:Transaction
    {
        public PayIn(IBankAcc bankAcc, float amount):base(bankAcc, amount) { }
        public override void MakeATransaction()
        {
            BankAcc.Payin(amount);
            
            Console.WriteLine("Uplata izvršena: +" + amount);
        }

    }
}
