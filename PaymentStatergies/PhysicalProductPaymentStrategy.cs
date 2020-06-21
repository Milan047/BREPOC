using System;
namespace BREPOC.PaymentStatergies
{
    class PhysicalProductPaymentStrategy : IPaymentStatergy
    {
        private Product _product = null;
        public PhysicalProductPaymentStrategy(Product product)
        {
            _product = product;

        }
        public decimal CalculateCost(decimal productCost)
        {
            // ADDITIONAL LOGIC TO BE IMPLEMENTED
            return productCost;
        }

        public void ProcessPayment()
        {
            Console.WriteLine("Applying  PhysicalProductPaymentStrategy");
            GeneratePackagingSlip();
            GenerateCommisionPaymentForAgent();
        }

        private void GeneratePackagingSlip()
        {
            Console.WriteLine("Generated Packaging  slip");
        }
        private void GenerateCommisionPaymentForAgent()
        {
            Console.WriteLine("Generated Commission  payment");
        }
    }
}
