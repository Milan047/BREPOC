using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BREPOC
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the product type : ");
            //string proudctType = Console.ReadLine();
            //Console.Write("Enter the product name : ");
            //string proudctName = Console.ReadLine();
            //Console.Write("Enter the product cost : ");
            //string cost = Console.ReadLine();
            //decimal productCost = Convert.ToDecimal(cost);
            // var product = new Product { ProductName = proudctName, ProductType = proudctType, ProductCost = productCost };

        }

        public static IPaymentStatergy GetPaymentLogic(Product product)
        {
            ProductFactory pFactory = null;
            //This object creation process will be moved to a DI framework(Unity,AutoFac) in futute
            switch (product.ProductType.ToUpper())
            {
                case "BOOK":
                    pFactory = new BookProductFactory(product);
                    break;
                case "VIDEO":
                    pFactory = new VideoProductFactory(product);
                    break;
                case "MEMBERSHIP":
                    pFactory = new MembershipProductFactory(product);
                    break;
                case "PHYSICAL":
                    pFactory = new MembershipProductFactory(product);
                    break;
                default:
                    break;
            }
            Product productC
                = pFactory.GetProduct();
            Console.WriteLine("\nYour product details are below : \n");
            Console.WriteLine("Product Name: {0}\nProductType: {1}\nProductCost: {2}",
                product.ProductName, product.ProductType, product.ProductCost);
            IPaymentStatergy paymentStrategy = pFactory.GetPaymentStatergy();
            paymentStrategy.ProcessPayment();
            return paymentStrategy;

        }
    }
}
