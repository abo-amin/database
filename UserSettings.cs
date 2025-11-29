namespace JobMagnet.Domain.Entities
{
    public class UserSettings : AuditableEntity
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string? PreferredLanguage { get; set; }
        public string? TimeZone { get; set; }
        public bool EmailNotificationsEnabled { get; set; } = true;
        public string? SettingsJson { get; set; }
    }
}
