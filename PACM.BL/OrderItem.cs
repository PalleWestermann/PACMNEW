using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; private set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        ///     Retrieves the order item with the specified identifier.
        /// </summary>
        /// <param name="orderItemId">The unique identifier of the order item to retrieve.</param>
        /// <returns>An OrderItem representing the requested order item.</returns>
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined order item.
            return new OrderItem();
        }

        /// <summary>
        ///     Saves the current order item to the underlying data store.
        /// </summary>
        /// <returns>true if the order item was saved successfully; otherwise, false.</returns>
        public bool Save()
        {
            // Code that saves the defined order item.
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            if (Quantity <= 0) isValid = false;
            return isValid;
        }
    }
}
