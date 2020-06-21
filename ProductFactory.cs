namespace BREPOC
{
    abstract class ProductFactory
    {
        public abstract Product GetProduct();

        public abstract IPaymentStatergy GetPaymentStatergy();

    }
}
