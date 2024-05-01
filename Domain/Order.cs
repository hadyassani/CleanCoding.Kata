namespace Domain
{
    public sealed class Order
    {
        public long Id { get; internal set; }
        public bool IsVerified { get; internal set; }
        public bool IsProcessed { get; internal set; }
        public OrderStatus Status { get; internal set; } = OrderStatus.Pending;
        public List<LineItem> Items { get; internal set; } = new();
    }
}
