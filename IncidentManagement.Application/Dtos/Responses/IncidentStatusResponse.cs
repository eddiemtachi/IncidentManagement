namespace IncidentManagement.Application.Dtos.Responses
{
    public record IncidentStatusResponse(
        int StatusId,
        string StatusName
    );
}
