using static BREPOC.Enums;

namespace BREPOC
{
    class PhysicalProductFactory:ProductFactory
    {
        private Product _product = null;
        public PhysicalProductFactory(Product product)
        {
            _product = product;

        }

        public override IPaymentStatergy GetPaymentStatergy()
        {
            return PaymentProcessingStrategyFactory.GetPaymentStrategy(_product);
        }

        public override Product GetProduct()
        {
            return new PhysicalProduct(_product);
        }
    }
}
