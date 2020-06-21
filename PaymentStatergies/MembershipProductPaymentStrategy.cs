using System;

namespace BREPOC.PaymentStatergies
{
     public class MembershipProductPaymentStrategy : IPaymentStatergy
    {
        private Product _product = null;
        public MembershipProductPaymentStrategy(Product product)
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
            Console.WriteLine("Applying  MembershipProductPaymentStrategy");
            if (CheckMembership())
            {
                ActivateMembership();
            }
            else
            {

                UpgradeMembership();
            }
            EmailMembershipDetails();
        }

        private void ActivateMembership()
        {
            Console.WriteLine("Activate membership");
        }
        private void UpgradeMembership()
        {
            Console.WriteLine("Upgraded membership");
        }

        private void EmailMembershipDetails()
        {
            Console.WriteLine("Membership details emailed");
        }
        private bool CheckMembership()
        {
            bool isMember = false;
            //LOGIC TO BE IMPLEMENTED
            return isMember;

        }
    }
}
