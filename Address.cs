namespace JobMagnet.Domain.Entities
{
    // New: Structured Address Entity
    public class Address : AuditableEntity
    {
        public int AddressId { get; set; }
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public string? StateProvince { get; set; }
        public string Country { get; set; } = null!;
        public string? ZipCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? FullAddressText { get; set; } // For display/search convenience
    }
}
