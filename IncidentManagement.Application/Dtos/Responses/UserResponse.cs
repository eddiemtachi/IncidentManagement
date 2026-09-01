namespace IncidentManagement.Application.Dtos.Responses
{
    public record UserResponse(int Id, string Username, string Email, string PhoneNumber, string WhatsAppNumber, bool IsActive);
}
