using static BREPOC.Enums;

namespace BREPOC
{
    class BookProductFactory : ProductFactory
    {

        private Product _product = null;
        public BookProductFactory(Product product)
        {
            _product = product;
        }

        public override IPaymentStatergy GetPaymentStatergy()
        {
            return PaymentProcessingStrategyFactory.GetPaymentStrategy(_product);
        }

        public override Product GetProduct()
        {
            return new BookProduct(_product);
        }
    }
}
