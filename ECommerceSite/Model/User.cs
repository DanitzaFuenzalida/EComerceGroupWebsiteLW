namespace ECommerceSite.Model
{
    public class User
    {
        public int UserId { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; } // You should hash and salt the password.
                                             // Add other user-related properties like addresses, roles, etc.
        public string? CreditCardNumber {  get; set; }

        public int Age { get; set; }
        public string? Interests { get; set; }

    }

}
