using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public sealed class OrderNotReadyFroProcessingException : Exception
    {
        public long OrderId { get; set; }
        public OrderNotReadyFroProcessingException(long orderId) :
            base($"The order { orderId } isn't ready to process.")
        {
            OrderId = orderId;
        }
    }
}
