using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string _productName;
        public string ProductName 
        {
            get { return _productName; } 
            set { _productName = value; } 
        }


        public override string ToString() => ProductName;

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        /// 
        //public Product Retrieve(int productId)
        //{
        //    // Code that retrieves the defined product.
        //    return new Product();
        //}

        //public bool Save()
        //{
        //    // Code that saves the defined product.
        //    return true;
        //}

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
