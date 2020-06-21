using static BREPOC.Enums;

namespace BREPOC
{
    class MembershipProductFactory : ProductFactory
    {
        private Product _product = null;
        public MembershipProductFactory(Product product)
        {
            _product = product;
        }

        public override IPaymentStatergy GetPaymentStatergy()
        {
            return PaymentProcessingStrategyFactory.GetPaymentStrategy(_product);
        }

        public override Product GetProduct()
        {
            return new MembershipProduct(_product);
        }
    }
}
