namespace JobMagnet.Domain.Entities
{
    // New: System Configuration Entity
    public class SystemSetting : AuditableEntity
    {
        public int SystemSettingId { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsSensitive { get; set; } = false;
    }
}
