using BREPOC;
using BREPOC.PaymentStatergies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BRETEST
{
    [TestClass]
    public class UnitTest1
    {
        Product producttypeBook = new Product { ProductName = "JungleBook", ProductType = "Book", ProductCost = 120 };
        Product producttypeMembership = new Product { ProductName = "Cult", ProductType = "Membership", ProductCost = 1200 };
        Product producttypePhysical = new Product { ProductName = "Fridge", ProductType = "Physical", ProductCost = 123000 };
        Product producttypeVideo = new Product { ProductName = "MS Dhoni", ProductType = "Video", ProductCost = 1244 };
        [TestMethod]
        public void TestBookPaymentStrategy()
        {
            //TESTING A NEGATIVE SCENARIO ONCE THE TYPE IS CHANGED TO "BookProductPaymentStrategy" IT WILL WORK
            IPaymentStatergy paymentStatergy = Program.GetPaymentLogic(producttypeBook);
            Assert.AreEqual(typeof(PhysicalProductPaymentStrategy), (paymentStatergy).GetType());

        }
        [TestMethod]
        public void TestPhysicalPaymentStrategy()
        {

            IPaymentStatergy paymentStatergy = Program.GetPaymentLogic(producttypePhysical);
            Assert.AreEqual(typeof(PhysicalProductPaymentStrategy), (paymentStatergy).GetType());
        }
        [TestMethod]
        public void TestVideoPaymentStrategy()
        {

            IPaymentStatergy paymentStatergy = Program.GetPaymentLogic(producttypeVideo);
            Assert.AreEqual(typeof(VideoProductPaymentStrategy), (paymentStatergy).GetType());
        }
        [TestMethod]
        public void TestMembershipPaymentStrategy()
        {

            IPaymentStatergy paymentStatergy = Program.GetPaymentLogic(producttypeMembership);
            Assert.AreEqual(typeof(MembershipProductPaymentStrategy), (paymentStatergy).GetType());
        }
    }
}
