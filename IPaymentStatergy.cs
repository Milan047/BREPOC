using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BREPOC
{
    interface IPaymentStatergy
    {
        void ProcessPayment();

        decimal CalculateCost(decimal productCost);


    }
}
