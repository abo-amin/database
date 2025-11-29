namespace JobMagnet.Domain.Entities
{
    public class Rating : AuditableEntity
    {
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public decimal AverageRating { get; set; }
        public int TotalReviews { get; set; }
    }
}
