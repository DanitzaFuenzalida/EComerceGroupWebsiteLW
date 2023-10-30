namespace ECommerceSite.Model
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; } // If you want to associate reviews with users.
        public string Comment { get; set; }
        public int Rating { get; set; }
    }

}
