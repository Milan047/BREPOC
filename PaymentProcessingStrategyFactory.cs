using BREPOC.PaymentStatergies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BREPOC.Enums;

namespace BREPOC
{
    class PaymentProcessingStrategyFactory
    {

      
        public static IPaymentStatergy GetPaymentStrategy(Product product)
        {
            //This object creation process will be moved to a DI framework(Unity,AutoFac) in futute
            switch (product.ProductType.ToEnum<ProductType>())
            {
                case ProductType.PHYSICAL:
                    return new PhysicalProductPaymentStrategy(product);
                case ProductType.BOOK: return new BookProductPaymentStrategy(product);
                case ProductType.VIDEO: return new VideoProductPaymentStrategy(product);
                case ProductType.MEMBERSHIP: return new MembershipProductPaymentStrategy(product);
                default: return null;
            }
        }
    }
}
