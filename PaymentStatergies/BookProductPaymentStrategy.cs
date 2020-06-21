using System;

namespace BREPOC.PaymentStatergies
{
     public class BookProductPaymentStrategy : IPaymentStatergy
    {
        private Product _product = null;
        public BookProductPaymentStrategy(Product product)
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
            Console.WriteLine("Applying BookProductPaymentStrategy  ");
            GenerateCommisionPayment();
            GenerateDupliacteSlip();
        }

        private void GenerateCommisionPayment()
        {
            Console.WriteLine("Generated Commission  payment");
        }

        private void GenerateDupliacteSlip()
        {
            Console.WriteLine("Generated Duplicate slip");
        }

    }
}
