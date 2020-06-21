using static BREPOC.Enums;

namespace BREPOC
{
    class VideoProductFactory : ProductFactory
    {
        private Product _product = null;
        public VideoProductFactory(Product product)
        {
            _product = product;
        }

        public override IPaymentStatergy GetPaymentStatergy()
        {
            return PaymentProcessingStrategyFactory.GetPaymentStrategy(_product);
        }

        public override Product GetProduct()
        {
            return new VideoProduct(_product);
        }
    }
}
