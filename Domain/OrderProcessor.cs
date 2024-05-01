namespace Domain
{
    public class OrderProcessor
    {
        private const int ProcessableNumberOfLineItems = 15;
        public ProcessOrderResult Process(Order? order)
        {
            if (!OrderIsProcessable(order))
            {
                return ProcessOrderResult.NotProcessable() ;
            }

            if (order!.Items.Count > ProcessableNumberOfLineItems)
            {
                return ProcessOrderResult.HasTooManyLineItems(order.Id);
            }

            if (order.Status != OrderStatus.ReadyToprocess)
            {
                return ProcessOrderResult.NotReadyForProcess(order.Id);
            }

            order.IsProcessed = true;


            return ProcessOrderResult.Successful(order.Id);
        }

        private static bool OrderIsProcessable(Order? order)
        {
            return order != null &&
                   order.IsVerified &&
                   order.Items.Any();
        }
    }
}