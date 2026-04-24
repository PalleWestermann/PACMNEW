using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class Order
    {
        public Order(): this(0)
        {
            
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";


        /// <summary>
        /// Retrieve one order.
        /// </summary>  
        /// 
        //public Order Retrieve (int orderId)
        //{
        //    // Code that retrieves the defined order.
        //    return new Order();
        //}

        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        //public bool Save()
        //{
        //    // Code that saves the defined order.
        //    return true;
        //}

        /// <summary>
        ///  Determines whether the current object is in a valid state for processing.
        /// </summary>
        /// <returns>true if the object passes validation checks; otherwise, false.</returns>

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
