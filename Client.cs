namespace JobMagnet.Domain.Entities
{
    public class Client : AuditableEntity
    {
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string? LegalName { get; set; }
        public string? ContactPhone { get; set; }
        // Modified: Replaced string Address with AddressId
        public int? AddressId { get; set; }
        public Address? ClientAddress { get; set; }
        public string? IdentityDocumentUrl { get; set; }
        public bool IsVerified { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
    }
}
