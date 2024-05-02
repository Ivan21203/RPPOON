using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DZ
{
    public abstract class Transaction:ITransaction
    {
        protected IBankAcc BankAcc;
        public float amount;
        public Transaction(IBankAcc BankAcc, float amount) 
        {
            this.BankAcc = BankAcc;
            this.amount = amount;
        }
        public abstract void MakeATransaction();
    }
}
