namespace ECommerceSite.Model
{
    public class Address
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        // Add more address-related properties as needed.
    }

}
