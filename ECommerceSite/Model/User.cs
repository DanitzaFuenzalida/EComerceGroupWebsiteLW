namespace ECommerceSite.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // You should hash and salt the password.
                                             // Add other user-related properties like addresses, roles, etc.
    }

}
