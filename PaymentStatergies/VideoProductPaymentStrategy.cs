using System;

namespace BREPOC.PaymentStatergies
{
    class VideoProductPaymentStrategy : IPaymentStatergy
    {
        private Product _product = null;
        public VideoProductPaymentStrategy(Product product)
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
            Console.WriteLine("Applying  VideoProductPaymentStrategy");
            if (_product.ProductName == "Learning to Ski")
            {
                AddFirstAid();

            }
            // ADDITIONAL LOGIC TO BE IMPLEMENTED

        }

        private void AddFirstAid()
        {
            Console.WriteLine("First Aid Kit added");
        }


    }
}
