using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public sealed class OrderHasTooManyItemsException : Exception
    {
        public long OrderId { get; set; }
        public OrderHasTooManyItemsException(long orderId) :
            base($"The order { orderId } has too many items.")
        {
            OrderId = orderId;
        }
    }
}
