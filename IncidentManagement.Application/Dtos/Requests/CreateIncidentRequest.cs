namespace IncidentManagement.Application.Dtos.Requests
{
    //The DTO knows the database so it creates the entity
    public record CreateIncidentRequest(
        string Title,
        string Description,
        int UserId,
        int CategoryId,
        int SeverityId,
        int StatusId,
        int PriorityId,
        int PropertyId
    );
}
