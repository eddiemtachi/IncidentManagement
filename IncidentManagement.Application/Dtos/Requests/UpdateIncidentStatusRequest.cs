namespace IncidentManagement.Application.Dtos.Requests
{
    public record UpdateIncidentStatusRequest(
        int IncidentId, 
        int StatusId
    );
}
