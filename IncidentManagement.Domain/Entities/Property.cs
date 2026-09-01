namespace IncidentManagement.Domain.Entities
{
    public class Property
    {
        public int PropertyId { get; private set; }
        public string? PropertyName { get; private set; }
        public string? AddressLine1 { get; private set; }
        public string? AddressLine2 { get; private set; }
        public string? City { get; private set; }
        public string? Province { get; private set; }
        public string? PostalCode { get; private set; }
    }
}
