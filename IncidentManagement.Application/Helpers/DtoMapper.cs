using IncidentManagement.Application.Dtos.Requests;
using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.Domain.Entities;

namespace IncidentManagement.Application.Helpers
{
    public static class DtoMapper
    {
        public static IncidentResponse MapToResponse(Incident incident) =>
        new IncidentResponse(
            incident.IncidentId,
            incident.Title,
            incident.Description,
            incident.User?.Username ?? string.Empty,
            incident.Category?.CategoryName ?? string.Empty,
            incident.Severity?.SeverityName ?? string.Empty,
            incident.Status?.StatusName ?? string.Empty,
            incident.Priority?.PriorityName ?? string.Empty,
            incident.User?.Username ?? string.Empty,
            incident.Property?.PropertyName ?? string.Empty,
            incident.CreatedAt,
            incident.UpdatedAt
        );

        public static UserResponse MapToResponse(User user) =>
            new UserResponse(
                        user.UserId,
                        user.Username ?? string.Empty,
                        user.Email ?? string.Empty,
                        user.PhoneNumber ?? string.Empty,
                        user.WhatsAppNumber ?? string.Empty,
                        user.PropertyId,
                        user.IsActive
            );

        public static IEnumerable<IncidentResponse> MapToResponse(IEnumerable<Incident> incidents)
        {
            var responses = new List<IncidentResponse>();

            foreach (var incident in incidents)
            {                
                var response = MapToResponse(incident);
                responses.Add(response);
            }

            return responses;
        }
        public static IEnumerable<UserResponse> MapToResponse(IEnumerable<User> users)
        {
            var responses = new List<UserResponse>();

            foreach (var user in users)
            {
                var response = MapToResponse(user);
                responses.Add(response);
            }

            return responses;
        }

        public static Incident MapToEntity(CreateIncidentRequest request) =>
            new Incident(
                request.Title,
                request.Description,
                request.UserId,
                request.CategoryId,
                request.SeverityId,
                request.StatusId,
                request.PriorityId,               
                request.PropertyId
            );

        public static User MapToEntity(CreateUserRequest request) =>
            new User(
                    request.Username ?? string.Empty,
                    request.Email ?? string.Empty,
                    request.PhoneNumber,
                    request.WhatsAppNumber,           
                    request.PasswordHash,
                    request.PasswordSalt,
                    request.PropertyId
            );
    }
}
