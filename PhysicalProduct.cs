using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BREPOC
{
    class PhysicalProduct : Product
    {
        private readonly string _productType;
        private string _productName;
        private decimal _productCost;
        public PhysicalProduct(Product product)
        {
            _productName = product.ProductName;
            _productType = product.ProductType;
            _productCost = product.ProductCost;
        }
        public override string ProductName { get { return _productName; } }

        public override string ProductType { get { return _productType; } }

        public override decimal ProductCost
        {
            get { return _productCost; }
            set { _productCost = value; }
        }
    }
}
