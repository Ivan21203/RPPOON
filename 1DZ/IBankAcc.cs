using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DZ
{
    public interface IBankAcc
    {
        void Payout(float amount);
        void Payin(float amount);
        float CheckBalance();
    }
}
