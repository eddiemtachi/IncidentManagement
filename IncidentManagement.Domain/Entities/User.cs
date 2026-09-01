namespace IncidentManagement.Domain.Entities
{
    public class User
    {
        public int UserId { get; private set; }
        public string? Username { get; private set; }
        public string? Email { get; private set; }
        public string? PhoneNumber { get; private set; }
        public string? WhatsAppNumber { get; private set; }
        public byte[]? PasswordHash { get; private set; }
        public byte[]? PasswordSalt { get; private set; }
        public int PropertyId { get; private set; }
        public Property? Property { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? LastLogin { get; private set; }
    }
}
