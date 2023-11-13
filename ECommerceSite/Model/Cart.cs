namespace ECommerceSite.Model
{
    public class Cart
    {
        public int CartId { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public required string UserId { get; set; } 
        public List<OrderItem>? OrderItems { get; set; }
    }
}
