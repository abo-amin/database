using System;

namespace JobMagnet.Domain.Entities
{
    public class JobApplication : AuditableEntity
    {
        public int JobApplicationId { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; } = null!;
        public int JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; } = null!;
        public string? CoverLetter { get; set; }
        public string Status { get; set; } = "Pending"; // e.g., Pending, Reviewed, Interview, Rejected, Hired
        public DateTimeOffset AppliedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
