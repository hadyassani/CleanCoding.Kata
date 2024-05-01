using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public record ProcessOrderResult
    {
        public long OrderId { get; set; }
        public string Message { get; set; }
        private ProcessOrderResult(long orderId, string message)
        {
            OrderId = orderId;
            Message = message;
        }

        public static ProcessOrderResult NotProcessable() =>
            new(default, $"The order is not processable.");
        public static ProcessOrderResult NotReadyForProcess(long orderId) =>
            new(orderId, $"The order {orderId} is not ready for process.");
        public static ProcessOrderResult HasTooManyLineItems(long orderId) =>
            new(orderId, $"The order {orderId} has too many line items.");

        public static ProcessOrderResult Successful(long orderId) =>
          new(orderId, $"The order {orderId} has been processed succefully.");
    }
}
